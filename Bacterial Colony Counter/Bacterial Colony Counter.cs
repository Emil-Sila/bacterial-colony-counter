using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Xml.Serialization;
using System.IO;


namespace Bacterial_Colony_Counter
{
    public partial class BacterialColonyCounter : Form
    {
        bool leftDown, rightDown;
        bool checkBoxCollision = false;
        bool stopwatchRunning = false;
        Stopwatch stopwatchManual = new Stopwatch();
        Stopwatch stopwatchHough = new Stopwatch();
        string imageFileName, imagePath;
        Image origImage;
        Image<Gray, Byte> imageProcessingGray, imageProcessingWork, imageProcessingFinal;
        string[] filesImages;
        string[] filesXML;

        Gray threshold;
        double thresholdCanny, threshLinking = 0;
        Gray maxValueThreshold = new Gray(255);
        int _GaussKernel = 5;
        double _GaussSigma = 5;
        double gamma = 1;
        int adaptiveThreshType = 1;
        int adaptiveThreshKernel = 15;
        int adaptiveConstantInt = 1;
        Gray adaptiveConstant = new Gray(1);

        Pen penHover = new Pen(Color.FromArgb(127, 127, 127), 4);
        Pen penMarked = new Pen(Color.FromArgb(127, 255, 0, 0), 4);
        Pen penHough = new Pen(Color.FromArgb(127, 100, 255, 100), 4);
        Pen penTemp;

        Point mousePosition;
        int markerSize = 20;
        int eraserSizePow2 = 100;
        Size pointDrawSize;

        ImageDetections currentImageDetections = new ImageDetections();
        Colony defaultColony = new Colony();
        Colony _HoughCircleDetectionsColony = new Colony();

        // The higher threshold of the two passed to Canny edge detector (the lower one will be twice smaller)
        Gray cannyThreshold = new Gray(80);
        // Accumulator threshold at the center detection stage. The smaller it is, the more false circles may be detected. 
        // Circles, corresponding to the larger accumulator values, will be returned first
	    Gray accumulatorThreshold = new Gray(30);
        
        // Minimum distance between centers of the detected circles. 
        // If the parameter is too small, multiple neighbor circles may be falsely detected in addition to a true one. 
        // If it is too large, some circles may be missed
	    double minDist = 10;
        // Minimal radius of the circles to search for
	    int minRadius = 5;
        // Maximal radius of the circles to search for
        int maxRadius = 200;

        CircleF[] _HoughDetections;

        public BacterialColonyCounter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnColorPicker.BackColor = penMarked.Color;

            // TEST: Initial loading for the default Colony
            ///
            //currentImageDetections.globalCounter = 0;
            currentImageDetections.resetDetections();
            defaultColony.penWidth = (int)penMarked.Width;
            SetColorsForXML(defaultColony, penMarked);
            defaultColony.colonyName = "defaultColony";
            defaultColony.localCounter = 0;
            currentImageDetections.colonyList.Add(defaultColony);
            ///
            // TEST: Initial loading for the Hough Colony
            ///
            _HoughCircleDetectionsColony.penWidth = (int)penHough.Width;
            SetColorsForXML(_HoughCircleDetectionsColony, penHough);
            _HoughCircleDetectionsColony.colonyName = "HoughCircleDetectionsColony";
            _HoughCircleDetectionsColony.localCounter = 0;
            currentImageDetections.colonyList.Add(_HoughCircleDetectionsColony);
            ///
        }

        // Function for saving detections in the currentImageDetections as XML file
        public void SaveDetectionsAsXML(string imagePath, ImageDetections detections)
        {
            XmlSerializer SaveAsXML = new XmlSerializer(typeof(ImageDetections));
            using (TextWriter writer = new StreamWriter(imagePath + ".xml", false))
            {
                SaveAsXML.Serialize(writer, detections);
            } 
        }

        // Function for loading detections in the currentImageDetections from an XML file
        public void LoadDetectionsFromXML(string imagePath)
        { 
            XmlSerializer LoadFromXML = new XmlSerializer(typeof(ImageDetections));
            using (FileStream fileStream = new FileStream(imagePath + ".xml", FileMode.Open))
            {
                currentImageDetections = (ImageDetections)
                LoadFromXML.Deserialize(fileStream);
            }
        }

        private void SetColorsForXML(Colony colony ,Pen pen)
        {
            colony.penColor.Add(pen.Color.A);
            colony.penColor.Add(pen.Color.R);
            colony.penColor.Add(pen.Color.G);
            colony.penColor.Add(pen.Color.B);
        }

        private void ColorFromXML(Colony colony)
        {
           
        }

        public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            string[] searchPatterns = searchPattern.Split('|');
            List<string> files = new List<string>();
            foreach (string sp in searchPatterns)
                files.AddRange(System.IO.Directory.GetFiles(path, sp, searchOption));
            files.Sort();
            return files.ToArray();
        }

        // Function that deletes a detection point if it is located less than a fixed amount from the mouse pointer
        // It is activated on right mouse click
        public void DeleteDetection(Point mousePosition)
        {
            if (rbBtnEraserManual.Checked)
            {
                // Calculates distance between 2 points, current mouse location and all marked detection points
                foreach (CircleF manualDetectionPoint in defaultColony.markerLocationList)
                {
                    int distPow2 = Math.Abs(((int)manualDetectionPoint.Center.X - mousePosition.X) * ((int)manualDetectionPoint.Center.X - mousePosition.X) +
                        ((int)manualDetectionPoint.Center.Y - mousePosition.Y) * ((int)manualDetectionPoint.Center.Y - mousePosition.Y));
                    // If the distance is less than pre-set eraser size, delete that detection point from the list
                    if (distPow2 < eraserSizePow2)
                    {
                        defaultColony.markerLocationList.Remove(manualDetectionPoint);
                        imageBoxColony.Invalidate();
                        defaultColony.localCounter -= 1;
                        currentImageDetections.globalCounter -= 1;
                        break;
                    }
                }
            }
            else
            {
                // Calculates distance between 2 points, current mouse location and all detection points found by Hough circle algorithm
                foreach (CircleF _HoughDetectionPoint in _HoughCircleDetectionsColony.markerLocationList)
                {
                    int distPow2 = Math.Abs(((int)_HoughDetectionPoint.Center.X - mousePosition.X) * ((int)_HoughDetectionPoint.Center.X - mousePosition.X) +
                        ((int)_HoughDetectionPoint.Center.Y - mousePosition.Y) * ((int)_HoughDetectionPoint.Center.Y - mousePosition.Y));
                    // If the distance is less than pre-set eraser size, delete that detection point from the list
                    if (distPow2 < eraserSizePow2)
                    {
                        _HoughCircleDetectionsColony.markerLocationList.Remove(_HoughDetectionPoint);
                        imageBoxColony.Invalidate();
                        _HoughCircleDetectionsColony.localCounter -= 1;
                        currentImageDetections.globalCounter -= 1;
                        break;
                    }
                }
            }
            
        }

        public void UpdateTimes()
        {     
            TimeSpan timeSpanManual = stopwatchManual.Elapsed;
            string elapsedManualTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpanManual.Hours, timeSpanManual.Minutes, timeSpanManual.Seconds, timeSpanManual.Milliseconds / 10);
            lblManualTime.Text = "Manual: " + elapsedManualTime;

            TimeSpan timeSpanHough = stopwatchHough.Elapsed;
            string elapsedHoughTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpanHough.Hours, timeSpanHough.Minutes, timeSpanHough.Seconds, timeSpanHough.Milliseconds / 10);
            lblHoughTime.Text = "Hough: " + elapsedHoughTime;

            TimeSpan timeSpanTotal = stopwatchManual.Elapsed + stopwatchHough.Elapsed;
            string elapsedTotalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpanTotal.Hours, timeSpanTotal.Minutes, timeSpanTotal.Seconds, timeSpanTotal.Milliseconds / 10);
            lblTotalTime.Text = "Total: " + elapsedTotalTime;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            dataGridViewFiles.ClearSelection();
            // Opens the file dialog with a filter for images
            try
            {

                OpenFileDialog fDialog = new OpenFileDialog();
                fDialog.InitialDirectory = "D:/";
                fDialog.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|"
                               + "BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|"
                               + "JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|"
                               + "GIF Files: (*.GIF)|*.GIF|"
                               + "TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|"
                               + "PNG Files: (*.PNG)|*.PNG|"
                               + "All Files|*.*";

                if (fDialog.ShowDialog() == DialogResult.OK)
                {
                    // Take image name without the path or extension
                    //imageName = fDialog.SafeFileName.Split('.')[0];
                    // Full path and image name with extension
                    imageFileName = fDialog.FileName;
                    // Just the image path
                    imagePath = imageFileName.Split('.')[0];
                    // Save the image in origImage variable
                    origImage = Image.FromFile(imageFileName);

                    // Display the loaded image in the imageBox
                    imageBoxColony.Image = origImage;
                    imageBoxColony.ZoomToFit();
                    imageBoxColony.Focus();



                    //Bitmap imageProcessing = (Bitmap)origImage;
                    imageProcessingGray = new Image<Gray, Byte>((Bitmap)origImage);
                    rbDisplayOriginal.Enabled = true;
                    rbDisplayPreProcessing.Enabled = true;
                    rbDisplayOriginal.Checked = true;

                    // Try loading ImageDetections class from XML that includes previos detection points, pen settings, etc.
                    try
                    {
                        LoadDetectionsFromXML(imagePath);
                        // Set the colony to equal saved colony
                        defaultColony = currentImageDetections.colonyList[0];
                        _HoughCircleDetectionsColony = currentImageDetections.colonyList[1];
                        imageBoxColony.Invalidate();

                        lblTotalDetections.Text = currentImageDetections.globalCounter.ToString();
                        lblManualDetections.Text = currentImageDetections.colonyList[0].localCounter.ToString();
                        lblHoughDetections.Text = currentImageDetections.colonyList[1].localCounter.ToString();
                    }
                    // Ignore if there is no file
                    catch (FileNotFoundException)
                    {
                        currentImageDetections.resetDetections();
                        lblTotalDetections.Text = "0";
                        lblManualDetections.Text = "0";
                        lblHoughDetections.Text = "0";

                        btnClear.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading from XML file:\n\n" + ex.Message.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while opening the selected image:\n\n" + ex.Message.ToString());
            }

        }

        // Button Load (click event handler) for loading images
        private void btnLoadFolder_Click(object sender, EventArgs e)
        {

            DaveChambers.FolderBrowserDialogEx.FolderBrowserDialogEx folderDialog = new DaveChambers.FolderBrowserDialogEx.FolderBrowserDialogEx();
            // These are identical to FolderBrowserDialog:
            folderDialog.ShowNewFolderButton = false;
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            // These are specific to FolderBrowserDialogEx
            folderDialog.Title = "Select a folder";
            folderDialog.ShowEditbox = true;
            folderDialog.StartPosition = FormStartPosition.CenterScreen;

            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                dataGridViewFiles.Rows.Clear();
                filesImages = GetFiles(folderDialog.SelectedPath, "*.BMP|*.DIB|*.RLE|*.JPG|*.JPEG|*.JPE|*.JFIF|*.GIF|*.TIF|*.TIFF|*.PNG", SearchOption.TopDirectoryOnly);
                filesXML = Directory.GetFiles(folderDialog.SelectedPath, "*.xml");

                for (int i = 0; i < filesXML.Length; i++ )
                {
                    filesXML[i] = Path.GetFileName(filesXML[i]);
                }

                foreach (var image in filesImages)
                {
                    string imageName = Path.GetFileNameWithoutExtension(image);
                    int n = dataGridViewFiles.Rows.Add();

                    dataGridViewFiles.Rows[n].Cells[0].Value = imageName;

                    if (filesXML.Contains(imageName + ".xml"))
                    {
                        dataGridViewFiles.Rows[n].Cells[1].Value = true;
                    }
                }

            }
            
        }

        // TEST: Button Save (click event handler) that saves the image from imageBox
        // DEBUG: Only saves image as seen in the imageBox, must try to save the whole image
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                   int width = Convert.ToInt32(imageBoxColony.Width); 
                   int height = Convert.ToInt32(imageBoxColony.Height); 
                   Bitmap bmp = new Bitmap(width,height);        
                   imageBoxColony.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                   bmp.Save(dialog.FileName);
                }
            }
            catch{}
        }

        // Button Save Detections (click event handler) that saves detections to an XML file
        private void btnSaveDetections_Click(object sender, EventArgs e)
        {
            SaveDetectionsAsXML(imagePath.Split('.')[0], currentImageDetections);
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                dataGridViewFiles.CurrentRow.Cells[1].Value = true;
            }
            imageBoxColony.Focus();
        }

        // TEST: Button Clear (click event handler)
        // DEBUG: Doesn't work properly, more testing reqired
        private void buttonClear_Click(object sender, EventArgs e)
        {
            defaultColony.markerLocationList.Clear();
            _HoughCircleDetectionsColony.markerLocationList.Clear();
            lblTotalDetections.Text = "0";
            lblManualDetections.Text = "0";
            lblHoughDetections.Text = "0";
            penTemp = null;
            imageBoxColony.Invalidate();
            imageBoxColony.Focus();
        }

        // Button Hough Detect (click event handler)
        private void btnHoughDetect_Click(object sender, EventArgs e)
        {
            if (!backgroundWorkerHoughDetection.IsBusy)
            {
                // Load data from text boxes
                try
                {
                    int numCannyThreshold;
                    int.TryParse(txtBoxCannyThreshold.Text, out numCannyThreshold);
                    cannyThreshold = new Gray(numCannyThreshold);

                    int numAccumulatorThreshold;
                    int.TryParse(txtBoxAccumulatorThreshold.Text, out numAccumulatorThreshold);
                    accumulatorThreshold = new Gray(numAccumulatorThreshold);

                    double numMinDist;
                    double.TryParse(txtBoxMinDist.Text, out numMinDist);
                    minDist = numMinDist;

                    int numMinRadius;
                    int.TryParse(txtBoxMinRadius.Text, out numMinRadius);
                    minRadius = numMinRadius;

                    int numMaxRadius;
                    int.TryParse(txtBoxMaxRadius.Text, out numMaxRadius);
                    maxRadius = numMaxRadius;
                }
                catch { }

                if (origImage != null)
                {
                    // Call the background worker to complete Hough circle detection
                    backgroundWorkerHoughDetection.RunWorkerAsync();

                    btnHoughDetect.Text = "STOP Hough detect";
                }
                else
                {
                    MessageBox.Show("Error: No image is loaded, please open the image with \"Load Image\" button.",
		            "Image not loaded",
		            MessageBoxButtons.OK,
		            MessageBoxIcon.Exclamation);
                    btnLoadFolder.Focus();
                }
                
            }
            else
            {
                btnHoughDetect.Text = "Cancelling Hough detect...";
                btnHoughDetect.Enabled = false;
                backgroundWorkerHoughDetection.CancelAsync();
            }
        }


        // Mouse down (event handler). 
        private void imageBoxColony_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rbDisplayPreProcessing.Checked)
            {
                mousePosition = e.Location;

                // Draws a possible detection location if left mouse button is pressed 
                // (see Paint event for more details)
                if (e.Button == MouseButtons.Left)
                {
                    leftDown = true;
                    penTemp = penHover;
                    imageBoxColony.Invalidate();
                }

                // Deletes a detection if right mouse button is pressed
                // (see DeleteDetection function for more details)
                if (e.Button == MouseButtons.Right)
                {
                    rightDown = true;
                    int.TryParse(txtBoxEraserSize.Text, out eraserSizePow2);
                    eraserSizePow2 *= eraserSizePow2;
                    DeleteDetection(imageBoxColony.PointToImage(mousePosition));
                }
            } 
        }

        // Mouse move (event handler).
        private void imageBoxColony_MouseMove(object sender, MouseEventArgs e)
        {
            // Pan with middle mouse button
            if (e.Button == MouseButtons.Middle)
            {
                imageBoxColony.ProcessPanning(e);
            }

            // Draws a possible detection location with a custom Pen if left mouse button is pressed
            // (see Paint event for more details)
            if (e.Button == MouseButtons.Left)
            {
                if(leftDown)
                {
                    mousePosition = e.Location;
                    penTemp = penHover;
                    imageBoxColony.Invalidate();
                }
            }

            // Deletes a detection if right mouse button is pressed (see DeleteDetection function for more details)
            if (e.Button == MouseButtons.Right)
            {
                if (rightDown)
                {
                    mousePosition = e.Location;
                    DeleteDetection(imageBoxColony.PointToImage(mousePosition));
                    imageBoxColony.Invalidate();
                }
            }
        }

        // Mouse up (event handler).
        private void imageBoxColony_MouseUp(object sender, MouseEventArgs e)
        {
            if (!rbDisplayPreProcessing.Checked)
            {
                // Adds a detection point in markerLocationList if the left mouse button was released
                if (e.Button == MouseButtons.Left)
                {
                    // Checks if the point where the mouse was released is in the image view port
                    if (imageBoxColony.IsPointInImage(e.Location))
                    {
                        leftDown = false;
                        // Convert mouse location to coordinates on image
                        Point pointOnImage = imageBoxColony.PointToImage(e.Location);
                        // Add point clicked to markerLocationList
                        CircleF circleDetection = new CircleF(pointOnImage, markerSize);
                        defaultColony.markerLocationList.Add(circleDetection);

                        defaultColony.localCounter += 1;
                        currentImageDetections.globalCounter += 1;

                        lblTotalDetections.Text = currentImageDetections.globalCounter.ToString();
                        lblManualDetections.Text = currentImageDetections.colonyList[0].localCounter.ToString();

                        penTemp = null;
                        imageBoxColony.Invalidate();
                    }
                }

                if (e.Button == MouseButtons.Right)
                {
                    rightDown = false;
                    imageBoxColony.Invalidate();
                    lblTotalDetections.Text = currentImageDetections.globalCounter.ToString();
                    lblManualDetections.Text = currentImageDetections.colonyList[0].localCounter.ToString();
                    lblHoughDetections.Text = currentImageDetections.colonyList[1].localCounter.ToString();
                }
            }  
        }

        // imageBox paint (event handler)
        private void imageBoxColony_Paint(object sender, PaintEventArgs e)
        {
            // Work out the drawing size of the marker graphic according to the current zoom level
            pointDrawSize = imageBoxColony.GetScaledSize(markerSize,markerSize);

            // Draw the point marker when the left mouse button is pressed and moving
            if (penTemp != null)
            {
                // Convert mouse location to coordinates on image
                Point pointOnImage = imageBoxColony.PointToImage(mousePosition);
                // Work out the location of the marker graphic according to the current zoom level and scroll offset
                var offsetPoint = imageBoxColony.GetOffsetPoint(pointOnImage.X, pointOnImage.Y);
                // Draw the marker with a defined size and pen
                e.Graphics.DrawEllipse(
                    penTemp,
                    offsetPoint.X - pointDrawSize.Width / 2,
                    offsetPoint.Y - pointDrawSize.Height / 2,
                    pointDrawSize.Width, pointDrawSize.Height);
            }

            // Draw all the markers in pointList
            if (defaultColony.markerLocationList != null)
            {
                foreach (var location in defaultColony.markerLocationList)
                {
                    pointDrawSize = imageBoxColony.GetScaledSize(Convert.ToInt16(location.Radius), Convert.ToInt16(location.Radius));
                    // Work out the location of the marker graphic according to the current zoom level and scroll offset
                    var offsetPoint = imageBoxColony.GetOffsetPoint(location.Center.X, location.Center.Y);
                    // Draw the markers
                    e.Graphics.DrawEllipse(
                        penMarked, 
                        offsetPoint.X - pointDrawSize.Width / 2,
                        offsetPoint.Y - pointDrawSize.Height / 2, 
                        pointDrawSize.Width, pointDrawSize.Height);
                }

                foreach (var location in _HoughCircleDetectionsColony.markerLocationList)
                {
                    pointDrawSize = imageBoxColony.GetScaledSize(Convert.ToInt16(location.Radius), Convert.ToInt16(location.Radius));
                    // Work out the location of the marker graphic according to the current zoom level and scroll offset
                    var offsetPoint = imageBoxColony.GetOffsetPoint(location.Center.X, location.Center.Y);
                    // Draw the markers
                    e.Graphics.DrawEllipse(
                        penHough,
                        offsetPoint.X - pointDrawSize.Width / 2,
                        offsetPoint.Y - pointDrawSize.Height / 2,
                        pointDrawSize.Width, pointDrawSize.Height);
                }
            }
        }

        private void comboBoxCircleSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(comboBoxCircleSize.Text, out markerSize);
            imageBoxColony.Focus();
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                btnColorPicker.BackColor = colorDialog.Color;
                penMarked = new Pen(Color.FromArgb(penMarked.Color.A, colorDialog.Color), 4);
                SetColorsForXML(defaultColony, penMarked);
                imageBoxColony.Focus();
            }

            imageBoxColony.Invalidate();
        }

        private void backgroundWorkerHoughDetection_DoWork(object sender, DoWorkEventArgs e)
        {
            stopwatchHough.Reset();
            stopwatchHough.Start();
            // Resolution of the accumulator used to detect centers of the circles. 
            // For example, if it is 1, the accumulator will have the same resolution as the input image, 
            // if it is 2 - accumulator will have twice smaller width and height, etc
            double dp = 1;

            CircleF[] detections = imageProcessingWork.HoughCircles(cannyThreshold, accumulatorThreshold, dp, minDist, minRadius, maxRadius)[0];

            if (backgroundWorkerHoughDetection.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                e.Result = detections;
            }
        }

        private void backgroundWorkerHoughDetection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                btnHoughDetect.Text = "Start Hough detect";
                btnHoughDetect.Enabled = true;
                stopwatchHough.Stop();
                stopwatchHough.Reset();
            }
            else
            {
                _HoughDetections = (CircleF[])e.Result;
                // Clear previos Hough circle detections (POSSIBLE 1 UNDO STEP can be added here)
                _HoughCircleDetectionsColony.markerLocationList.Clear();
                foreach (var houghDetection in _HoughDetections)
                {
                    _HoughCircleDetectionsColony.markerLocationList.Add(houghDetection);
                }

                var houghDetectionCount = _HoughDetections.Count();
                currentImageDetections.colonyList[1].localCounter = houghDetectionCount;

                int totalCount = 0;
                foreach (var _colony in currentImageDetections.colonyList)
                {
                    totalCount += _colony.localCounter;
                }
                currentImageDetections.globalCounter = totalCount;
                lblTotalDetections.Text = totalCount.ToString();
                lblHoughDetections.Text = houghDetectionCount.ToString();

                rbDisplayOriginal.Checked = true;

                stopwatchHough.Stop();
                UpdateTimes();
                MessageBox.Show("Hough circle detection algorithm finished.\n" + houghDetectionCount.ToString() + " detected circles.");
                imageBoxColony.Focus();

                btnHoughDetect.Text = "Start Hough detect";
                btnHoughDetect.Enabled = true;
            }
        }

        private void txtBoxEraserSize_TextChanged(object sender, EventArgs e)
        {
            imageBoxColony.Focus();
        }

        private void rbBtnEraserManual_MouseClick(object sender, MouseEventArgs e)
        {
            imageBoxColony.Focus();
        }

        private void rbBtnEraserHough_MouseClick(object sender, MouseEventArgs e)
        {
            imageBoxColony.Focus();
        }

        private void rbDisplayOriginal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDisplayPreProcessing.Checked)
            {
                btnClear.PerformClick();
                imageBoxColony.Image = imageProcessingGray.Bitmap;
                groupBoxHough.Enabled = true;

                backgroundWorkerPreProcessing.RunWorkerAsync();
            }
            else
            {
                groupBoxHough.Enabled = false;
                imageBoxColony.Image = origImage;
                imageBoxColony.Invalidate();
                imageBoxColony.Focus();
            }
        }

        private void backgroundWorkerPreProcessing_DoWork(object sender, DoWorkEventArgs e)
        {
            imageProcessingWork = imageProcessingGray.Copy();

            if (checkBoxHistogramEqu.Checked)
            {
                imageProcessingWork._EqualizeHist();
            }

            if (checkBoxGamma.Checked)
            {
                imageProcessingWork._GammaCorrect(gamma);
            }

            imageProcessingWork._SmoothGaussian(_GaussKernel, _GaussKernel, _GaussSigma, _GaussSigma);

            if (checkBoxThreshold.Checked)
            {
                imageProcessingWork._ThresholdBinary(threshold, maxValueThreshold);
            }

            else if (checkBoxAdaptiveThresh.Checked)
            {
                if (adaptiveThreshType == 0)
                {
                    imageProcessingWork = imageProcessingWork.ThresholdAdaptive(
                        maxValueThreshold,
                        Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C,
                        Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY,
                        adaptiveThreshKernel,
                        adaptiveConstant); 
                }
                else
                {
                    imageProcessingWork = imageProcessingWork.ThresholdAdaptive(
                        maxValueThreshold,
                        Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C,
                        Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY,
                        adaptiveThreshKernel,
                        adaptiveConstant);
                }
            }

            if (checkBoxCanny.Checked)
            {
                imageProcessingWork = imageProcessingWork.Canny(thresholdCanny, threshLinking);
            }

            imageProcessingFinal = imageProcessingWork;
        }

        private void backgroundWorkerPreProcessing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imageBoxColony.Image = imageProcessingFinal.Bitmap;
            groupBoxHough.Enabled = true;
        }

        private void txtBoxGaussKernel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imageBoxColony.Focus();
            }
        }

        private void txtBoxGaussKernel_Leave(object sender, EventArgs e)
        {
            int.TryParse(txtBoxGaussKernel.Text, out _GaussKernel);
            if (_GaussKernel % 2 != 1)
            {
                MessageBox.Show("Error: Value for Gauss kernel is not correct. Please input an odd number.",
                                "Wrong input",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                txtBoxGaussKernel.Focus();
                return;
            }
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void txtBoxGaussSigma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imageBoxColony.Focus();
            }
        }

        private void txtBoxGaussSigma_Leave(object sender, EventArgs e)
        {
            double.TryParse(txtBoxGaussSigma.Text, out _GaussSigma);
            if (_GaussSigma < 0)
            {
                MessageBox.Show("Error: Value for Gauss sigma is not correct. Please input a nubmer greater than 0.",
                                "Wrong input",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                txtBoxGaussSigma.Focus();
                return;
            }
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void checkBoxThreshold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCollision)
            {
                checkBoxCollision = false;
                return;
            }

            if (checkBoxAdaptiveThresh.Checked)
            {
                checkBoxCollision = true;
                checkBoxAdaptiveThresh.Checked = false;
            }

            threshold = new Gray(trackBarThreshold.Value);
            lblThresholdTrackBar.Text = trackBarThreshold.Value.ToString();
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void trackBarThreshold_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxThreshold.Checked)
            {
                threshold = new Gray(trackBarThreshold.Value);
                groupBoxHough.Enabled = false;
                backgroundWorkerPreProcessing.RunWorkerAsync();
            }     
        }

        private void trackBarThreshold_ValueChanged(object sender, EventArgs e)
        {
            lblThresholdTrackBar.Text = trackBarThreshold.Value.ToString();
        }

        private void checkBoxAdaptiveThresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCollision)
            {
                checkBoxCollision = false;
                return;
            }

            if (checkBoxThreshold.Checked)
            {
                checkBoxCollision = true;
                checkBoxThreshold.Checked = false;
            }

            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void comboBoxAdaptiveThreshType_SelectedIndexChanged(object sender, EventArgs e)
        {
            adaptiveThreshType = comboBoxAdaptiveThreshType.SelectedIndex;
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void txtBoxAdaptiveThreshKernel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imageBoxColony.Focus();
            }
        }

        private void txtBoxAdaptiveThreshKernel_Leave(object sender, EventArgs e)
        {
            int.TryParse(txtBoxAdaptiveThreshKernel.Text, out adaptiveThreshKernel);
            if (adaptiveThreshKernel % 2 != 1)
            {
                MessageBox.Show("Error: Value for Adaptive threshold kernel is not correct. Please input an odd number.",
                                "Wrong input",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                txtBoxAdaptiveThreshKernel.Focus();
                return;
            }
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void txtBoxAdaptiveThreshConst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imageBoxColony.Focus();
            }
        }

        private void txtBoxAdaptiveThreshConst_Leave(object sender, EventArgs e)
        {
            int.TryParse(txtBoxAdaptiveThreshConst.Text, out adaptiveConstantInt);
            adaptiveConstant = new Gray(adaptiveConstantInt);
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void checkBoxCanny_CheckedChanged(object sender, EventArgs e)
        {
            thresholdCanny = (double)trackBarCanny.Value;
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void trackBarCanny_ValueChanged(object sender, EventArgs e)
        {
            lblCannyTrackBar.Text = trackBarCanny.Value.ToString();
        }

        private void trackBarCanny_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxCanny.Checked)
            {
                thresholdCanny = (double)trackBarCanny.Value;
                cannyThreshold = new Gray(thresholdCanny);
                groupBoxHough.Enabled = false;
                backgroundWorkerPreProcessing.RunWorkerAsync();
            }
        }

        private void txtBoxCannyLinkThresh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imageBoxColony.Focus();
            }
        }

        private void checkBoxHistogramEqu_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void trackBarGamma_ValueChanged(object sender, EventArgs e)
        {
            lblGamma.Text = ((double)trackBarGamma.Value / 100).ToString();
        }

        private void trackBarGamma_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxGamma.Checked)
            {
                gamma = (double)trackBarGamma.Value / 100;
                groupBoxHough.Enabled = false;
                backgroundWorkerPreProcessing.RunWorkerAsync();
            }
        }

        private void checkBoxGamma_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxHough.Enabled = false;
            backgroundWorkerPreProcessing.RunWorkerAsync();
        }

        private void dataGridViewFiles_SelectionChanged(object sender, EventArgs e)
        {
            imagePath = filesImages[dataGridViewFiles.CurrentRow.Index];
            origImage = Image.FromFile(imagePath);

            // Display the loaded image in the imageBox
            imageBoxColony.Image = origImage;
            imageBoxColony.ZoomToFit();
            imageBoxColony.Focus();

            //Bitmap imageProcessing = (Bitmap)origImage;
            imageProcessingGray = new Image<Gray, Byte>((Bitmap)origImage);
            rbDisplayOriginal.Enabled = true;
            rbDisplayPreProcessing.Enabled = true;
            rbDisplayOriginal.Checked = true;

            // Try loading ImageDetections class from XML that includes previos detection points, pen settings, etc.
            try
            {
                LoadDetectionsFromXML(imagePath.Split('.')[0]);
                // Set the colony to equal saved colony
                defaultColony = currentImageDetections.colonyList[0];
                _HoughCircleDetectionsColony = currentImageDetections.colonyList[1];
                imageBoxColony.Invalidate();

                lblTotalDetections.Text = currentImageDetections.globalCounter.ToString();
                lblManualDetections.Text = currentImageDetections.colonyList[0].localCounter.ToString();
                lblHoughDetections.Text = currentImageDetections.colonyList[1].localCounter.ToString();
            }
            // Ignore if there is no file
            catch (FileNotFoundException)
            {
                currentImageDetections.resetDetections();
                lblTotalDetections.Text = "0";
                lblManualDetections.Text = "0";
                lblHoughDetections.Text = "0";

                btnClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading from XML file:\n\n" + ex.Message.ToString());
            }
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            if (!stopwatchRunning)
            {
                btnStopwatch.Text = "Stop";
                stopwatchRunning = true;
                stopwatchManual.Reset();
                UpdateTimes();
                stopwatchManual.Start();
            }
            else
            {
                stopwatchManual.Stop();
                stopwatchRunning = false;
                btnStopwatch.Text = "Start";
                UpdateTimes();
            }
        }

    }
}

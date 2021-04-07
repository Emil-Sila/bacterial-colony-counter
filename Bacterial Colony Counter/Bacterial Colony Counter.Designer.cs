namespace Bacterial_Colony_Counter
{
    partial class BacterialColonyCounter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnSaveDetections = new System.Windows.Forms.Button();
            this.imageBoxColony = new Cyotek.Windows.Forms.ImageBox();
            this.btnHoughDetect = new System.Windows.Forms.Button();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCircleSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxHough = new System.Windows.Forms.GroupBox();
            this.lblGamma = new System.Windows.Forms.Label();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.checkBoxGamma = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBoxHistogramEqu = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxMaxRadius = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBoxGaussSigma = new System.Windows.Forms.TextBox();
            this.txtBoxMinRadius = new System.Windows.Forms.TextBox();
            this.txtBoxMinDist = new System.Windows.Forms.TextBox();
            this.txtBoxAccumulatorThreshold = new System.Windows.Forms.TextBox();
            this.txtBoxCannyThreshold = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAdaptiveThreshType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCannyTrackBar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAdaptiveThresh = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblThresholdTrackBar = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.checkBoxCanny = new System.Windows.Forms.CheckBox();
            this.txtBoxGaussKernel = new System.Windows.Forms.TextBox();
            this.txtBoxAdaptiveThreshConst = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxThreshold = new System.Windows.Forms.CheckBox();
            this.trackBarCanny = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBoxAdaptiveThreshKernel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDetections = new System.Windows.Forms.Label();
            this.lblHoughDetections = new System.Windows.Forms.Label();
            this.backgroundWorkerHoughDetection = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblManualDetections = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxEraserSize = new System.Windows.Forms.TextBox();
            this.rbBtnEraserHough = new System.Windows.Forms.RadioButton();
            this.rbBtnEraserManual = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.rbDisplayOriginal = new System.Windows.Forms.RadioButton();
            this.rbDisplayPreProcessing = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorkerPreProcessing = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXML = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblHoughTime = new System.Windows.Forms.Label();
            this.lblManualTime = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxHough.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCanny)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnClear.Location = new System.Drawing.Point(8, 127);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(249, 38);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.Gray;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnSaveImage.Location = new System.Drawing.Point(15, 840);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(264, 38);
            this.btnSaveImage.TabIndex = 5;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveDetections
            // 
            this.btnSaveDetections.BackColor = System.Drawing.Color.Gray;
            this.btnSaveDetections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetections.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnSaveDetections.Location = new System.Drawing.Point(15, 795);
            this.btnSaveDetections.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDetections.Name = "btnSaveDetections";
            this.btnSaveDetections.Size = new System.Drawing.Size(264, 38);
            this.btnSaveDetections.TabIndex = 11;
            this.btnSaveDetections.Text = "Save detections";
            this.btnSaveDetections.UseVisualStyleBackColor = false;
            this.btnSaveDetections.Click += new System.EventHandler(this.btnSaveDetections_Click);
            // 
            // imageBoxColony
            // 
            this.imageBoxColony.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxColony.BackColor = System.Drawing.Color.DimGray;
            this.imageBoxColony.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxColony.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageBoxColony.GridColor = System.Drawing.Color.DarkGray;
            this.imageBoxColony.GridColorAlternate = System.Drawing.Color.Silver;
            this.imageBoxColony.Location = new System.Drawing.Point(290, 46);
            this.imageBoxColony.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.imageBoxColony.Name = "imageBoxColony";
            this.imageBoxColony.PixelGridColor = System.Drawing.Color.Maroon;
            this.imageBoxColony.Size = new System.Drawing.Size(742, 970);
            this.imageBoxColony.TabIndex = 10;
            this.imageBoxColony.TextDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Image;
            this.imageBoxColony.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBoxColony_Paint);
            this.imageBoxColony.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBoxColony_MouseDown);
            this.imageBoxColony.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBoxColony_MouseMove);
            this.imageBoxColony.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxColony_MouseUp);
            // 
            // btnHoughDetect
            // 
            this.btnHoughDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoughDetect.BackColor = System.Drawing.Color.Gray;
            this.btnHoughDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoughDetect.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnHoughDetect.Location = new System.Drawing.Point(12, 890);
            this.btnHoughDetect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.btnHoughDetect.Name = "btnHoughDetect";
            this.btnHoughDetect.Size = new System.Drawing.Size(238, 38);
            this.btnHoughDetect.TabIndex = 12;
            this.btnHoughDetect.Text = "Start Hough detect";
            this.btnHoughDetect.UseVisualStyleBackColor = false;
            this.btnHoughDetect.Click += new System.EventHandler(this.btnHoughDetect_Click);
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.BackColor = System.Drawing.Color.Gray;
            this.btnLoadFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFolder.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnLoadFolder.Location = new System.Drawing.Point(15, 456);
            this.btnLoadFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(125, 38);
            this.btnLoadFolder.TabIndex = 1;
            this.btnLoadFolder.Text = "Open folder";
            this.btnLoadFolder.UseVisualStyleBackColor = false;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnColorPicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxCircleSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox1.Location = new System.Drawing.Point(15, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(264, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Manual detections  ";
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPicker.Location = new System.Drawing.Point(134, 66);
            this.btnColorPicker.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(119, 29);
            this.btnColorPicker.TabIndex = 3;
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Circle color:";
            // 
            // comboBoxCircleSize
            // 
            this.comboBoxCircleSize.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxCircleSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCircleSize.FormattingEnabled = true;
            this.comboBoxCircleSize.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "200"});
            this.comboBoxCircleSize.Location = new System.Drawing.Point(134, 28);
            this.comboBoxCircleSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCircleSize.Name = "comboBoxCircleSize";
            this.comboBoxCircleSize.Size = new System.Drawing.Size(118, 28);
            this.comboBoxCircleSize.TabIndex = 1;
            this.comboBoxCircleSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxCircleSize_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Circle size:";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // groupBoxHough
            // 
            this.groupBoxHough.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHough.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxHough.Controls.Add(this.checkBox1);
            this.groupBoxHough.Controls.Add(this.lblGamma);
            this.groupBoxHough.Controls.Add(this.trackBarGamma);
            this.groupBoxHough.Controls.Add(this.checkBoxGamma);
            this.groupBoxHough.Controls.Add(this.label25);
            this.groupBoxHough.Controls.Add(this.label21);
            this.groupBoxHough.Controls.Add(this.checkBoxHistogramEqu);
            this.groupBoxHough.Controls.Add(this.label16);
            this.groupBoxHough.Controls.Add(this.label15);
            this.groupBoxHough.Controls.Add(this.label14);
            this.groupBoxHough.Controls.Add(this.txtBoxMaxRadius);
            this.groupBoxHough.Controls.Add(this.label27);
            this.groupBoxHough.Controls.Add(this.txtBoxGaussSigma);
            this.groupBoxHough.Controls.Add(this.txtBoxMinRadius);
            this.groupBoxHough.Controls.Add(this.txtBoxMinDist);
            this.groupBoxHough.Controls.Add(this.txtBoxAccumulatorThreshold);
            this.groupBoxHough.Controls.Add(this.txtBoxCannyThreshold);
            this.groupBoxHough.Controls.Add(this.label26);
            this.groupBoxHough.Controls.Add(this.label10);
            this.groupBoxHough.Controls.Add(this.btnHoughDetect);
            this.groupBoxHough.Controls.Add(this.comboBoxAdaptiveThreshType);
            this.groupBoxHough.Controls.Add(this.label9);
            this.groupBoxHough.Controls.Add(this.label20);
            this.groupBoxHough.Controls.Add(this.label7);
            this.groupBoxHough.Controls.Add(this.lblCannyTrackBar);
            this.groupBoxHough.Controls.Add(this.label4);
            this.groupBoxHough.Controls.Add(this.label19);
            this.groupBoxHough.Controls.Add(this.label3);
            this.groupBoxHough.Controls.Add(this.checkBoxAdaptiveThresh);
            this.groupBoxHough.Controls.Add(this.label8);
            this.groupBoxHough.Controls.Add(this.label17);
            this.groupBoxHough.Controls.Add(this.label22);
            this.groupBoxHough.Controls.Add(this.lblThresholdTrackBar);
            this.groupBoxHough.Controls.Add(this.trackBarThreshold);
            this.groupBoxHough.Controls.Add(this.checkBoxCanny);
            this.groupBoxHough.Controls.Add(this.txtBoxGaussKernel);
            this.groupBoxHough.Controls.Add(this.txtBoxAdaptiveThreshConst);
            this.groupBoxHough.Controls.Add(this.label18);
            this.groupBoxHough.Controls.Add(this.checkBoxThreshold);
            this.groupBoxHough.Controls.Add(this.trackBarCanny);
            this.groupBoxHough.Controls.Add(this.label23);
            this.groupBoxHough.Controls.Add(this.txtBoxAdaptiveThreshKernel);
            this.groupBoxHough.Enabled = false;
            this.groupBoxHough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHough.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBoxHough.Location = new System.Drawing.Point(1044, 46);
            this.groupBoxHough.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxHough.Name = "groupBoxHough";
            this.groupBoxHough.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxHough.Size = new System.Drawing.Size(264, 970);
            this.groupBoxHough.TabIndex = 14;
            this.groupBoxHough.TabStop = false;
            this.groupBoxHough.Text = "  Hough detections  ";
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(204, 109);
            this.lblGamma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(18, 20);
            this.lblGamma.TabIndex = 43;
            this.lblGamma.Text = "1";
            this.lblGamma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.LargeChange = 100;
            this.trackBarGamma.Location = new System.Drawing.Point(12, 132);
            this.trackBarGamma.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarGamma.Maximum = 1500;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(232, 56);
            this.trackBarGamma.TabIndex = 42;
            this.trackBarGamma.Value = 100;
            this.trackBarGamma.ValueChanged += new System.EventHandler(this.trackBarGamma_ValueChanged);
            this.trackBarGamma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarGamma_MouseUp);
            // 
            // checkBoxGamma
            // 
            this.checkBoxGamma.AutoSize = true;
            this.checkBoxGamma.Location = new System.Drawing.Point(12, 100);
            this.checkBoxGamma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.checkBoxGamma.Name = "checkBoxGamma";
            this.checkBoxGamma.Size = new System.Drawing.Size(165, 24);
            this.checkBoxGamma.TabIndex = 41;
            this.checkBoxGamma.Text = "Gamma correction";
            this.checkBoxGamma.UseVisualStyleBackColor = true;
            this.checkBoxGamma.CheckedChanged += new System.EventHandler(this.checkBoxGamma_CheckedChanged);
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Font = new System.Drawing.Font("Cambria", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(6, 88);
            this.label25.Margin = new System.Windows.Forms.Padding(4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(250, 2);
            this.label25.TabIndex = 40;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Cambria", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(8, 196);
            this.label21.Margin = new System.Windows.Forms.Padding(4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(250, 2);
            this.label21.TabIndex = 39;
            // 
            // checkBoxHistogramEqu
            // 
            this.checkBoxHistogramEqu.AutoSize = true;
            this.checkBoxHistogramEqu.Location = new System.Drawing.Point(12, 55);
            this.checkBoxHistogramEqu.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.checkBoxHistogramEqu.Name = "checkBoxHistogramEqu";
            this.checkBoxHistogramEqu.Size = new System.Drawing.Size(200, 24);
            this.checkBoxHistogramEqu.TabIndex = 38;
            this.checkBoxHistogramEqu.Text = "Histogram equalization";
            this.checkBoxHistogramEqu.UseVisualStyleBackColor = true;
            this.checkBoxHistogramEqu.CheckedChanged += new System.EventHandler(this.checkBoxHistogramEqu_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 618);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(221, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Hough algorithm parameters:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Pre-Processing:";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Cambria", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(6, 606);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 2);
            this.label14.TabIndex = 13;
            // 
            // txtBoxMaxRadius
            // 
            this.txtBoxMaxRadius.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxMaxRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMaxRadius.Location = new System.Drawing.Point(192, 812);
            this.txtBoxMaxRadius.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMaxRadius.MaxLength = 4;
            this.txtBoxMaxRadius.Name = "txtBoxMaxRadius";
            this.txtBoxMaxRadius.Size = new System.Drawing.Size(58, 27);
            this.txtBoxMaxRadius.TabIndex = 10;
            this.txtBoxMaxRadius.Text = "200";
            this.txtBoxMaxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 208);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 20);
            this.label27.TabIndex = 37;
            this.label27.Text = "Gauss filter:";
            // 
            // txtBoxGaussSigma
            // 
            this.txtBoxGaussSigma.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxGaussSigma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGaussSigma.Location = new System.Drawing.Point(210, 235);
            this.txtBoxGaussSigma.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGaussSigma.MaxLength = 3;
            this.txtBoxGaussSigma.Name = "txtBoxGaussSigma";
            this.txtBoxGaussSigma.Size = new System.Drawing.Size(41, 27);
            this.txtBoxGaussSigma.TabIndex = 36;
            this.txtBoxGaussSigma.Text = "5";
            this.txtBoxGaussSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxGaussSigma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxGaussSigma_KeyDown);
            this.txtBoxGaussSigma.Leave += new System.EventHandler(this.txtBoxGaussSigma_Leave);
            // 
            // txtBoxMinRadius
            // 
            this.txtBoxMinRadius.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxMinRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMinRadius.Location = new System.Drawing.Point(192, 772);
            this.txtBoxMinRadius.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMinRadius.MaxLength = 4;
            this.txtBoxMinRadius.Name = "txtBoxMinRadius";
            this.txtBoxMinRadius.Size = new System.Drawing.Size(58, 27);
            this.txtBoxMinRadius.TabIndex = 9;
            this.txtBoxMinRadius.Text = "5";
            this.txtBoxMinRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMinDist
            // 
            this.txtBoxMinDist.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxMinDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMinDist.Location = new System.Drawing.Point(192, 732);
            this.txtBoxMinDist.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMinDist.MaxLength = 4;
            this.txtBoxMinDist.Name = "txtBoxMinDist";
            this.txtBoxMinDist.Size = new System.Drawing.Size(58, 27);
            this.txtBoxMinDist.TabIndex = 8;
            this.txtBoxMinDist.Text = "10";
            this.txtBoxMinDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxAccumulatorThreshold
            // 
            this.txtBoxAccumulatorThreshold.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxAccumulatorThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAccumulatorThreshold.Location = new System.Drawing.Point(192, 692);
            this.txtBoxAccumulatorThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAccumulatorThreshold.MaxLength = 3;
            this.txtBoxAccumulatorThreshold.Name = "txtBoxAccumulatorThreshold";
            this.txtBoxAccumulatorThreshold.Size = new System.Drawing.Size(58, 27);
            this.txtBoxAccumulatorThreshold.TabIndex = 7;
            this.txtBoxAccumulatorThreshold.Text = "30";
            this.txtBoxAccumulatorThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxCannyThreshold
            // 
            this.txtBoxCannyThreshold.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxCannyThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCannyThreshold.Location = new System.Drawing.Point(192, 652);
            this.txtBoxCannyThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCannyThreshold.MaxLength = 3;
            this.txtBoxCannyThreshold.Name = "txtBoxCannyThreshold";
            this.txtBoxCannyThreshold.Size = new System.Drawing.Size(58, 27);
            this.txtBoxCannyThreshold.TabIndex = 6;
            this.txtBoxCannyThreshold.Text = "80";
            this.txtBoxCannyThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(141, 238);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 20);
            this.label26.TabIndex = 35;
            this.label26.Text = "Sigma:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 816);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Maximal radius:";
            // 
            // comboBoxAdaptiveThreshType
            // 
            this.comboBoxAdaptiveThreshType.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxAdaptiveThreshType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdaptiveThreshType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAdaptiveThreshType.Items.AddRange(new object[] {
            "Mean",
            "Gaussian"});
            this.comboBoxAdaptiveThreshType.Location = new System.Drawing.Point(12, 425);
            this.comboBoxAdaptiveThreshType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAdaptiveThreshType.Name = "comboBoxAdaptiveThreshType";
            this.comboBoxAdaptiveThreshType.Size = new System.Drawing.Size(238, 28);
            this.comboBoxAdaptiveThreshType.TabIndex = 20;
            this.comboBoxAdaptiveThreshType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdaptiveThreshType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F);
            this.label9.Location = new System.Drawing.Point(9, 776);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Minimal radius:";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Cambria", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(6, 498);
            this.label20.Margin = new System.Windows.Forms.Padding(4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(250, 2);
            this.label20.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 736);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Minimum distance:";
            // 
            // lblCannyTrackBar
            // 
            this.lblCannyTrackBar.AutoSize = true;
            this.lblCannyTrackBar.Location = new System.Drawing.Point(204, 519);
            this.lblCannyTrackBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCannyTrackBar.Name = "lblCannyTrackBar";
            this.lblCannyTrackBar.Size = new System.Drawing.Size(36, 20);
            this.lblCannyTrackBar.TabIndex = 34;
            this.lblCannyTrackBar.Text = "127";
            this.lblCannyTrackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 696);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Acc. threshold:";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Cambria", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(6, 380);
            this.label19.Margin = new System.Windows.Forms.Padding(4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(250, 2);
            this.label19.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 656);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Canny threshold:";
            // 
            // checkBoxAdaptiveThresh
            // 
            this.checkBoxAdaptiveThresh.AutoSize = true;
            this.checkBoxAdaptiveThresh.Location = new System.Drawing.Point(12, 392);
            this.checkBoxAdaptiveThresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.checkBoxAdaptiveThresh.Name = "checkBoxAdaptiveThresh";
            this.checkBoxAdaptiveThresh.Size = new System.Drawing.Size(169, 24);
            this.checkBoxAdaptiveThresh.TabIndex = 19;
            this.checkBoxAdaptiveThresh.Text = "Adaptive threshold";
            this.checkBoxAdaptiveThresh.UseVisualStyleBackColor = true;
            this.checkBoxAdaptiveThresh.CheckedChanged += new System.EventHandler(this.checkBoxAdaptiveThresh_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 464);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Kernel:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 238);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 20);
            this.label22.TabIndex = 31;
            this.label22.Text = "Kernel:";
            // 
            // lblThresholdTrackBar
            // 
            this.lblThresholdTrackBar.AutoSize = true;
            this.lblThresholdTrackBar.Location = new System.Drawing.Point(204, 292);
            this.lblThresholdTrackBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThresholdTrackBar.Name = "lblThresholdTrackBar";
            this.lblThresholdTrackBar.Size = new System.Drawing.Size(36, 20);
            this.lblThresholdTrackBar.TabIndex = 32;
            this.lblThresholdTrackBar.Text = "127";
            this.lblThresholdTrackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(12, 316);
            this.trackBarThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(232, 56);
            this.trackBarThreshold.TabIndex = 17;
            this.trackBarThreshold.Value = 127;
            this.trackBarThreshold.ValueChanged += new System.EventHandler(this.trackBarThreshold_ValueChanged);
            this.trackBarThreshold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarThreshold_MouseUp);
            // 
            // checkBoxCanny
            // 
            this.checkBoxCanny.AutoSize = true;
            this.checkBoxCanny.Location = new System.Drawing.Point(12, 510);
            this.checkBoxCanny.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.checkBoxCanny.Name = "checkBoxCanny";
            this.checkBoxCanny.Size = new System.Drawing.Size(113, 24);
            this.checkBoxCanny.TabIndex = 27;
            this.checkBoxCanny.Text = "Canny edge";
            this.checkBoxCanny.UseVisualStyleBackColor = true;
            this.checkBoxCanny.CheckedChanged += new System.EventHandler(this.checkBoxCanny_CheckedChanged);
            // 
            // txtBoxGaussKernel
            // 
            this.txtBoxGaussKernel.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxGaussKernel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGaussKernel.Location = new System.Drawing.Point(82, 235);
            this.txtBoxGaussKernel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGaussKernel.MaxLength = 3;
            this.txtBoxGaussKernel.Name = "txtBoxGaussKernel";
            this.txtBoxGaussKernel.Size = new System.Drawing.Size(41, 27);
            this.txtBoxGaussKernel.TabIndex = 32;
            this.txtBoxGaussKernel.Text = "5";
            this.txtBoxGaussKernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxGaussKernel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxGaussKernel_KeyDown);
            this.txtBoxGaussKernel.Leave += new System.EventHandler(this.txtBoxGaussKernel_Leave);
            // 
            // txtBoxAdaptiveThreshConst
            // 
            this.txtBoxAdaptiveThreshConst.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxAdaptiveThreshConst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAdaptiveThreshConst.Location = new System.Drawing.Point(210, 461);
            this.txtBoxAdaptiveThreshConst.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAdaptiveThreshConst.MaxLength = 3;
            this.txtBoxAdaptiveThreshConst.Name = "txtBoxAdaptiveThreshConst";
            this.txtBoxAdaptiveThreshConst.Size = new System.Drawing.Size(41, 27);
            this.txtBoxAdaptiveThreshConst.TabIndex = 24;
            this.txtBoxAdaptiveThreshConst.Text = "1";
            this.txtBoxAdaptiveThreshConst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAdaptiveThreshConst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxAdaptiveThreshConst_KeyDown);
            this.txtBoxAdaptiveThreshConst.Leave += new System.EventHandler(this.txtBoxAdaptiveThreshConst_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(145, 464);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Const:";
            // 
            // checkBoxThreshold
            // 
            this.checkBoxThreshold.AutoSize = true;
            this.checkBoxThreshold.Location = new System.Drawing.Point(12, 284);
            this.checkBoxThreshold.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.checkBoxThreshold.Name = "checkBoxThreshold";
            this.checkBoxThreshold.Size = new System.Drawing.Size(104, 24);
            this.checkBoxThreshold.TabIndex = 18;
            this.checkBoxThreshold.Text = "Threshold";
            this.checkBoxThreshold.UseVisualStyleBackColor = true;
            this.checkBoxThreshold.CheckedChanged += new System.EventHandler(this.checkBoxThreshold_CheckedChanged);
            // 
            // trackBarCanny
            // 
            this.trackBarCanny.Location = new System.Drawing.Point(12, 542);
            this.trackBarCanny.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarCanny.Maximum = 255;
            this.trackBarCanny.Name = "trackBarCanny";
            this.trackBarCanny.Size = new System.Drawing.Size(232, 56);
            this.trackBarCanny.TabIndex = 28;
            this.trackBarCanny.Value = 127;
            this.trackBarCanny.ValueChanged += new System.EventHandler(this.trackBarCanny_ValueChanged);
            this.trackBarCanny.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarCanny_MouseUp);
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Font = new System.Drawing.Font("Cambria", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(8, 271);
            this.label23.Margin = new System.Windows.Forms.Padding(4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(250, 2);
            this.label23.TabIndex = 33;
            // 
            // txtBoxAdaptiveThreshKernel
            // 
            this.txtBoxAdaptiveThreshKernel.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxAdaptiveThreshKernel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAdaptiveThreshKernel.Location = new System.Drawing.Point(85, 461);
            this.txtBoxAdaptiveThreshKernel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAdaptiveThreshKernel.MaxLength = 3;
            this.txtBoxAdaptiveThreshKernel.Name = "txtBoxAdaptiveThreshKernel";
            this.txtBoxAdaptiveThreshKernel.Size = new System.Drawing.Size(41, 27);
            this.txtBoxAdaptiveThreshKernel.TabIndex = 22;
            this.txtBoxAdaptiveThreshKernel.Text = "15";
            this.txtBoxAdaptiveThreshKernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAdaptiveThreshKernel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxAdaptiveThreshKernel_KeyDown);
            this.txtBoxAdaptiveThreshKernel.Leave += new System.EventHandler(this.txtBoxAdaptiveThreshKernel_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F);
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hough Circle:";
            // 
            // lblTotalDetections
            // 
            this.lblTotalDetections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDetections.AutoSize = true;
            this.lblTotalDetections.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalDetections.Location = new System.Drawing.Point(141, 24);
            this.lblTotalDetections.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblTotalDetections.Name = "lblTotalDetections";
            this.lblTotalDetections.Size = new System.Drawing.Size(21, 22);
            this.lblTotalDetections.TabIndex = 17;
            this.lblTotalDetections.Text = "0";
            // 
            // lblHoughDetections
            // 
            this.lblHoughDetections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoughDetections.AutoSize = true;
            this.lblHoughDetections.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHoughDetections.Location = new System.Drawing.Point(141, 69);
            this.lblHoughDetections.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblHoughDetections.Name = "lblHoughDetections";
            this.lblHoughDetections.Size = new System.Drawing.Size(21, 22);
            this.lblHoughDetections.TabIndex = 18;
            this.lblHoughDetections.Text = "0";
            // 
            // backgroundWorkerHoughDetection
            // 
            this.backgroundWorkerHoughDetection.WorkerSupportsCancellation = true;
            this.backgroundWorkerHoughDetection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerHoughDetection_DoWork);
            this.backgroundWorkerHoughDetection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerHoughDetection_RunWorkerCompleted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblManualDetections);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblHoughDetections);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblTotalDetections);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox3.Location = new System.Drawing.Point(15, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(264, 102);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Detection count  ";
            // 
            // lblManualDetections
            // 
            this.lblManualDetections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManualDetections.AutoSize = true;
            this.lblManualDetections.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManualDetections.Location = new System.Drawing.Point(141, 46);
            this.lblManualDetections.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblManualDetections.Name = "lblManualDetections";
            this.lblManualDetections.Size = new System.Drawing.Size(21, 22);
            this.lblManualDetections.TabIndex = 20;
            this.lblManualDetections.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 10F);
            this.label12.Location = new System.Drawing.Point(10, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Manual:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.txtBoxEraserSize);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.rbBtnEraserHough);
            this.groupBox4.Controls.Add(this.rbBtnEraserManual);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox4.Location = new System.Drawing.Point(15, 275);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(264, 173);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "  Eraser  ";
            // 
            // txtBoxEraserSize
            // 
            this.txtBoxEraserSize.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxEraserSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEraserSize.Font = new System.Drawing.Font("Cambria", 10F);
            this.txtBoxEraserSize.Location = new System.Drawing.Point(134, 28);
            this.txtBoxEraserSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEraserSize.MaxLength = 4;
            this.txtBoxEraserSize.Name = "txtBoxEraserSize";
            this.txtBoxEraserSize.Size = new System.Drawing.Size(58, 27);
            this.txtBoxEraserSize.TabIndex = 7;
            this.txtBoxEraserSize.Text = "10";
            this.txtBoxEraserSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEraserSize.TextChanged += new System.EventHandler(this.txtBoxEraserSize_TextChanged);
            // 
            // rbBtnEraserHough
            // 
            this.rbBtnEraserHough.AutoSize = true;
            this.rbBtnEraserHough.Location = new System.Drawing.Point(14, 91);
            this.rbBtnEraserHough.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.rbBtnEraserHough.Name = "rbBtnEraserHough";
            this.rbBtnEraserHough.Size = new System.Drawing.Size(156, 24);
            this.rbBtnEraserHough.TabIndex = 2;
            this.rbBtnEraserHough.Text = "Hough detections";
            this.rbBtnEraserHough.UseVisualStyleBackColor = true;
            this.rbBtnEraserHough.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbBtnEraserHough_MouseClick);
            // 
            // rbBtnEraserManual
            // 
            this.rbBtnEraserManual.AutoSize = true;
            this.rbBtnEraserManual.Checked = true;
            this.rbBtnEraserManual.Location = new System.Drawing.Point(14, 64);
            this.rbBtnEraserManual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.rbBtnEraserManual.Name = "rbBtnEraserManual";
            this.rbBtnEraserManual.Size = new System.Drawing.Size(162, 24);
            this.rbBtnEraserManual.TabIndex = 1;
            this.rbBtnEraserManual.TabStop = true;
            this.rbBtnEraserManual.Text = "Manual detections";
            this.rbBtnEraserManual.UseVisualStyleBackColor = true;
            this.rbBtnEraserManual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbBtnEraserManual_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Size:";
            // 
            // rbDisplayOriginal
            // 
            this.rbDisplayOriginal.AutoSize = true;
            this.rbDisplayOriginal.Checked = true;
            this.rbDisplayOriginal.Enabled = false;
            this.rbDisplayOriginal.Font = new System.Drawing.Font("Cambria", 10F);
            this.rbDisplayOriginal.Location = new System.Drawing.Point(429, 15);
            this.rbDisplayOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.rbDisplayOriginal.Name = "rbDisplayOriginal";
            this.rbDisplayOriginal.Size = new System.Drawing.Size(135, 24);
            this.rbDisplayOriginal.TabIndex = 21;
            this.rbDisplayOriginal.TabStop = true;
            this.rbDisplayOriginal.Text = "Original image";
            this.rbDisplayOriginal.UseVisualStyleBackColor = true;
            this.rbDisplayOriginal.CheckedChanged += new System.EventHandler(this.rbDisplayOriginal_CheckedChanged);
            // 
            // rbDisplayPreProcessing
            // 
            this.rbDisplayPreProcessing.AutoSize = true;
            this.rbDisplayPreProcessing.Enabled = false;
            this.rbDisplayPreProcessing.Font = new System.Drawing.Font("Cambria", 10F);
            this.rbDisplayPreProcessing.Location = new System.Drawing.Point(580, 15);
            this.rbDisplayPreProcessing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.rbDisplayPreProcessing.Name = "rbDisplayPreProcessing";
            this.rbDisplayPreProcessing.Size = new System.Drawing.Size(185, 24);
            this.rbDisplayPreProcessing.TabIndex = 22;
            this.rbDisplayPreProcessing.Text = "Pre-processing image";
            this.rbDisplayPreProcessing.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10F);
            this.label11.Location = new System.Drawing.Point(286, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Diplaying image:";
            // 
            // backgroundWorkerPreProcessing
            // 
            this.backgroundWorkerPreProcessing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPreProcessing_DoWork);
            this.backgroundWorkerPreProcessing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPreProcessing_RunWorkerCompleted);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToResizeColumns = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colXML});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFiles.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFiles.EnableHeadersVisualStyles = false;
            this.dataGridViewFiles.Location = new System.Drawing.Point(8, 24);
            this.dataGridViewFiles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFiles.MultiSelect = false;
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.RowHeadersWidth = 24;
            this.dataGridViewFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFiles.ShowEditingIcon = false;
            this.dataGridViewFiles.Size = new System.Drawing.Size(249, 251);
            this.dataGridViewFiles.TabIndex = 24;
            this.dataGridViewFiles.SelectionChanged += new System.EventHandler(this.dataGridViewFiles_SelectionChanged);
            // 
            // colFileName
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gray;
            this.colFileName.DefaultCellStyle = dataGridViewCellStyle14;
            this.colFileName.HeaderText = "File name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colXML
            // 
            this.colXML.HeaderText = "Processed";
            this.colXML.Name = "colXML";
            this.colXML.ReadOnly = true;
            this.colXML.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colXML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colXML.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewFiles);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox2.Location = new System.Drawing.Point(15, 502);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(264, 285);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Files  ";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.Gray;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnLoadFile.Location = new System.Drawing.Point(154, 456);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(125, 38);
            this.btnLoadFile.TabIndex = 26;
            this.btnLoadFile.Text = "Open file";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.BackColor = System.Drawing.Color.Gray;
            this.btnStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopwatch.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnStopwatch.Location = new System.Drawing.Point(8, 28);
            this.btnStopwatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(61, 29);
            this.btnStopwatch.TabIndex = 4;
            this.btnStopwatch.Text = "Start";
            this.btnStopwatch.UseVisualStyleBackColor = false;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox5.Controls.Add(this.lblTotalTime);
            this.groupBox5.Controls.Add(this.lblHoughTime);
            this.groupBox5.Controls.Add(this.lblManualTime);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.btnStopwatch);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox5.Location = new System.Drawing.Point(15, 886);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(264, 130);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "  Timer  ";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(99, 72);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(54, 20);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "Total: ";
            // 
            // lblHoughTime
            // 
            this.lblHoughTime.AutoSize = true;
            this.lblHoughTime.Location = new System.Drawing.Point(89, 48);
            this.lblHoughTime.Margin = new System.Windows.Forms.Padding(4);
            this.lblHoughTime.Name = "lblHoughTime";
            this.lblHoughTime.Size = new System.Drawing.Size(64, 20);
            this.lblHoughTime.TabIndex = 7;
            this.lblHoughTime.Text = "Hough: ";
            // 
            // lblManualTime
            // 
            this.lblManualTime.AutoSize = true;
            this.lblManualTime.Location = new System.Drawing.Point(83, 24);
            this.lblManualTime.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.lblManualTime.Name = "lblManualTime";
            this.lblManualTime.Size = new System.Drawing.Size(70, 20);
            this.lblManualTime.TabIndex = 6;
            this.lblManualTime.Text = "Manual: ";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 25);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(0, 20);
            this.label43.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 936);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Enable ROI";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BacterialColonyCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1323, 1031);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rbDisplayPreProcessing);
            this.Controls.Add(this.rbDisplayOriginal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxHough);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveDetections);
            this.Controls.Add(this.imageBoxColony);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnLoadFolder);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BacterialColonyCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bacterial Colony Counter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxHough.ResumeLayout(false);
            this.groupBoxHough.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCanny)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveImage;
        private Cyotek.Windows.Forms.ImageBox imageBoxColony;
        private System.Windows.Forms.Button btnSaveDetections;
        private System.Windows.Forms.Button btnHoughDetect;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCircleSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBoxHough;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalDetections;
        private System.Windows.Forms.Label lblHoughDetections;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMaxRadius;
        private System.Windows.Forms.TextBox txtBoxMinRadius;
        private System.Windows.Forms.TextBox txtBoxMinDist;
        private System.Windows.Forms.TextBox txtBoxAccumulatorThreshold;
        private System.Windows.Forms.TextBox txtBoxCannyThreshold;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHoughDetection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblManualDetections;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxEraserSize;
        private System.Windows.Forms.RadioButton rbBtnEraserHough;
        private System.Windows.Forms.RadioButton rbBtnEraserManual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbDisplayOriginal;
        private System.Windows.Forms.RadioButton rbDisplayPreProcessing;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxThreshold;
        private System.Windows.Forms.CheckBox checkBoxAdaptiveThresh;
        private System.Windows.Forms.ComboBox comboBoxAdaptiveThreshType;
        private System.Windows.Forms.TrackBar trackBarCanny;
        private System.Windows.Forms.CheckBox checkBoxCanny;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxAdaptiveThreshConst;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxAdaptiveThreshKernel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBoxGaussKernel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCannyTrackBar;
        private System.Windows.Forms.Label lblThresholdTrackBar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBoxGaussSigma;
        private System.Windows.Forms.Label label26;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPreProcessing;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBoxHistogramEqu;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.CheckBox checkBoxGamma;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXML;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lblManualTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblHoughTime;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}


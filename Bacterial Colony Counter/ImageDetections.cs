using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Bacterial_Colony_Counter
{
    [System.Serializable]
    [XmlInclude(typeof(List<Colony>)), 
    XmlInclude(typeof(Colony))]
    public class ImageDetections
    {
        public int globalCounter { get; set; }
        public List<Colony> colonyList = new List<Colony>();

        //Add a parameterless constructor.
	    public ImageDetections() {}

        //Reset counters
        public void resetDetections()
        {
            globalCounter = 0;
            foreach (Colony colony in colonyList)
            {
                colony.localCounter = 0;
            }
        }
    }

    [System.Serializable]
    [XmlInclude(typeof(List<byte>)), 
    XmlInclude(typeof(List<CircleF>)), 
    XmlInclude(typeof(CircleF))]
    public class Colony
    {
        public string colonyName { get; set; }
        public int localCounter { get; set; }
        public int penWidth { get; set; }

        public List<byte> penColor = new List<byte>();
        public List<CircleF> markerLocationList = new List<CircleF>();

        //Add a parameterless constructor.
	    public Colony() {}
    }
}

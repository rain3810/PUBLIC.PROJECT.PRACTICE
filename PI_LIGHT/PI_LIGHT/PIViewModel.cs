using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PI_LIGHT
{
    public class PIViewModel
    {

        public string PI_NO { get; set; }
        //public string PI_STATUS { get; set; }

        public string LOC_CODE { get; set; }

        public string SEND_YN { get; set; }

        //public string PICK_NO { get; set; }

        public bool LAMPOn { get; set; }

        public string CNT { get; set; }

        //public SolidColorBrush PI_COLOR { get { return (PI_STATUS == "ON") ? Brushes.Red : Brushes.Black; } }


        public string DisplayValue { get { return string.Format("{0}({1})", PI_NO, LOC_CODE); } }

    }
}

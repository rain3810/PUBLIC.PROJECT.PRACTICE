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
        public string PI_STATUS { get; set; }

        public SolidColorBrush PI_COLOR { get { return (PI_STATUS == "ON") ? Brushes.Red : Brushes.Black; } }

        public override string ToString()
        {
            return string.Format("{0}({1})", PI_NO, PI_STATUS);
        }
    }
}

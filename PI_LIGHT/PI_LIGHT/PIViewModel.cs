using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PI_LIGHT
{
    public class PIViewModel : INotifyPropertyChanged
    {

        string pi_No;
        string loc_Code;
        string send_Yn;
        bool lampOn;
        string cnt;

        public string PI_NO { get => pi_No; set => pi_No = value; }

        //public string PI_STATUS { get; set; }

        public string LOC_CODE
        {
            get => loc_Code;
            set
            {
                loc_Code = value;
                changedProperty();
            }
        }

        public string SEND_YN
        {
            get => send_Yn;
            set { send_Yn = value; changedProperty(); }
        }

        public bool LAMPOn
        {
            get => lampOn;
            set { lampOn = value; changedProperty(); }
        }

        public string CNT
        {
            get => cnt;
            set { cnt = value; changedProperty(); }
        }

        //public SolidColorBrush PI_COLOR { get { return (PI_STATUS == "ON") ? Brushes.Red : Brushes.Black; } }


        public string DisplayValue { get { return string.Format("{0}({1})", PI_NO, LOC_CODE); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void changedProperty([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}

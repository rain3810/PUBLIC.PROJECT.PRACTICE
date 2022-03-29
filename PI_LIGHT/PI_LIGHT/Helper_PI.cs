using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_LIGHT
{
    public class PIList : ObservableCollection<PIViewModel>
    {
    }

    public class BCUInfo
    {
        private BCUInfo() { }
        public BCUInfo(string getPipeString, string getLogSeq)
        {
            this.LogSeq = getLogSeq;

            if (string.IsNullOrEmpty(getPipeString.Trim()))
                return;

            //PI | TYPE1 | 1 | P | 1 | F11 | 66 |      1
            string[] arrData = getPipeString.Split('|');

            this.LogMain = arrData[0]; //PI
            this.LogType = arrData[1]; //TYPE1
            this.BCU_ID = arrData[2]; //1 (BCU 1)
            this.CommandFlag = arrData[3]; //P
            this.PI_No = arrData[4]; //1 (PI 1)
            this.PI_PCMD = arrData[5]; //F11

            int lamp = 0;
            int.TryParse(arrData[6], out lamp);
            this.PI_LampAttribute = lamp;           //66
            this.Send_Data = arrData[7]; //
        }



        public string BCU_ID { get; set; }

        public string PI_No { get; set; }
        /// <summary>
        /// PI Command (F/V/S/A)
        /// </summary>

        public string PI_PCMD { get; set; }
        /// <summary>
        /// PI Room : Data Storage location number, 5 picking data in a PI
        /// </summary>

        public int PI_LampAttribute { get; set; }


        public string Send_Data { get; set; }

        public string CommandFlag { get; set; }

        public string LogType { get; set; }

        public string LogSeq { get; set; }

        public string LogMain { get; set; }


    }
}

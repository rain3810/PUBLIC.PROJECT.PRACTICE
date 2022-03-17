using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp22.ListboxBinding
{
    public class PI
    {
        public enum ZONEType
        {
            A,
            B,
            C
        }

        public enum STATUSType
        {
            ON,
            OFF,
        }

        string bcuNo;
        string pcNo;
        string piNo;
        string logCode;
        ZONEType zoneType;
        STATUSType statusType;

        public string BcuNo { get => bcuNo; set => bcuNo = value; }
        public string PcNo { get => pcNo; set => pcNo = value; }
        public string PiNo { get => piNo; set => piNo = value; }
        public string LogCode { get => logCode; set => logCode = value; }


        internal ZONEType ZoneType { get => zoneType; set => zoneType = value; }
        internal STATUSType StatusType { get => statusType; set => statusType = value; }


        public PI() { }

        public PI(string bcuNo, string pcNo, string piNo, string logCode, ZONEType zoneType, STATUSType statusType)
        {
            this.bcuNo = bcuNo;
            this.pcNo = pcNo;
            this.piNo = piNo;
            this.logCode = logCode;
            this.zoneType = zoneType;
            this.statusType = statusType;
        }


    }

    public class Pies : ObservableCollection<PI>
    {
        public Pies()
        {
            this.Add(new PI("3", "31", "1", "LOC001", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "2", "LOC002", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "3", "LOC003", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "4", "LOC004", PI.ZONEType.A, PI.STATUSType.OFF));
            this.Add(new PI("3", "31", "5", "LOC005", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "6", "LOC006", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "7", "LOC007", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "8", "LOC008", PI.ZONEType.A, PI.STATUSType.OFF));
            this.Add(new PI("3", "31", "9", "LOC009", PI.ZONEType.A, PI.STATUSType.ON));
            this.Add(new PI("3", "31", "10", "LOC010", PI.ZONEType.A, PI.STATUSType.ON));

            this.Add(new PI("3", "32", "1", "LOC001", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "2", "LOC002", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "3", "LOC003", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "4", "LOC004", PI.ZONEType.B, PI.STATUSType.OFF));
            this.Add(new PI("3", "32", "5", "LOC005", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "6", "LOC006", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "7", "LOC007", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "8", "LOC008", PI.ZONEType.B, PI.STATUSType.OFF));
            this.Add(new PI("3", "32", "9", "LOC009", PI.ZONEType.B, PI.STATUSType.ON));
            this.Add(new PI("3", "32", "10", "LOC010", PI.ZONEType.B, PI.STATUSType.ON));

            this.Add(new PI("3", "33", "1", "LOC001", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "2", "LOC002", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "3", "LOC003", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "4", "LOC004", PI.ZONEType.C, PI.STATUSType.OFF));
            this.Add(new PI("3", "33", "5", "LOC005", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "6", "LOC006", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "7", "LOC007", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "8", "LOC008", PI.ZONEType.C, PI.STATUSType.OFF));
            this.Add(new PI("3", "33", "9", "LOC009", PI.ZONEType.C, PI.STATUSType.ON));
            this.Add(new PI("3", "33", "10", "LOC010", PI.ZONEType.C, PI.STATUSType.ON));
        }
    }
}

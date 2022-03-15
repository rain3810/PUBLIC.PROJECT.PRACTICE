using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMSSQLTest3
{
    class PIViewModel
    {
        string bcu_no = string.Empty;
        string pc_no = string.Empty;
        string pi_no = string.Empty;
        string pick_no = string.Empty;
        string pi_log_data = string.Empty;
        string send_yn = string.Empty;
        string auto_yn = string.Empty;

        public string Bcu_no { get => bcu_no; set => bcu_no = value; }
        public string Pc_no { get => pc_no; set => pc_no = value; }
        public string Pi_no { get => pi_no; set => pi_no = value; }
        public string Pick_no { get => pick_no; set => pick_no = value; }
        public string Pi_log_data { get => pi_log_data; set => pi_log_data = value; }
        public string Send_yn { get => send_yn; set => send_yn = value; }
        public string Auto_yn { get => auto_yn; set => auto_yn = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SERVER_SAMPLE.Models
{
    public class SubmitOutbound
    {
        public string labelerId { get; set; }
        public string shipmentId { get; set; }
        public string invoiceNumebr { get; set; }
        public string toteBarcode { get; set; }
    }

}

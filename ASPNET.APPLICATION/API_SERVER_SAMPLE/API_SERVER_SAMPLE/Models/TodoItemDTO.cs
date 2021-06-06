using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SERVER_SAMPLE.Models
{
    public class TodoItemDTO
    {
        /// <summary>
        /// 고유키
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

    }
}

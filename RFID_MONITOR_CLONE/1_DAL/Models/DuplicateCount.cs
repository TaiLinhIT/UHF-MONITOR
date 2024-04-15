using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.Models
{
    public class DuplicateCount
    {
        public string? station { get; set; }
        public int? Count { get; set; }
        public string? mono { get; set; }
    }
}

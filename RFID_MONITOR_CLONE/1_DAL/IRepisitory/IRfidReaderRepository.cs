
using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.IRepisitory
{
    public interface IRfidReaderRepository
    {
        IEnumerable<DvRfidreader> GetDvRfidreaders(); 
    }
}

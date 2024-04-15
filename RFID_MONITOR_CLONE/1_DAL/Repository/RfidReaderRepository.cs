using RFID_MONITOR_CLONE._1_DAL.Models;
using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.Repository
{

    public class RfidReaderRepository : IRfidReaderRepository
    {
        private DvDataLakeContext _dbcontext;
       
        public RfidReaderRepository() {

            _dbcontext = new DvDataLakeContext();
        }

        public IEnumerable<DvRfidreader> GetDvRfidreaders()
        {
            return _dbcontext.DvRfidreaders.ToList();
        }
    }
}

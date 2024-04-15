using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.Repository
{
    public class EPCCountRepository : IEPCountRepository
    {
        private DvDataLakeContext _db;
        public EPCCountRepository()
        {
            _db = new DvDataLakeContext();
        }
        public IEnumerable<DvRfidrecordmst> GetRfidRecordMST()
        {
            return _db.DvRfidrecordmsts.ToList();
        }

        public IEnumerable<DvRfidrecordmstCust> GetRfidRecordMSTCust()
        {
            return _db.DvRfidrecordmstCusts.ToList();
        }
    }
}

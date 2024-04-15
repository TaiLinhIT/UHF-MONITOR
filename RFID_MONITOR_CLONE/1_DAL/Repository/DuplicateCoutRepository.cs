using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using RFID_MONITOR_CLONE._1_DAL.Models;

namespace RFID_MONITOR_CLONE._1_DAL.Repository
{

    public class DuplicateCoutRepository : IDuplicateCoutRepository
    {
        private DvDataLakeContext _db;
        public DuplicateCoutRepository()
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

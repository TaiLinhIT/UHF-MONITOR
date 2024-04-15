using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.Repository
{
    public class StationRepository : IStationRepository
    {
        DvDataLakeContext _db;
        public StationRepository()
        {
            _db = new DvDataLakeContext();
        }
        public IEnumerable<DvRfidreader> GetAll()
        {
            return _db.DvRfidreaders.ToList();
        }
    }
}

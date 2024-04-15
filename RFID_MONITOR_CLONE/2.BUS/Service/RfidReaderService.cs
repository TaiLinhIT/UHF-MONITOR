using RFID_MONITOR_CLONE._1_DAL;
using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using RFID_MONITOR_CLONE._1_DAL.Models;
using RFID_MONITOR_CLONE._1_DAL.Repository;
using RFID_MONITOR_CLONE._2.BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._2.BUS.Service
{
    public class RfidReaderService : IRfidReaderService
    {
        private IRfidReaderRepository _iRfidReaderRepository;
        public RfidReaderService()
        {
            _iRfidReaderRepository = new RfidReaderRepository();
        }

        public IEnumerable<DvRfidreader> GetRfidreaders()
        {
            return _iRfidReaderRepository.GetDvRfidreaders();
        }
    }
}

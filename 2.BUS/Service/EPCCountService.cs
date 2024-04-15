using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using RFID_MONITOR_CLONE._1_DAL.Models;
using RFID_MONITOR_CLONE._1_DAL.Repository;
using RFID_MONITOR_CLONE._2.BUS.IService;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._2.BUS.Service
{
    public class EPCCountService : IEPCCountService
    {
        IEPCountRepository _iEPCCountRepository;
        public EPCCountService()
        {
            _iEPCCountRepository = new EPCCountRepository();  
        }

        public List<CountEPC> GetEPCOfCusStationMonoOndate(string station, string mono)
        {
            List<CountEPC> lst = new List<CountEPC>();
            CountEPC countepc = new CountEPC();
            DateTime currentTime = DateTime.Now;
            int count = _iEPCCountRepository.GetRfidRecordMSTCust().Where(x => x.StationNo == station && x.MoNo == mono && x.RecordTime.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Date != x.Created.Date).Count();
            countepc.CountOnDay = count;
            lst.Add(countepc);
            return lst;
        }

        public List<CountEPC> GetEPCOfCusStationOndate(string station)
        {
            List<CountEPC> lst = new List<CountEPC>();

            CountEPC countepc = new CountEPC();
            DateTime currentTime = DateTime.Now;
            int count = _iEPCCountRepository.GetRfidRecordMSTCust().Where(x => x.StationNo == station && x.RecordTime.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Date != x.Created.Date).Count();
            countepc.CountOnDay = count;
            lst.Add(countepc);
            return lst;
        }

        public List<CountEPC> GetEPCStationMonoOndate(string station, string mono)
        {
            List<CountEPC> lst = new List<CountEPC>();
            CountEPC countepc = new CountEPC();
            DateTime currentTime = DateTime.Now;
            int count = _iEPCCountRepository.GetRfidRecordMST().Where(x => x.StationNo == station && x.MoNo == mono && x.RecordTime.Value.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Value.Date != x.Created.Date).Count();
            countepc.CountOnDay = count;
            lst.Add(countepc);
            return lst;
        }

        public List<CountEPC> GetEPCStationOndate(string station)
        {
            List<CountEPC> lst = new List<CountEPC>();
            CountEPC countepc = new CountEPC();
            DateTime currentTime = DateTime.Now;
            int count = _iEPCCountRepository.GetRfidRecordMST().Where(x => x.StationNo == station && x.RecordTime.Value.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Value.Date != x.Created.Date).Count();
            countepc.CountOnDay = count;
            lst.Add(countepc);
            return lst;
        }
    }
}

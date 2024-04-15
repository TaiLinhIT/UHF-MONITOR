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
    public class DuplicateCountService : IDuplicateCountService
    {
        IDuplicateCoutRepository _iDuplicateCoutRepository;
        public DuplicateCountService()
        {
            _iDuplicateCoutRepository = new DuplicateCoutRepository();
        }

        public List<DuplicateCount> GetDuplicateOfCusStationMonoOndate(string station, string mono)
        {
            List<DuplicateCount> lstdup = new List<DuplicateCount>();
            DuplicateCount dup = new DuplicateCount();
            DateTime currentTime = DateTime.Now;
            var lst = _iDuplicateCoutRepository.GetRfidRecordMSTCust().Where(x => x.StationNo == station && x.MoNo == mono && x.RecordTime.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Date != x.Created.Date)
                                                                      .GroupBy(x => new { x.MoNo, x.StationNo })
                                                                      .Select(y => new { counts = y.Count(), mono = y.Key.MoNo, station = y.Key.StationNo });
            foreach (var item in lst)
            {
                dup.Count = item.counts;
                dup.mono = item.mono;
                dup.station = item.station;
            }
            return lstdup;
        }

        public List<DuplicateCount> GetDuplicateOfCusStationOndate(string station)
        {
            List<DuplicateCount> lstdup = new List<DuplicateCount>();
            DuplicateCount dup = new DuplicateCount();
            DateTime currentTime = DateTime.Now;
            var lst = _iDuplicateCoutRepository.GetRfidRecordMSTCust().Where(x => x.StationNo == station  && x.RecordTime.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Date != x.Created.Date)
                                                                      .GroupBy(x => new { x.MoNo, x.StationNo })
                                                                      .Select(y => new { counts = y.Count(), mono = y.Key.MoNo, station = y.Key.StationNo });
            foreach (var item in lst)
            {
                dup.Count = item.counts;
                dup.mono = item.mono;
                dup.station = item.station;
            }
            return lstdup;
        }

        public List<DuplicateCount> GetDuplicateStationMonoOndate(string station, string mono)
        {
            List<DuplicateCount> lstdup = new List<DuplicateCount>();
            DuplicateCount dup = new DuplicateCount();
            DateTime currentTime = DateTime.Now;
            var lst = _iDuplicateCoutRepository.GetRfidRecordMST().Where(x => x.StationNo == station && x.MoNo == mono && x.RecordTime.Value.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Value.Date != x.Created.Date)
                                                                  .GroupBy(x => new { x.MoNo, x.StationNo })
                                                                  .Select(y => new { counts = y.Count(), mono = y.Key.MoNo, station = y.Key.StationNo });
            foreach (var item in lst)
            {
                dup.Count = item.counts;
                dup.mono = item.mono;
                dup.station = item.station;
            }
            return lstdup;
        }

        public List<DuplicateCount> GetDuplicateStationOndate(string station)
        {
            List<DuplicateCount> lstdup = new List<DuplicateCount>();
            DuplicateCount dup = new DuplicateCount();
            DateTime currentTime = DateTime.Now;
            var lst = _iDuplicateCoutRepository.GetRfidRecordMST().Where(x => x.StationNo == station && x.RecordTime.Value.ToString("dd-MM-yyyy") == currentTime.ToString("dd-MM-yyyy") && x.RecordTime.Value.Date != x.Created.Date)
                                                                      .GroupBy(x => new { x.MoNo, x.StationNo })
                                                                      .Select(y => new { counts = y.Count(), mono = y.Key.MoNo, station = y.Key.StationNo });
            foreach (var item in lst)
            {
                dup.Count = item.counts;
                dup.mono = item.mono;
                dup.station = item.station;
            }
            return lstdup;
        }
    }
}

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
    public class StationService : IStationService
    {
        IStationRepository _iStationRepository;
        public StationService()
        {
            _iStationRepository = new StationRepository();
        }
        public IEnumerable<Station> GetAll()
        {
            var lstStation = _iStationRepository.GetAll()
           .DistinctBy(x => new { x.DeviceName, x.SimplifiedChinese, x.Vietnamese, x.English, x.Khmer })
           .OrderBy(x => x.DeviceName) // Sắp xếp tăng dần theo DeviceName, bạn có thể chọn một trường khác nếu muốn
           .Select(x => new { x.DeviceName, x.SimplifiedChinese, x.Vietnamese, x.English, x.Khmer }).ToList();
            List<Station> _lstStation = new List<Station>();
            Station station;
            foreach (var item in lstStation)
            {
                station = new Station()
                {
                    DeviceName = item.DeviceName,
                    Simplified = item.SimplifiedChinese,
                    Vietnamese = item.Vietnamese,
                    English = item.English,
                    Khmer = item.Khmer
                };
                _lstStation.Add(station);
            }

                return _lstStation;
        }

        public IEnumerable<Station> GetByFactory(string factory)
        {
            var lstStation = _iStationRepository.GetAll()
            .DistinctBy(x => new { x.DeviceName, x.SimplifiedChinese, x.Vietnamese, x.English, x.Khmer }).Where(x => x.CofactoryCode == factory)
            .OrderBy(x => x.DeviceName) // Sắp xếp tăng dần theo DeviceName, bạn có thể chọn một trường khác nếu muốn
            .Select(x => new Station
            {
                DeviceName = x.DeviceName,
                Simplified = x.SimplifiedChinese,
                Vietnamese = x.Vietnamese,
                English = x.English,
                Khmer = x.Khmer
            })
            .ToList();

            return lstStation;
        }
    }
}

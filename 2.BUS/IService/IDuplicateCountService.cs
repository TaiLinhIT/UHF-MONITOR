using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._2.BUS.IService
{
    public interface IDuplicateCountService
    {
        List<DuplicateCount> GetDuplicateOfCusStationOndate(string station);
        List<DuplicateCount> GetDuplicateStationOndate(string station);
        List<DuplicateCount> GetDuplicateStationMonoOndate(string station, string mono);
        List<DuplicateCount> GetDuplicateOfCusStationMonoOndate(string station, string mono);
    }
}

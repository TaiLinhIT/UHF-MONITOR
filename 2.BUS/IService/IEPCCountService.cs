using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._2.BUS.IService
{
    public interface IEPCCountService
    {
        List<CountEPC> GetEPCOfCusStationOndate(string station);
        List<CountEPC> GetEPCStationOndate(string station);
        List<CountEPC> GetEPCStationMonoOndate(string station, string mono);
        List<CountEPC> GetEPCOfCusStationMonoOndate(string station, string mono);
    }
}

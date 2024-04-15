using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._2.BUS.IService
{
    public interface IFactoryService
    {
        IEnumerable<Factory> GetFactories();
        IEnumerable<Factory> GetAllFactoryByName(string name);
    }
}

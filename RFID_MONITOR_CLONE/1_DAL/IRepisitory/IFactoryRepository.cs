using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.IRepisitory
{
    public interface IFactoryRepository
    {
        IEnumerable<Factory> GetAllFactoryByName(string name); 
        IEnumerable<Factory> GetAllFactory(); 
    }
}

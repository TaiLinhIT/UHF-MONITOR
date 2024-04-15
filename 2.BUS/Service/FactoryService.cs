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
    public class FactoryService : IFactoryService
    {
        IFactoryRepository _ifactoryRepository;
        public FactoryService()
        {
            _ifactoryRepository = new FactoryRepository();
        }
        public IEnumerable<Factory> GetAllFactoryByName(string name)
        {
           return  _ifactoryRepository.GetAllFactoryByName(name);
        }

        public IEnumerable<Factory> GetFactories()
        {
            
            return _ifactoryRepository.GetAllFactory();
        }
        
    }
}   

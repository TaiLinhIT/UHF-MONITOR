using RFID_MONITOR_CLONE._1_DAL.IRepisitory;
using RFID_MONITOR_CLONE._1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MONITOR_CLONE._1_DAL.Repository
{
    public class FactoryRepository : IFactoryRepository
    {
        Factory _factory;
        List<Factory> _lstfactory;
        public FactoryRepository()
        {
                _factory = new Factory();
            _lstfactory = new List<Factory>();
        }
        public IEnumerable<Factory> GetAllFactory()
        {
            return _lstfactory.ToList();
        }

        public IEnumerable<Factory> GetAllFactoryByName(string name)
        {
            var findFactory = _lstfactory.Where(x => x.Equals(name));
            return findFactory.ToList();    
        }

    }
}

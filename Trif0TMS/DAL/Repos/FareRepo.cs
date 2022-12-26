using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FareRepo : ERepo, IRepo<Fare, int, Fare>
    {
        public Fare Add(Fare obj)
        {
            db.Fares.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fare> Get()
        {
            return db.Fares.ToList();
        }

        public Fare Get(int id)
        {
            throw new NotImplementedException();
        }

        public Fare Update(Fare obj)
        {
            throw new NotImplementedException();
        }
    }
}

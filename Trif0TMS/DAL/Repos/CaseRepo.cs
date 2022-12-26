using DAL.EF.Models;
using DAL.Interface;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CaseRepo : ERepo, IRepo<Case, int, Case>
    {
        public Case Add(Case obj)
        {
            db.Cases.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = db.Cases.Find(id);
            db.Cases.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Case> Get()
        {
            return db.Cases.ToList();
        }

        public Case Get(int id)
        {
            return db.Cases.Find(id);
        }

        public Case Update(Case obj)
        {
            var data = Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}

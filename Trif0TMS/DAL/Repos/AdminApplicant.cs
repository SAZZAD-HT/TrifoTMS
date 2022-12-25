using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminApplicantRepo : ERepo, IRepo<AdminApplicant, int, AdminApplicant>, AuthC<AdminApplicant, string>
    {
        public AdminApplicant Add(AdminApplicant obj)
        {
            db.AdminApplicants.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = db.AdminApplicants.Find(id);
            db.AdminApplicants.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<AdminApplicant> Get()
        {
            return db.AdminApplicants.ToList();
        }

        public AdminApplicant Get(int id)
        {
            return db.AdminApplicants.Find(id);
        }

        public AdminApplicant GetChecker(string id)
        {
            var obj = db.AdminApplicants.FirstOrDefault(x => x.ID.Equals(id));
            return obj;
        }

        public AdminApplicant Update(AdminApplicant obj)
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

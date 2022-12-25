using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : ERepo, IRepo<Admin, int, Admin>, IAuth<Admin, int>, AuthC<Admin, string>
    {
        public Admin Add(Admin obj)
        {
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Admin Authenticate(string email, string pass)
        {
            var obj = db.Admins.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(pass));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Admins.Find(id);
            db.Admins.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.Admins.Find(id);
        }

        public Admin GetChecker(string uname)
        {
            var obj = db.Admins.FirstOrDefault(x => x.Email.Equals(uname));
            return obj;
        }

        public Admin Update(Admin obj)
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

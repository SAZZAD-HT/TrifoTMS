using DAL.EF.Models;
using DAL.Interface;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PoliceRepo : ERepo, IRepo<Police, int, Police>, IAuth<Police, int>, AuthC<Police, string>  
    {
        public Police Add(Police obj)
        {
            db.Polices.Add(obj);
            if(db.SaveChanges()>0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {

            var data = db.Polices.Find(id);
            db.Polices.Remove(data);
            if(db.SaveChanges()>0)
            {
                return true;
            }
            return false;
        }

        public Police Authenticate(string uname, string password)
        {
            var obj = db.Polices.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(password));
            return obj;
        }

        public List<Police> Get()
        {
            return db.Polices.ToList();
        }

        public Police Get(int id)
        {
            var data= db.Polices.Find(id);
            return data;
        }

        public Police Update(Police obj)
        {
            var data= Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if(db.SaveChanges()>0)
            {
                return obj;
            }
            return null;
        }

        public Police GetChecker(string name)
        {

            var obj = db.Polices.FirstOrDefault(x => x.Name.Equals(name));
            return obj;
        }
    }
}

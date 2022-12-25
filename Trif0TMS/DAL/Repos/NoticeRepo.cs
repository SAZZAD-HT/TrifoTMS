using DAL.EF.Models;
using DAL.Interface;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class NoticeRepo : ERepo, IRepo<Notice, int, Notice>
    {
        public Notice Add(Notice obj)
        {
            db.Notices.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = db.Notices.Find(id);
            db.Notices.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Notice> Get()
        {
            return db.Notices.ToList();
        }

        public Notice Get(int id)
        {
            return db.Notices.Find(id);
        }

        public Notice Update(Notice obj)
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

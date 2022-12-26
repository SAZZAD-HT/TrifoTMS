using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TripRepo : ERepo, IRepo<Trip, int, Trip>
    {
        public Trip Add(Trip obj)
        {
            db.Trips.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Trips.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Trip> Get()
        {
            return db.Trips.ToList();
        }

        public Trip Get(int id)
        {
            return db.Trips.Find(id);
        }

        public Trip Update(Trip obj)
        {
            throw new NotImplementedException();
        }
    }
}

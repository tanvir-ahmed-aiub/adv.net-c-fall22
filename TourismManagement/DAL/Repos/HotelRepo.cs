using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HotelRepo : Repo, IRepo<Hotel, int, Hotel>
    {
        public Hotel Add(Hotel obj)
        {
            db.Hotels.Add(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Hotels.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Hotel> Get()
        {
            return db.Hotels.ToList();
        }

        public Hotel Get(int id)
        {
            return db.Hotels.Find(id);
        }

        public Hotel Update(Hotel obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RoomRepo : Repo,IRepo<Room,int,Room>
    {
        public Room Add(Room obj)
        {
            db.Rooms.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Rooms.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Room> Get()
        {
            return db.Rooms.ToList();
        }

        public Room Get(int id)
        {
            return db.Rooms.Find(id);
        }

        public Room Update(Room obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

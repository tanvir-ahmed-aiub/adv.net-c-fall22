using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GroupRepo : IRepo<Group, int, bool>
    {
        BloodDonateEntities db;
        internal GroupRepo() { 
            db = new BloodDonateEntities();
        }
        public bool Add(Group obj)
        {
            db.Groups.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(Group obj)
        {
            var dbojb = Get(obj.Id);
            db.Groups.Remove(dbojb);
            return db.SaveChanges() > 0;


        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public bool Update(Group obj)
        {
            var dbobj = Get(obj.Id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

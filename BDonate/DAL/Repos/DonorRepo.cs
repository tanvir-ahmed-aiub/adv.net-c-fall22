using DAL.EFCodeFirst;
using DAL.EFCodeFirst.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DonorRepo : IRepo<Donor, int, Donor>
    {
        BloodDonateEntities db;
        internal DonorRepo()
        {
            db = new BloodDonateEntities();
        }
        public Donor Add(Donor obj)
        {
            db.Donors.Add(obj);
            if (db.SaveChanges() > 0) {
                return obj;
            }
            return null;
        }

        public bool Delete(Donor id)
        {
            throw new NotImplementedException();
        }

        public List<Donor> Get()
        {
            return db.Donors.ToList();
        }

        public Donor Get(int id)
        {
            return db.Donors.Find(id);
        }

        public Donor Update(Donor obj)
        {
            var dbobbj = db.Donors.Find(obj.Id);
            db.Entry(dbobbj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

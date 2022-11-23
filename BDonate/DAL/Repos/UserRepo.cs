using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : IRepo<User, string, User>,IAuth
    {
        BloodDonateEntities db;
        internal UserRepo()
        {
            db = new BloodDonateEntities();
        }
        public User Add(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Authenticate(string uname, string pass)
        {
            var data = db.Users.FirstOrDefault(u => u.Username.Equals(uname) && u.Password.Equals(pass));
            if (data != null) return true;
            return false;   
        }

        public bool Delete(User id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
           return db.Users.ToList();    
        }

        public User Get(string id)
        {
           return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var dbobbj = db.Users.Find(obj.Username);
            db.Entry(dbobbj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

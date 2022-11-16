using BLL.DTOs;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static User GetUser(string uname) { 
            var dbuser = new UserRepo().Get(uname);
            if (dbuser != null) {
                var u = new User() {
                    Uname = dbuser.Uname,
                    Password = dbuser.Password,
                    Type = dbuser.Type,
                };
                return u;
            }
            return null;
        }
    }
}

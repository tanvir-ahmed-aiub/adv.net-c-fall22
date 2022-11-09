using Association.DB;
using Association.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Association.Repo
{
    public class AuthRepo
    {
        public static dynamic Login(LoginModel data) {
            var db = new UMSFall22_cEntities();

            
            var user = db.Users.FirstOrDefault(x => x.Username.Equals(data.Username) && x.Password.Equals(data.Password));
            if (user == null)
            {
                return false;
            }
            else {
                return new { Username = user.Username };
            }
        }
    }
}
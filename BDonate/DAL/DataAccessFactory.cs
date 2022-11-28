using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<DAL.EFCodeFirst.Models.Donor, int, DAL.EFCodeFirst.Models.Donor> DonorDataAccess() {
            return new DonorRepo();
        }
        public static IRepo<User, string, User> UserDataAccess() {
            return new UserRepo();
        }
        public static IRepo<Group, int, bool> GroupDataAccess() {
            return new GroupRepo();
        }
        public static IAuth AuthDataAccess() {
            return new UserRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess() {
            return new TokenRepo();
        }
    }
}

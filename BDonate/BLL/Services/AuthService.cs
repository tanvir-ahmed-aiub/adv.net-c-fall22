using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string uname, string pass) { 
            var rs = DataAccessFactory.AuthDataAccess().Authenticate(uname, pass);
            if (rs) {
                var tk = new Token();
                tk.Username = uname;
                tk.CreationTime = DateTime.Now;
                tk.ExpirationTime = null;
                tk.TKey = Guid.NewGuid().ToString();
                var rt = DataAccessFactory.TokenDataAccess().Add(tk);
                if (rt != null) {
                    var config = new MapperConfiguration(cfg => { 
                        cfg.CreateMap<Token,TokenDTO>();
                    });
                    var mapper = new Mapper(config);
                    var data = mapper.Map<TokenDTO>(rt);
                    return data;
                } 
            }
            return null;
        }

        public static bool IsTokenValid(string token) {
            var tk = DataAccessFactory.TokenDataAccess().Get(token);
            if(tk != null && tk.ExpirationTime == null)
            {
                return true;
            }
            return false;

        }
    }
}

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
    public class UserService
    {
        public static List<LoginDTO> Get()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, LoginDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<LoginDTO>>(data);
            return converted;
        }
        public static LoginDTO Get(string id)
        {
            var data = DataAccessFactory.UserDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, LoginDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<LoginDTO>(data);
            return converted;
        }
        public static LoginDTO Add(LoginDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LoginDTO, User>();
                cfg.CreateMap<User, LoginDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<User>(obj);
            var rs = DataAccessFactory.UserDataAccess().Add(converted);
            var rtrs = mapper.Map<LoginDTO>(rs);
            return rtrs;
        }
    }
}

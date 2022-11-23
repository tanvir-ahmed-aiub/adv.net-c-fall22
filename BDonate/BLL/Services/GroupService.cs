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
    public class GroupService
    {
        public static List<GroupDTO> Get() { 
            var data = DataAccessFactory.GroupDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, GroupDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<GroupDTO>>(data);
            return converted;
            
        }
        public static GroupDTO Get(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, GroupDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<GroupDTO>(data);
            return converted;
        }
        public static bool Add(GroupDTO grp) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<GroupDTO, Group>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Group>(grp);
            var rs = DataAccessFactory.GroupDataAccess().Add(converted);
            return rs;
        }
    }
}

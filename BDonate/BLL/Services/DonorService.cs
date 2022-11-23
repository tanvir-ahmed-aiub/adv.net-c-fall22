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
    public class DonorService
    {
        public static List<DonorDTO> Get() {
            var data = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<DonorDTO>>(data);
            return converted;
        }
        public static DonorDTO Get(int id) {
            var data = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<DonorDTO>(data);
            return converted;
        }
        public static DonorDTO Add(DonorDTO obj) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DonorDTO, Donor>();
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Donor>(obj);
            var rs = DataAccessFactory.DonorDataAccess().Add(converted);
            var rtrs = mapper.Map<DonorDTO>(rs);
            return rtrs;
        }
    }
}


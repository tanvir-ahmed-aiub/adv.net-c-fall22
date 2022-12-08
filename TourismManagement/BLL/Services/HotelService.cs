using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HotelService
    {
        public static List<HotelDTO> Get() {
            var data = DataAccessFactory.HotelDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Hotel, HotelDTO>();
                
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<HotelDTO>>(data);
        }
        public static HotelDTO Get(int id)
        {
            var data = DataAccessFactory.HotelDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Hotel, HotelDTO>();
                
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<HotelDTO>(data);
        }
        public static HotelDTO Add(HotelDTO hotel)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<HotelDTO, Hotel>();
                c.CreateMap<Hotel, HotelDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Hotel>(hotel);
            var data = DataAccessFactory.HotelDataAccess().Add(ht);
            
            if(data != null) return mapper.Map<HotelDTO>(data);
            return null;    
        }
        public static HotelRoomDTO GetwithRoom(int id) {
            var data = DataAccessFactory.HotelDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Hotel, HotelRoomDTO>();
                c.CreateMap<Room, RoomDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<HotelRoomDTO>(data);
        }
    }
}

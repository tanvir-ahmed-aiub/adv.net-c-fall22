using DAL.EF.Models;
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
        public static IRepo<Hotel, int, Hotel> HotelDataAccess() {
            return new HotelRepo();
        }
        public static IRepo<Room, int, Room> RoomDataAccess()
        {
            return new RoomRepo();
        }
    }
}

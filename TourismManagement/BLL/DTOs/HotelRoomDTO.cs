using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HotelRoomDTO : HotelDTO
    {
        public virtual List<RoomDTO> Rooms { get; set; }
        public HotelRoomDTO()
        {
            Rooms = new List<RoomDTO>();
        }
    }
}

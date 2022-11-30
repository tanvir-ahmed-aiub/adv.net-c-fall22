using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public double Rent { get; set; }
        public int HotelId { get; set; }
    }
}

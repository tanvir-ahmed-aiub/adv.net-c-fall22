using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Room> Rooms { get; set; }
        public Hotel() {
            Rooms = new List<Room>();
        }
    }
}

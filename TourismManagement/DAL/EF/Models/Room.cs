using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]  
        public string CategoryName { get; set; }
        [Required]
        public double Rent { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}

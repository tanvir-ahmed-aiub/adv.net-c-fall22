using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class TouristContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}

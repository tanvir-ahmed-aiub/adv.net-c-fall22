namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.TouristContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.TouristContext context)
        {
           
            List<Hotel> hotels = new List<Hotel>();
            for (int i = 1; i <= 10; i++) { 
                hotels.Add(new Hotel() { 
                    Id = i,
                    Name=Guid.NewGuid().ToString().Substring(0,20),
                    Address = Guid.NewGuid().ToString().Substring(0,5)
                });
            }
            context.Hotels.AddOrUpdate(hotels.ToArray());  
            
            List<Room> rooms = new List<Room>();
            string[] names = new string[] { "Regular",
                "Deluxe",
                "Super Deluxe",
                "Sea View",
                "Pent House",
                "Premium",
                "Premier Sea View",
                "Hill View",
                "City View",
                "Presidential Suite"
            };
            Random rand = new Random();
            for (int i = 1; i < 200; i++) {
                rooms.Add(new Room()
                {
                    Id = i,
                    CategoryName = names[rand.Next(0, 10)],
                    Rent = rand.Next(3000,10000),
                    HotelId = rand.Next(1,11),
                }); ;
            }
            context.Rooms.AddOrUpdate(rooms.ToArray()); 
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.EFCodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EFCodeFirst.BloodDonateEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EFCodeFirst.BloodDonateEntities context)
        {
            List<Group> groups = new List<Group>();
            for (int i = 1; i <= 6; i++) {
                groups.Add(new Group() { 
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0,3)
                });
            }
            context.Groups.AddOrUpdate(groups.ToArray());
            Random rand = new Random();
            List<Donor> donors = new List<Donor>();
            for (int i = 1; i <= 100; i++)
            {
                donors.Add(new Donor()
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 11),
                    GrpId = rand.Next(1, 7)

                }) ;
            }
            context.Donors.AddOrUpdate(donors.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

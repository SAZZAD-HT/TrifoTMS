namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.TMSEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.TMSEntities context)
        {
            List<Admin> admins = new List<Admin>();
            for (int i = 1; i <= 1; i++)
            {
                admins.Add(new Admin()
                {
                    ID = i,
                    Name = "rakinsadaftab",
                    Email = "xyz@gmail.com",
                    Password = "12345",
                    Phone = "0123455454",
                    Address = "Boali"
                });
            }
            context.Admins.AddOrUpdate(admins.ToArray());

            List<AdminApplicant> adminApplicants = new List<AdminApplicant>();
            for (int i = 1; i <= 6; i++)
            {
                adminApplicants.Add(new AdminApplicant()
                {
                    ID = i,
                    Firstname = Guid.NewGuid().ToString().Substring(0, 6),
                    Lastname = Guid.NewGuid().ToString().Substring(0, 3),
                    Username = Guid.NewGuid().ToString().Substring(0, 4),
                    Email = "xyz@gmail.com",
                    Password = Guid.NewGuid().ToString().Substring(0, 8),
                    Phone = "01XXXXXXXXX",
                    Address = Guid.NewGuid().ToString().Substring(0, 5)
                });
            }
            context.AdminApplicants.AddOrUpdate(adminApplicants.ToArray());

            List<Notice> notices = new List<Notice>();
            for (int i = 1; i <= 6; i++)
            {
                notices.Add(new Notice()
                {
                    ID = i,
                    Title = Guid.NewGuid().ToString().Substring(0, 6),
                    Description = Guid.NewGuid().ToString().Substring(0, 30),
                    PublishedDate = DateTime.Now,
                    LastDate = DateTime.MaxValue
                });
            }
            context.Notices.AddOrUpdate(notices.ToArray());

            Random rand = new Random();
            List<Fare> fares = new List<Fare>();
            for (int i = 1; i <= 6; i++)
            {
                fares.Add(new Fare()
                {
                    Route_Id = i,
                    Distance = rand.Next(1, 50),
                    Fare1 = rand.Next(10, 100)
                });
            }
            context.Fares.AddOrUpdate(fares.ToArray());

            List<Trip> trips = new List<Trip>();
            for (int i = 1; i <= 1; i++)
            {
                trips.Add(new Trip()
                {
                    session = i,
                    Start = "Kuril"
                });
            }
            context.Trips.AddOrUpdate(trips.ToArray());
        }
    }
}

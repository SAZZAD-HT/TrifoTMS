namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
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
        }
    }
}

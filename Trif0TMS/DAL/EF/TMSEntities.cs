using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class TMSEntities : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<AdminApplicant> AdminApplicants { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Police> Polices { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Fare> Fares { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}

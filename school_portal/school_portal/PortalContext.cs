using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace school_portal
{
    public class PortalContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Stusent { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Groupp> Groupp { get; set; }
    }
}
using Leapfrog.Web.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Leapfrog.Web.App.Context
{
    public class AppDbConnection : DbContext
    {
        public AppDbConnection()
            : base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set;}
        public DbSet<Teacher> Teachers { get; set; }
    }
}
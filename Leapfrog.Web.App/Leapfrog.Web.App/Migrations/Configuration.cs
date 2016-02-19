namespace Leapfrog.Web.App.Migrations
{
    using Leapfrog.Web.App.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Leapfrog.Web.App.Context.AppDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Leapfrog.Web.App.Context.AppDbConnection context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Teacher> tList = new List<Teacher>()
            {
                new Teacher(){
                FirstName="Dixanta",
                LastName="Shrestha",
                Email="dixanta@gmail.com",
                AddedDate=DateTime.Now,
                ModifiedDate=null,
                Status=true
                }
            };
            tList.ForEach(t =>
            {
                context.Teachers.Add(t);
                context.SaveChanges();
            });
        }
    }
}

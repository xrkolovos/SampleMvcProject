using WebApplication1.Logic;
using WebApplication1.Models.Db;

namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
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

            //var userGuid = "4c0218f7-0135-4c3e-a29c-c1d50770172f";

            //context.Articles.AddOrUpdate(
            //  p => p.Title,
            //  new Article { Title = "New Article", AuthorId = userGuid , DateTimeCreated = DateTimeOffset.Now}
            //);
        }
    }
}

using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication1.Models.Db;

namespace WebApplication1.Logic
{

    public class Dbc
    {
        public Dbc(string ConnectionStringName)
        {
            //ConnectionStringName
        }
        public Dbc(string ConnectionStringName, bool throwIfV1Schema)
        {
            //ConnectionStringName
        }

        
    }

    public class Mydbc : Dbc
    {
        public Mydbc() : base("DefaultConnection", throwIfV1Schema: true)
        {

        }
    }


    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base( nameOrConnectionString : "DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 

            //modelBuilder.Entity<ArticleUser>()
            //    .HasMany(a => a.Articles)
            //    .WithMany()
            //    .Map(x =>
            //    {
            //        x.MapLeftKey("Account_Id");
            //        x.MapRightKey("Product_Id");
            //        x.ToTable("AccountProducts");
            //    });
        }





        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleUser> ArticleUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
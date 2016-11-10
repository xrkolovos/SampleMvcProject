using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public IList<ArticleUser> ArticleUsers { get; set; }
    }

    public class ArticleUser
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string UserId { get; set; }

        [ForeignKey("ArticleId")]
        public Article Articles { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser Users { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        [MaxLength(800)]
        public string Fullname { get; set; }
        [MaxLength(500)]
        public string Addresss { get; set; }
        [MaxLength(200)]
        public string Hometown { get; set; }
        [MaxLength(200)]
        public string County { get; set; }


        public IList<ArticleUser> ArticleUsers { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
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
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeEfHier.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeEfHier
{

    ////Table per Hierarchy (TPH)
    ////https://weblogs.asp.net/manavi/inheritance-mapping-strategies-with-entity-framework-code-first-ctp5-part-1-table-per-hierarchy-tph
    //public class TphContext : DbContext
    //{
    //    public TphContext() : base(nameOrConnectionString: "SchoolContext")
    //    {
    //    }

    //    public DbSet<Person> Persons { get; set; }


    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        //Table per Hierarchy (TPH)
    //        modelBuilder.Entity<Person>()
    //                    .Map<Instructor>(m => m.Requires("PersonType").HasValue(nameof(Instructor)))
    //                    .Map<Student>(m => m.Requires("PersonType").HasValue(nameof(Student)));

    //        //modelBuilder.Entity<Person>()
    //        //            .Map<Instructor>(m => m.Requires("PersonType").HasValue(1))
    //        //            .Map<Student>(m => m.Requires("PersonType").HasValue(2));


    //    }
    //}


    ////Table per Type (TPt)
    ////https://weblogs.asp.net/manavi/inheritance-mapping-strategies-with-entity-framework-code-first-ctp5-part-2-table-per-type-tpt
    //public class TptContext : DbContext
    //{
    //    public TptContext() : base(nameOrConnectionString: "SchoolContext")
    //    {
    //    }

    //    public DbSet<Person> Persons { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        //Table per Type (TPt)
    //        modelBuilder.Entity<Instructor>().ToTable("Instructors");
    //        modelBuilder.Entity<Student>().ToTable("Students");
    //    }
    //}


    ////Table per Concrete Type (TPC)
    ////https://weblogs.asp.net/manavi/inheritance-mapping-strategies-with-entity-framework-code-first-ctp5-part-3-table-per-concrete-type-tpc-and-choosing-strategy-guidelines
    //public class TpcContext : DbContext
    //{
    //    public TpcContext() : base(nameOrConnectionString: "SchoolContext")
    //    {
    //    }

    //    public DbSet<Person> Persons { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        //Table per Concrete Type (TPC)
    //        modelBuilder.Entity<Instructor>().Map(m =>
    //        {
    //            m.MapInheritedProperties();
    //            m.ToTable("Instructors");
    //        });

    //        modelBuilder.Entity<Student>().Map(m =>
    //        {
    //            m.MapInheritedProperties();
    //            m.ToTable("Students");
    //        });

    //        modelBuilder.Entity<Person>()
    //                .Property(p => p.Id)
    //                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    //        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    //        //public int Id { get; set; }
    //    }
    //}

}

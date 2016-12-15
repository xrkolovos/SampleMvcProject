using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using CodeEfHier.Models;


namespace CodeEfHier.ManyToMany
{
    public class ManyToManyContext : DbContext
    {
        public ManyToManyContext() : base(nameOrConnectionString: "SchoolContext")
        {
        }

        public DbSet<Student2> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student2>()
            //    .HasMany(s => s.Courses)
            //    .WithMany(s => s.Students)
            //    .Map(m =>
            //    {
            //        m.ToTable("StudentCoursesTableAAA");
            //        m.MapLeftKey("StudentId");
            //        m.MapRightKey("CourseId");
            //    });
        }
    }

    public class Student2
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ημερομηνία Εγγραφής")]
        public DateTime EnrollmentDate { get; set; }

        //public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        //public virtual ICollection<Student2> Students { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }


    public class StudentCourse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeEfHier.Models;

namespace CodeEfHier
{
    class Program
    {
        static void Main(string[] args)
        {
            _TphContext();

        }

        private static void _TphContext()
        {
            //var tph = new TphContext();
            //IQueryable<Person> linqQuery = tph.Persons;
            //List<Person> persons = linqQuery.ToList();

            //var lstInstructors = tph.Persons.OfType<Instructor>().ToList();

            //IQueryable<Student> queryStudents = tph.Persons.OfType<Student>();


            ////save
            //Instructor instructor = new Instructor()
            //{
            //    FirstMidName = "Micahlis",
            //    LastName = "Papadakis",
            //    HireDate = DateTime.Today
            //};
            //Student student = new Student()
            //{
            //    FirstMidName = "Chrysostomos",
            //    LastName = "Kolovos",
            //    EnrollmentDate = DateTime.Today
            //};

            //tph.Persons.Add(instructor);
            //tph.Persons.Add(student);

            //tph.SaveChanges();
        }
    }
}

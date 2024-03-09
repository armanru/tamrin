using efloading.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efloading.EF
{
    internal class EFloading
    {
        private Appdbcontext _appdbcontext;
        public EFloading() 
        { 
            _appdbcontext = new Appdbcontext();
        }
        public void Seedstudent() 
        {
         List<Student> students = new List<Student>();
            new Student() { Name = "Arman", age = 18 };
            new Student() {  Name = "Ali", age = 28 };
            new Student() { Name="Zahra",age = 20};
            _appdbcontext.Students.AddRange(students);
            _appdbcontext.SaveChanges();
        }
        public void seedcourse()
        {
            List<course> courses = new List<course>();
            new course() { Name = "Data Struchur" };
        }
    }
}

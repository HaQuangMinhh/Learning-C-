using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentSystem
{
    public class Student
    {
        public String Name { get; set; }
        public String Id { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();  // Student.Courses

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public Student(string id, string name, List<Course> enrolledCourses)
        {
            Id = id;
            Name = name;
            Courses = enrolledCourses;
        }

        

    }
}

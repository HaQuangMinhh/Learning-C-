using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentSystem
{
    public class Course
    {
        public String CourseCode { get; set; }
        public String CourseName { get; set; }
        public int Credits { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Course(string courseCode, string courseName)
        {
            CourseCode = courseCode;
            CourseName = courseName;
        }

       
       


    }
}

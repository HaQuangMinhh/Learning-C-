using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace StudentEnrollmentSystem
{
    internal class Program
    {
        public static List<Course> Courses = new List<Course>()
        {
            new Course("CSE205", "Mang May Tinh"),
            new Course("CSE201", "Coding"),
            new Course("CSE204", "nhap mon lap trinh"),
            new Course("CSE206", "Computer Structure"),
        };
        public static List<Student> Students = new List<Student>() 
        { 
            new Student("1" , "Nguyen Manh Cuong"),
            new Student("2" , "Nguyen Anh"),
            new Student("3" , "Nguyen Ha"),
        };
        
        static void Main(string[] args)
        {
            // Build a system to manage student enrollment in courses
            var number = new List<int>();
            number.Add(1);


            var canContinue = true;
            while (canContinue) {
                Console.WriteLine("Student : ");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove all student by Student ID");
                Console.WriteLine("3. List all students with their details");
                Console.WriteLine("=======================================================");
                Console.WriteLine("Course : ");
                Console.WriteLine("4. Add a new Course");
                Console.WriteLine("5. Remove a course by Course Code");
                Console.WriteLine("6. List all courses with their details");
                Console.WriteLine("========================================================");
                Console.WriteLine("7. Enroll a course");
                Console.WriteLine("8. Withdraw a course");
                Console.WriteLine("========================================================");

                Console.WriteLine("9. Show students in a course");
                Console.WriteLine("10. Show courses from a student");

          
                Console.WriteLine("11. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        Console.WriteLine("=========================================================");
                        break;
                    case "3":
                        ShowAllSudents();
                        Console.WriteLine("=========================================================");
                        break;
                    
                    case "4":
                        AddCourse();
                        break;
                    case "5":
                        RemoveCourse();
                        break;
                    case "6":
                        ShowAllCourses();
                        break;
                    
                    case "7":
                        EnrollStudentInCourse();
                        break;
                    
                    case "8":
                        WithdrawStudentFromCourse();
                        break;
                    
                    case "9":
                        CalculateStudentInCourse();
                        break;

                    case "10":
                        CalculateCourseFromStudent();
                        break; 

                    case "11":
                        canContinue = false;
                        break;


                   
                    default:
                        Console.WriteLine("=========================================================");
                        Console.WriteLine("User input carefully");
                        break; 
                }
            }


        }

       
        // Hàm show ra all courses from a student --> input a student Id --> output all courses
        #region
        public static void CalculateCourseFromStudent() {

            // input student Id 
            Console.WriteLine("Input the Student Id");
            var studentId = Console.ReadLine();

            // Search Student 
            Student student = null;
            var studentFound = false;

            foreach (var find in Students ) {
                // tìm theo Id
                if ( find.Id == studentId ) {
                    student = find  ;  // store vào rỗng 
                    studentFound = true; 
                    break;
                }
            }
            // bắt sự kiện 
            if ( !studentFound ) { 
                Console.WriteLine( "=========================================Student not found");
            }

            // check student coi có course không 
            if ( student.Courses.Count == 0 ) { 
                Console.WriteLine("Don't have any course in a student");
            }

            // infor a student 
            Console.WriteLine($"Student: {student.Id}, Name: {student.Name} " );
            // Show all courses 
            Console.WriteLine($"Number of courses : {student.Courses.Count }");

            foreach (var s in student.Courses ) {
                Console.WriteLine($"Course: {s.CourseCode}, Name: {s.CourseName} "); 
            }
            Console.WriteLine("================================Show all students successful");

        }
        #endregion


        // Hàm show ra all students in a course --> input a couse --> output : all students 
        #region
        public static void CalculateStudentInCourse() {
 
            // User input 
            Console.WriteLine("Input the course code: ");
            var courseCode = Console.ReadLine();

            // Search Course 
            Course course = null; 
            var courseFound = false;

            foreach ( var find in Courses ) {
                if ( find.CourseCode == courseCode ) {
                    course = find;
                    courseFound = true;
                    break; 
                }
            }
            
            // nếu muốn bắt giá trị 
            if (!courseFound)
            {
                Console.WriteLine("======================================Course not found");
                return;
            }

            // check Course coi có sinh viên không 
            if ( course.Students.Count == 0 ) { 
                Console.WriteLine("==================Don't have any student in this course");
            }

            // Show số lượng sinh viên 
            Console.WriteLine( $"Course : {course.CourseCode}, {course.CourseName} " );
            Console.WriteLine( $"Number of students enrolled in a course: {course.Students.Count}");
            Console.WriteLine( $"Show all students successfully" );

            // show các tên ra lun 
            foreach ( var s in course.Students ) {
                Console.WriteLine( $"Id: {s.Id}, Name: {s.Name}"); 
            }

            Console.WriteLine("=============================================================");
        }
        #endregion

        // Hàm Withdraw Course by a student
        #region
        public static void WithdrawStudentFromCourse() {
            Console.WriteLine("Enter student Id to withdraw: ");
            var studentId = Console.ReadLine();

            Console.WriteLine("Enter Course Code to withdraw from: ");
            var courseCode = Console.ReadLine();    

            WithdrawCourse(studentId, courseCode);

        }

        public static void WithdrawCourse(string studentId, string courseCode) {

            // Search Student
            Student student = null; // Chứa rỗng null và store value 
            var studentFound = false;

            foreach (var s in Students)
            {
                if (s.Id == studentId)
                {
                    student = s;
                    studentFound = true;
                    break;
                }
            }

            // muốn bắt giá trị 
            if (!studentFound)
            {
                Console.WriteLine("==============================Student not found");
                return;
            }

            // Search Course 
            Course course = null; // Chứa rỗng null và store value 
            var courseFound = false;

            foreach (var c in Courses)
            {
                if (c.CourseCode == courseCode)
                {
                    course = c;
                    courseFound = true;
                    break;
                }
            }

            // muốn bắt giá trị 
            if (!courseFound)
            {
                Console.WriteLine("=======================Course not found");
                return;
            }

            // Check sinh viên có đang học course đó không 
            if ( !student.Courses.Contains(course) ) {
                Console.WriteLine("Student is not enrolled in this course");
                return; 
            }

            // Remove sinh viên 
            student.Courses.Remove(course);
            course.Students.Remove(student);
            
            Console.WriteLine("=====================================Widthdraw successful");
        }
        #endregion


        // Hàm Enroll Student in Course
        #region 
        // Hàm lấy thông tin từ user
        public static void EnrollStudentInCourse() {
            
            Console.WriteLine("Enter Student ID: ");
            var studentId = Console.ReadLine();

            Console.WriteLine("Enter Course Code ");
            var courseCode = Console.ReadLine();

            // truyền vào param
            CourseEnrollment(studentId, courseCode);
        }

        // Đăng kí sinh viên vào khoá học ( Register students into courses
        public static void CourseEnrollment(string studentId , string courseCode) {
            
            //======================================================= Search student
            Student student = null  ; // Chứa rỗng null và store value 
            var studentFound = false;  // not find  

            foreach ( var s in Students ) {
                if ( s.Id == studentId ) {
                    student = s ;
                    studentFound = true;
                    break;                 
                }
            }

            // muốn bắt giá trị 
            if ( studentFound == false  ) { 
                Console.WriteLine("==============================Student not found");
                return; 
            }

            //========================================================== search Course
            Course course = null ; // Chứa rỗng null và store value 
            var courseFound = false;

            foreach (var c in Courses ) { 
                if ( c.CourseCode == courseCode )  
                {
                    course = c;
                    courseFound = true;
                    break;
                }
            }

            //====================================================== muốn bắt giá trị 
            if ( !courseFound )
            {
                Console.WriteLine("=======================Course not found");
                return;
            }

            // Check bị Duplicated 
            var isDuplicated = false;
            foreach  ( var c in student.Courses  ) 
            {
                if ( c.CourseCode == courseCode ) { 
                    isDuplicated = true;
                    break;
                }
            }
            if (isDuplicated) {
                Console.WriteLine("========================This course has registed course");
                return; 
            }
            
            // Course and student - found 
                student.Courses.Add(course);   
                course.Students.Add(student);
    
            // function nhận vào all ID ==> show ra all môn học 
            // create case 

            // function các học sinh rút môn - nhận vào studentId, CourseCode 

            // function xem danh sách môn - nhập courseCode show ra danh sách sinh viên
            Console.WriteLine("=========================Enrollment successful"); 
        }
        #endregion


        // Hàm Student
        #region
        //====================================================== Student 
        public static void AddStudent()
        {
            Console.WriteLine("Student id : ");
            var id = Console.ReadLine();
            Console.WriteLine("Student name: ");
            var name = Console.ReadLine();

            Students.Add(new Student( id , name  ) );
            Console.WriteLine("Add students successfully");
            Console.WriteLine("=========================================================");
        }

        public static void RemoveStudent()
        {
            Console.WriteLine("You want to delete student: ");
            var studentId = Console.ReadLine();

            var remove = Students.RemoveAll( x => x.Id == studentId );

            if (remove > 0)
            {
                Console.WriteLine("You deleted successfully");
            }
            else { 
                Console.WriteLine("Don't have this student");
            }
        }

        public static void ShowAllSudents()
        {
            if (Students.Count > 0)
            {
                Console.WriteLine("All students below : ");
                foreach (var eachStudent in Students)
                {
                    Console.WriteLine($"Id : {eachStudent.Id} , Name: {eachStudent.Name} ");
                }
            }
            else { 
                Console.WriteLine("Don't have any student");
            }
        
        }
        #endregion 


        // Hàm Course
        #region
        //========================================================== Course 
        public static void AddCourse()
        {
            Console.WriteLine("Course Id is: ");
            var courseCode = Console.ReadLine();
            Console.WriteLine("Course Name is: ");
            var CourseName = Console.ReadLine();

            Courses.Add(new Course(courseCode, CourseName));
            Console.WriteLine("Add course successfully");
            Console.WriteLine("=========================================================");
        }

        public static void RemoveCourse()
        {
            Console.WriteLine("You want to delete course: ");
            var removeCourseCode = Console.ReadLine();

            var remove = Courses.RemoveAll(x => x.CourseCode == removeCourseCode);

            if (remove > 0)
            {
                Console.WriteLine("You deleted successfully");
            }
            else
            {
                Console.WriteLine("You should check students' number");
            }
            Console.WriteLine("=========================================================");
        }

        public static void ShowAllCourses()
        {
            if (Courses.Count > 0)
            {
                Console.WriteLine("All Courses below : ");
                foreach (var eachCourse in Courses)
                {
                    Console.WriteLine($"Course Code: {eachCourse.CourseCode}  Course Name: {eachCourse.CourseName}");
                }
            }
            else
            {
                Console.WriteLine("Don't have any course");
            }
            Console.WriteLine("=========================================================");
        }
        #endregion



    }
}

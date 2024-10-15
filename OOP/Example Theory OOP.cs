
namespace Example_Theory_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            Console.WriteLine(student.Name); 


            List<Student> students = new List<Student>();
            //create objects 
            for (int i = 0; i < 3; i++ ) {
                var eachStudent = new Student(Console.ReadLine() );
                students.Add(eachStudent);
            }


            // test truyền param 
            var anotherStudent = new Student("152222", "Minh" );
            Console.WriteLine($"{anotherStudent.Id} + {anotherStudent.Name}");

            Console.WriteLine("No friends");
            anotherStudent.GetFriends();


            // test truyền param có List
            var anotherStudent2 = new Student("5000", "Nhat", students );
            Console.WriteLine($"{anotherStudent2.Id} + {anotherStudent2.Name} " +
                $"{anotherStudent2.Friends} ");

            
            // test truyền param có List  
            var anotherStudent3 = new Student("4222", "Neighbourhood", students);
            Console.WriteLine($"{anotherStudent3.Id} + {anotherStudent3.Name} " +
                $"{anotherStudent3.Friends} ");

            


            // test truyền param có List , user input  ==> show ra những ng bạn
            var anotherStudent22 = new Student("3000" , "Holaaa" , students);
            Console.WriteLine($"{anotherStudent22.Id} + {anotherStudent22.Name} " +
                $"{anotherStudent22.Friends}");

            Console.WriteLine("Has friends");
            anotherStudent22.GetFriends();


            // create 2 biến, change the location param 
            anotherStudent.GetInformation("offday" , 16);
            anotherStudent.GetInformation(18, "going to school");

        }
    }

    public class Student { 
        
        public string Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public List<Student> Friends { get; set; } = new List<Student>(); // danh sách những ng bạn 


        // create Constructor 
        public Student() {      // rỗng 
        
        }

        // truyền param
        public Student(string id, string name) {
            Id = id;
            Name = name;
        }

        // test param có list
        public Student(string id, string name, List<Student> studentss) {
            Id = id; 
            Name = name;
            Friends = studentss ;   
        }

        // in ra tên của những ng bạn 
        public Student(string name)
        {
            Name = name;
        }

        // create 2 biến, change the location param 
        public string GetInformation(string content , int age ) { 
            Console.WriteLine("first content , second age");
            return ""; 
        }

        public string GetInformation(int age, string content) {
            Console.WriteLine("first age , next content");
            return "";
        }

        // show ra nhung ng ban 
        public void GetFriends() {
            foreach (Student eachStudent in Friends) {
                Console.WriteLine($"{eachStudent.Name}");  // can call age , id
            } 

        }
        





    }

}

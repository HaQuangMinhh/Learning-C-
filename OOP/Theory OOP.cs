using System.Diagnostics.Contracts;

namespace Theory_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test constructor (1)
            var animal = new Animal();
            Console.WriteLine(animal.Name);


            // test cái constructor nhận vào name và age 
            var dog = new Animal("dog", 25555);
            Console.WriteLine("=====================dog");
            dog.PrintFriendsInfor();


            var animals = new List<Animal>();
            animals.Add(dog);
            Console.WriteLine("Cat=================");

            var cat = new Animal("cat" , 3211 , animals );
            cat.PrintFriendsInfor();

            //Console.WriteLine($"{anotherAnimal.Name} - {anotherAnimal.Age}");
            //Console.Write(anotherAnimal.GetInformation("something"));

            anotherAnimal.GetInformation(23, "74");
            anotherAnimal.GetInformation("77" , 52);

            // ================================================
            var person = new Person("Minh", 325);
            Console.WriteLine(person.Name);

            var student = new Student("20111", "Duy", 56);
            Console.WriteLine($"{student.Name} + {student.StudentId} + {student.Age}");


        }


    }

    public class Animal
    { 
        // Attribute 
        // Access modifier 
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Animal> Friends { get; set; } = new List<Animal>(); 


        // create tool  --> constructor
        public Animal() {   // (1)
            
        }


        // Constructor
        // nhận vào name và age 
        public Animal(string name, int age, List<Animal> friends ) {
            Name = "My pet: "  + name;
            Age = age;
            Friends = friends;

        }

        public void PrintFriendsInfor()
        {
            foreach (var animal in Friends) { 
                Console.WriteLine($"{animal.Name}");
            }
        
        }

        public string GetInformation(string message, int age) { 
            Console.WriteLine("Method 2");
            return "";
        }

        public string GetInformation(  int age , string message)
        {
            Console.WriteLine("Method 1");
            return "";
        }


        // Customer to show ra
        public string GetInformation( string message )      // đây là 1 hàm 1 function 
        {
            return $"{Name} - {Age} - {message}"; 
        }
        public void DoSomething() { 
            var information = GetInformation("soeem"); // test 
        }


    
    }


    public class Person
    { 
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor
        public Person(string name)
        {
            Name = name;  
        }

        public void Run(int distance)
        {
            Console.WriteLine($"Run : {distance} km"); 
        }
    }

    // Con kế thừa cha ==> missions : 
    public class Student : Person
    { 
        public String StudentId { get; set; }
        public Student(string id, string name, int age ) : base(name, age)   // base là thằng cha 
        { 
            StudentId = id;
        }
    
    }

    // kế thừa : cha có gì con có đó 
}

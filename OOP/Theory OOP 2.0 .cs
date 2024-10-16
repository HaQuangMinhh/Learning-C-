using System.Security.Cryptography.X509Certificates;

namespace Theory_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Parent parent = new Parent("Tuan" , 15);
            Console.WriteLine($"name:  {parent.Name}  \nAge:  {parent.Age}");


            Console.WriteLine("============================================================");
           
            Child child = new Child (parent.Name , parent.Age , "Buy snack");
            Console.WriteLine($"name:  {child.Name}  \nAge:  {child.Age} \nShopping: {child.Shopping} ");
            
            Console.WriteLine("============================================================");

            // Use function -- Only write in class Parent -- Use void
            child.Jump(); 


            parent.Jump();
            Console.WriteLine("============================================================");
            // return lại 
            var show = Run(""); 
            Console.WriteLine();




        }
    }

    public class Parent
    { 
        public String Name { get; set; }
        public int Age { get; set; }

        public Parent(String name , int age) { 
            Name = name;
            Age = age;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Name + {Name} + Age + {Age}");
        }

        public virtual void Jump()
        { 
            Console.WriteLine("Jump quickly");
        }

        public String Run(string show)
        {
            return "Run quickly" ; 
        }
       
    }

    public class Child : Parent
    {
        public String Shopping { get; set; }

        public Child(String name, int age , String shopping) : base(name, age)
        {
            Shopping = shopping;
        }

        // use function 
        public override void Jump()
        {
            Console.WriteLine("Jump slowly");
        }


    }
}

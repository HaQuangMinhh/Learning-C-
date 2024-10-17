namespace Theory_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent("Tuan", 15);
            Console.WriteLine($"name:  {parent.Name}  \nAge:  {parent.Age}");


            Console.WriteLine("============================================================");

            Child child = new Child(parent.Name, parent.Age, "Buy snack");
            Console.WriteLine($"name:  {child.Name}  \nAge:  {child.Age} \nShopping: {child.Shopping} ");

            Console.WriteLine("============================================================");

            // Use function -- Only write in class Parent -- Use void
            child.Jump();


            parent.Jump();
            Console.WriteLine("============================================================");

            // return lại 
            var show = parent.Run();
            Console.WriteLine(show);

            Console.WriteLine("============================================================");

            // protected , public , private

            // private : private ở trong hàm class thì hàm main không gọi được 

            // Test protected   ==> // protected : gọi hàm protected từ class con
            child.ShowProtected();

            // Test private 
            parent.PublicPrivate();

            

        }
    }

    public class Parent
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public Parent(String name, int age)
        {
            Name = name;
            Age = age;
        }

    //================================================================================
        // protected 
        protected void showProtected() {
            Console.WriteLine("This is a protected method.");
        }

    // ===============================================================================
        private void showPrivate() {
            Console.WriteLine("This is a private method"); 
        }

        public void PublicPrivate() { 
            Console.WriteLine("Public the private method through the public method");
        }
    // ===============================================================================

        public void GetInformation()
        {
            Console.WriteLine($"Name + {Name} + Age + {Age}");
        }

        public virtual void Jump()
        {
            Console.WriteLine("Jump quickly");
        }

        // Đây là return
        public String Run()
        {
            return "Run quickly";
        }

    }

    public class Child : Parent
    {
        public String Shopping { get; set; }

        public Child(String name, int age, String shopping) : base(name, age)
        {
            Shopping = shopping;
        }

        // use function 
        public override void Jump()
        {
            Console.WriteLine("Jump slowly");
        }

        // Test protected from class con
        public void ShowProtected() { 
            showProtected();
        }


    }
}

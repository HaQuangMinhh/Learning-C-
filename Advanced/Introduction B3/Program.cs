using System.Globalization;

namespace Introduction_B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create Method 
            PrintMenu1(); // out ra ABC

            var message1 = "ABC";
            var anotherNumber = 123;
            bool exist = false;

            PrintMenu(message1, anotherNumber);

            // hàm void không trả dữ liệu gì cả

            // Hàm sau không trả về 
            var a = 10;
            var b = 20; 
            var sum = Sum(a, b);
            Console.WriteLine(sum);


            var message = BuildMessage("ABC", a); 
            Console.WriteLine(message);

            // Array and List
            var number = 10; 
            Count(number);

            var numbers = new List<int>() ;

            Console.WriteLine("before: " + numbers.Count);

            AddElement(numbers, number);    
            Console.WriteLine(numbers.Count);  // tham tri giong nhu nhân bản
             


        }

        // dynamic
        public static void PrintMenu1() {
            Console.WriteLine("ABC");
        }

        // dynamic -- > phụ thuoc vào user nhap
        public static void PrintMenu( string message , int number )
        { 
            Console.WriteLine( message );
            Console.WriteLine( number );
        }

        // muon trả về 
        public static int Sum(int a, int b)
        {
            var result = a + b; 
            return result;
        }

        public static string BuildMessage(string message, int number) {
            return $"{message} and {number}"; 
            
        }

        // Array and List
        public static void Count(int number) { 
            number = number + 10;
        
        }

        public static void AddElement(List<int> numbers ,int number ) {
            numbers.Add(number);
        }

        //public static void AddBook(List<Book> books, string name, string author)
        //{
           // var newBook = new Book(); 
           // Numbers.Add(newBook);
        //}


    }
}

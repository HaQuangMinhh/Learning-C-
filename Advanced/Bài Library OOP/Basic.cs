using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Managerment_System
{
    internal class Program
    {
        public static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            // Library Management System 
            
            var canContinue = true;

            // 1 Book management 
            while (canContinue)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1.   Add a book");
                Console.WriteLine("2.   Viewing books");
                Console.WriteLine("3.   Search books by Title");
                Console.WriteLine();
                Console.WriteLine("4.   Exit");
                Console.WriteLine("----------------------------------------");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You need to add a new book :");

                        Console.WriteLine("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter book author: ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter book year: ");
                        int year = int.Parse(Console.ReadLine());

                        AddBook(title, author, year);
                        break;
                    

                    case 2:
                        Console.WriteLine("--------List Book-------------");
                        foreach (var BookList in books) {
                            Console.WriteLine($"{BookList.Title}"); 
                        }
                        break; 
                        
                        //Console.WriteLine("Exit"); 
                        //canContinue = false;
                        //break; 
                }
            }
            
       
            //var bookQuantity = int.Parse(Console.ReadLine());
            

            //for (int i = 0; i < bookQuantity; i++) {
            //    var eachBook = new Book()
            //    {
            //        Title = Console.ReadLine(),
            //        Author = Console.ReadLine(),
            //        Year = int.Parse(Console.ReadLine())
            //    };  

            //    bookList.Add(eachBook);
            //}

            // Viewing books 
            

            


        }

        public static void AddBook(string title, string author, int year)
        {
            var eachBook = new Book(title, author, year);
            books.Add(eachBook);
            Console.WriteLine("Book added successfully");
        }


    }


    #region Class Book
    public class Book { 
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        // create constructor 
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
    #endregion

  
}

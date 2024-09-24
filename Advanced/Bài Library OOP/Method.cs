using System.Reflection.PortableExecutable;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Method
{
    internal class Program
    {
        public static Reader reader = new Reader();
        static void Main(string[] args)
        {

            var canContinue = true;
            List<Book> books = new List<Book>();

            while (canContinue)
            {
                // Choose option 
                DisplayMenu();  // show menu 

                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("----------Adding books-----------");

                        Console.WriteLine("Insert Book name: ");
                        var bookName = Console.ReadLine();
                        Console.WriteLine("Enter book author: ");
                        var bookAuthor = Console.ReadLine();
                        Console.WriteLine("Enter book year: ");
                        var bookYear = reader.NextInt();

                        // the first way to add book
                        AddBook(books, bookName, bookAuthor, bookYear);

                        // the second way :   AddBook(books);


                        break;
                    case 2:
                        Console.WriteLine("---------List books-----------");

                        ViewBook(books);

                        break;

                    case 3:
                        Console.WriteLine("------------Seaching books----------------");
                        Console.WriteLine("Insert the title to search: ");
                        var searchingTitle = Console.ReadLine();

                        // var findBooks = books.FindAll(b => b.Title.Equals(searchingTitle)); 

                        // Check và hiển thị KQ
                        SearchBooks(books, searchingTitle);

                        // i la ten cua tung element 
                        // var booksMatched = books.FindAll(i => i.Title.Contains(searchingTitle));
                        break;
                    case 4:
                        Console.WriteLine("-------------Exit-------------");
                        canContinue = false;
                        break;
                }
                Console.WriteLine("-------------------------------------------");
            }
            Console.WriteLine("DONE");

        }
        public static void SearchBooks(List<Book> books, string searchingTitle)
        {
            foreach (var resultTitle in books)
            {
                if (resultTitle.Title.Equals(searchingTitle)) // dùng contain 
                {
                    Console.WriteLine("found Book: ");
                    Console.WriteLine($"Title : {resultTitle.Title}");
                    Console.WriteLine($"Author : {resultTitle.Author}");
                    Console.WriteLine($"Year : {resultTitle.Year}");
                }
            }
        }

        public static void ViewBook(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}");
            }

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1.   Add a book");
            Console.WriteLine("2.   Viewing books");
            Console.WriteLine("3.   Search books by Title");
            Console.WriteLine();
            Console.WriteLine("4.   Exit");
            Console.WriteLine("----------------------------------------");
        }

        #region (The first way ) AddBook
        public static void AddBook(List<Book> books, string bookName, string bookAuthor, int bookYear)
        {
            var newBook = new Book()
            {
                Title = bookName,
                Author = bookAuthor,
                Year = bookYear
            };
            books.Add(newBook); // Add
            Console.WriteLine("Books added successfully");
        }
        #endregion

        // cách 2 của AddBook 
        #region AddBook ( The second way ) 
        //public static void AddBook(List<Book> books) {
        //    Console.WriteLine("Insert Book name: ");
        //    var bookName = Console.ReadLine();
        //    Console.WriteLine("Enter book author: ");
        //    var bookAuthor = Console.ReadLine();
        //    Console.WriteLine("Enter book year: ");
        //    var bookYear = reader.NextInt();

        //    var newBook = new Book()
        //    {
        //        Title = bookName,
        //        Author = bookAuthor,
        //        Year = bookYear
        //    };
        //    books.Add(newBook); // Add
        //    Console.WriteLine("Books added successfully");

        //}
        #endregion


    }

    #region Class Book
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

    }
    #endregion

    #region class Reader
    class Reader
    {
        private int index = 0;
        private string[] tokens;
        public string Next()
        {
            while (tokens == null || tokens.Length <= index)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                index = 0;
            }
            return tokens[index++];
        }
        public int NextInt()
        {
            return int.Parse(Next());
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }
    #endregion


}

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader(); 

            var canContinue = true ;
            List<Book> books = new List<Book>();

            while (canContinue)
            {
                // Choose option 
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
                        Console.WriteLine("----------Adding books-----------");

                        Console.WriteLine("Insert Book name: ");
                        var bookName = Console.ReadLine();
                        Console.WriteLine("Enter book author: ");
                        var bookAuthor = Console.ReadLine();
                        Console.WriteLine("Enter book year: ");
                        var bookYear = reader.NextInt(); 

                        var newBook = new Book()
                        {
                            Title = bookName,
                            Author = bookAuthor, 
                            Year = bookYear
                        };
                        books.Add(newBook); // Add
                        break;
                    case 2:
                        Console.WriteLine("---------List books-----------");
                        foreach (var book in books) { 
                            Console.WriteLine($"{book.Title}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("------------Seaching books----------------");
                        Console.WriteLine("Insert the title to search: ");
                        var searchingTitle = Console.ReadLine();

                        // var findBooks = books.FindAll(b => b.Title.Equals(searchingTitle)); 

                        // Check và hiển thị KQ
                        foreach ( var resultTitle in books ) {
                            if (resultTitle.Title.Equals(searchingTitle))
                            {
                                Console.WriteLine($"Title : {resultTitle.Title}");
                                Console.WriteLine($"Author : {resultTitle.Author}");
                                Console.WriteLine($"Year : {resultTitle.Year}");
                            }
                            

                        }

                        // i la ten cua tung element 
                        var booksMatched = books.FindAll(i => i.Title.Contains(searchingTitle)); 
                        
                        
                        
                        //if (searchingTitle != null)
                        //{
                        //    Console.WriteLine("Book found: ");
                        //    //foreach ( var showBook in findBooks ) {
                        //    //    Console.WriteLine($"Title : {showBook.Title}");
                        //    //    Console.WriteLine($"Author : {showBook.Author}");
                        //    //    Console.WriteLine($"Year : {showBook.Year}");
                        //    //}
                        //}
                        //else {
                        //    Console.WriteLine("Book not found"); 
                        //}

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
    }

    #region Class Book
    public class Book {
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

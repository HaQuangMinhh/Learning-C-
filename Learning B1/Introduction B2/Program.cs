namespace Introduction_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productQuantity = int.Parse(Console.ReadLine());
            
            var productList = new List<Product>(); // đây là cái vỏ

            for (int i = 0; i < productQuantity; i++) { 
                

                var product = new Product()
                {
                    Name = Console.ReadLine(),
                    Price = double.Parse(Console.ReadLine())
                };

                var newStudents = new Student()
                {
                    Id = "121",
                    name = "Minh",
                    Major = "Cit"
                }; 

                productList.Add(product);
            }

            double totalPrice = 0;
            for (int i = 0; i < productList.Count; i++) {

                Console.WriteLine($"index: {i}, name: {productList[i].Name}");

                Console.WriteLine($"price: {productList[i].Price}, name: {productList[i].Name}");
                totalPrice += productList[i].Price;
            }

            Console.WriteLine(totalPrice); 

        }
    }

    // class --> khuôn bánh
    // object -> banh 


    // learning class
    // name , price , string
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public double Rating { get; set; }
    }

    // attribute 
    public class Student { 
    
        public string Id { get; set; } 

        public string name { get; set; }

        public string Major { get; set; }
    }
}

namespace Exercise2_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shopping Cart 

            var userNum = int.Parse(Console.ReadLine());

            //   var itemsPrice = new List<double>();
            //   var nameItems = new List<string>();

            var productList = new List<Product>();  // cái vỏ
            double totalPrice = 0;

            // run each item 
            for (int i = 0; i < userNum; i++) {
                //    var itemName = Console.ReadLine();
                //    var price = double.Parse(Console.ReadLine());

                var product = new Product()
                {
                    Name = Console.ReadLine(),
                    Price = double.Parse(Console.ReadLine()),
                }; 

                // add price into List
            //    itemsPrice.Add(price);
            //    nameItems.Add(itemName);
                productList.Add(product);
                totalPrice += productList[i].Price;

                // Calculate total

            }
            
            for (int i = 0; i < productList.Count;i++) { 
                Console.WriteLine($"price: {productList[i].Price}, name: {productList[i].Name}");
                
            }

            Console.WriteLine();
            Console.WriteLine($"Total cost of each item is: {totalPrice}");


            // Apply Discount 
            double discount = 0.1;
            double totalDiscount = 0; 

            if (totalPrice > 100)
            {
                totalDiscount = totalPrice * discount; 
                Console.WriteLine($"You have discounted: {totalDiscount}");     
            }
            else {
                totalDiscount = totalPrice; 
                Console.WriteLine("Don't have discount");
            }

            Console.WriteLine();
            Console.WriteLine("total items in the cart : ");
            
            // Display the Items
            // used

            // total money needs to pay
            Console.WriteLine($"you need to pay: {totalPrice - totalDiscount} "); 


            




        }
    }

    public class Product
    { 
        public string Name { get; set; }

        public double Price { get; set; }   

    }
}

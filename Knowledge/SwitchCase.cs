using System.Text;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 

            Console.WriteLine("Chương trình tìm kiếm");
            Console.WriteLine("1. Tìm kiếm theo tên");
            Console.WriteLine("2. Tìm kiếm theo tác giả");
            Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
            Console.WriteLine("4. Tìm kiếm theo tiêu đề");


            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.WriteLine("1. Tìm theo tên");
                    break;
                case 2:
                    Console.WriteLine("2.Tìm theo tác giả");
                    break;
                
                default:
                    Console.WriteLine("Wrong input");
                    break;


            }
        }
    }
}

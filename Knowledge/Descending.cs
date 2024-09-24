using System.ComponentModel;

namespace Descending
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //           Given a positive integer N(0 ≤ N ≤ 1016).Write a program to check if all
            //digits in N are in descending order?
            //▪ Input: an integer N(0 ≤ N ≤ 1016)
            //▪ Output: Write YES if all digits in N are in descending, otherwise write NO

            // Lab 4 CSE 102
            var reader = new Reader();
            var Num = reader.NextLong();

            
            Boolean descending;
            descending = Giamdan(Num);

            if (descending)
            {
                System.Console.WriteLine("YES");
            }
            else {
                System.Console.WriteLine("NO");
            }

        }
        public static Boolean Giamdan (long Num) {
            long Chia = Num % 10;
            Num /= 10;

            while ( Num > 0 ) {
                if (Chia <= Num % 10)
                {
                    Chia = Num % 10;
                }
                else {
                    return false; 
                }
                Num /= 10; 
            
            }
            return true; 
        
        }

        
    }


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
}

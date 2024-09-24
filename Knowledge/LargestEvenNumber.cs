using System.ComponentModel.DataAnnotations;

namespace LargestEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader(); 

            var num = reader.NextLong();
            long a = 0, max = -1;

            while ( num > 0  ) {
                a = num % 10;
                num = num / 10;

                if ( a % 2 == 0 ) {
                    if (a > max) {
                        max = a; 
                    }
                }
            }
            Console.WriteLine(max); 


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

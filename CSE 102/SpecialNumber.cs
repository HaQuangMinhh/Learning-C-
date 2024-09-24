namespace Speical_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader(); 

            var n = reader.NextInt();
            var lastDigit = n % 10;

            var firstDigit = 0; // bien luu tru 
            var a = n; // bien luu tru dau tien 

            if (n < 100)
            {
                Console.WriteLine("Wrong input");
            }
            else {
                while (n > 0)
                {
                    if (n < 10)
                    {
                        firstDigit = n;
                        break;
                    }
                    n /= 10;
                }

                long answer = firstDigit * 10 + lastDigit;

                if (a % answer == 0) {
                    Console.WriteLine("YES"); 
                }
                else
                {
                    Console.WriteLine("NO"); 
                }
            }
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

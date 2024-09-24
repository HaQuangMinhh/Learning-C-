namespace PrimeCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prime Count 

            var reader = new Reader();

            var num1 = reader.NextInt(); 
            var num2 = reader.NextInt() ;

            var dem = 0;

            for (int i = num1; i <= num2; i++) {
                if (isPrime(i)) {
                    dem++; 
                }
            }
            Console.WriteLine(dem);
               
        }
        public static Boolean isPrime(long n) {
            if (n < 2) {
                return false; 
            }

            for (int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    return false; 
                }
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

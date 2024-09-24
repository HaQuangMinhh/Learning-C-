namespace Calculate_Sn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var reader = new Reader(); 

            var n = reader.NextInt();
            double result = 0;

            for (int i = 0; i <= n; i++) {
                var sum = i * ( i + 1) / 2;

                for (int j = 1; j <= i; j++) {
                    sum += j;
                }

                // tính tổng Sn 
                result += (double) 1 / sum; 
            }

            Console.WriteLine(result);

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

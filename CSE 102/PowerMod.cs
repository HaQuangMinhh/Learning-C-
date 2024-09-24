namespace Power_Mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();


            var x = reader.NextInt();
            var n = reader.NextInt();
            var k = reader.NextInt();

            var result = 0;
            for (int i = 0; i <= n; i++) {
                result = (x * n % k ) % k; 
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

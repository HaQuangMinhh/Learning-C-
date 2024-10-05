using System.Reflection.PortableExecutable;
using System.Text;

namespace EI20213Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder();

            var num = reader.NextInt();
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < num; i++)
            {
                var eachNum = reader.NextInt();

                if (numbers.ContainsKey(eachNum))
                {
                    numbers[eachNum]++;
                }
                else
                {
                    numbers[eachNum] = 1;
                }
            }

            // sort
            numbers = numbers.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var show in numbers)
            {
                sb.AppendLine(show.Key + " " + show.Value);
            }
            Console.WriteLine(sb);
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

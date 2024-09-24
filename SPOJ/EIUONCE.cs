using System.Text;

namespace EIUONCE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var reader = new Reader();
            var quantity = reader.NextInt();

            for (int t = 0; t < quantity; t++)
            {
                List<long> numbers = new List<long>();

                var numInput = reader.NextLong();
                var uniqueDic = new Dictionary<long , int>();

                for (int i = 0; i < numInput; i++)
                {
                    var eachNum = reader.NextLong();

                    if (!uniqueDic.ContainsKey(eachNum))
                    {                       
                        uniqueDic[eachNum] = 1;
                    }
                    else { 
                        uniqueDic[eachNum] = uniqueDic[eachNum] + 1 ;
                    }
                }
                
                foreach (var keyValue in uniqueDic) {
                    if (keyValue.Value == 1) { 
                        numbers.Add(keyValue.Key);
                    }
                }
                numbers = numbers.OrderBy(i => i).ToList();
                foreach (var eachNum in numbers)
                {
                    sb.Append(eachNum + " ");

                }
                sb.AppendLine();

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

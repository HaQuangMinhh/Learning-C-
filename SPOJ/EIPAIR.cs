using System.Text;

namespace EIPAIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder(); 

            var quantity = reader.NextInt();

            for (int i = 0; i < quantity; i++)
            {

                var numInput = reader.NextInt();
                // Count price has same price
                Dictionary<int, int> priceCount = new Dictionary<int, int>();

                // tổ hợp C(k,2) , 2 món quà 

                for (int t = 0; t < numInput; t++)
                {
                    var eachNum = reader.NextInt();

                    if (priceCount.ContainsKey(eachNum))
                    {
                        priceCount[eachNum]++;
                    }
                    else
                    {
                        priceCount[eachNum] = 1;
                    }
                } // --> group lại key - value


                // Tinh cap qua co cung gia 
                long pairCount = 0;
                foreach (var count in priceCount.Values) // lấy value ra đếm rồi + lại 
                {
                    if (count > 1)
                    {
                        pairCount += (long)count * (count - 1) / 2;
                    }
                }
                sb.AppendLine(pairCount.ToString()); // iu cau tham so kieu String
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

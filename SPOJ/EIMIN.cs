using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EIMIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder(); 

            var numInput = reader.NextInt(); 
            var k = reader.NextInt();

            List<int> numbers = new List<int>();

            for (int j = 0; j < numInput; j++)
            {
                var eachNum = reader.NextInt();
                numbers.Add(eachNum);
            }

            var minValue = 0;
            // lap lan k  
            for (int i = 0; i < k; i++) {

                // find the smallest value khac 0.
                minValue = numbers.Where(x => x > 0).DefaultIfEmpty(0).Min();
                

                // if = 0 
                if (minValue == 0)
                {
                    sb.AppendLine("0");
                }
                else
                {
                    sb.AppendLine(minValue.ToString() );

                    // find the smallest number 
                    for (int t = 0; t < numbers.Count; t++)
                    {
                        if ( numbers[t] > 0  ) { 
                            numbers[t]-= minValue ;
                        }
                    }
                }  
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

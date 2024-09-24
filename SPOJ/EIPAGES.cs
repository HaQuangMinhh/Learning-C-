using System.Text;

namespace EIPAGES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder();

            var numberPages = new List<int>(); // case 
            var numInput = reader.NextInt();
            
            for (int i = 0; i < numInput; i++) { 
                var eachNum = reader.NextInt();
                numberPages.Add(eachNum);
            }

            //sort 
            numberPages = numberPages.OrderBy(i => i).ToList();

            
            // core
            for (int i = 0; i < numberPages.Count ; i++ ) { 
                var start = numberPages[i] ;
                sb.Append(start);

                // loop to find chuoi lien tiep 
                var end = start;
                var count = 0;
                
                // important core 
                while ( i + 1 < numberPages.Count && numberPages[i + 1] - numberPages[i] == 1 ) {
                    end = numberPages[i + 1];
                    count++;
                    i++;
                }
                
                if (count >= 2) {
                    sb.Append("-").Append(end);
                } else if ( count == 1 ) {
                    sb.Append(" ").Append(end);
                }
                sb.Append(" ");
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

using System.Text;

namespace EICREDI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder(); 

            var quantity = reader.NextInt();
            
            for ( int i = 0; i < quantity; i++ ) {
                var name = reader.Next();
                sb.Append(name + " ");

                long count = 0;
                long avg = 0;

                var subjectQuantity = reader.NextInt();
                for (int t = 0; t < subjectQuantity; t++ ) { 
                    long eachScore = reader.NextLong();

                    if (eachScore >= 50 ) { 
                        avg += eachScore;
                        count++;
                        sb.Append(eachScore + " ");
                    }
                }

                if (count == 0)
                {
                    sb.Append(0 + "\n");
                }
                else {
                    sb.Append( avg / count + "\n" );
                }

            }
            Console.WriteLine( sb );


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

using System.Text;

namespace EIUPH011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder();

            var quantity = reader.NextInt(); 
            HashSet<int> numbers = new HashSet<int>();

            for ( int i = 0; i < quantity; i++ ) { 
                var eachNumber = reader.NextInt();  

                if ( !numbers.Contains(eachNumber) ) { 
                    numbers.Add(eachNumber);
                }
            }

            foreach ( var Ele in numbers) { 
                Console.Write(Ele + " ");
            } 
            
        }
    }

    #region Reader
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

    #endregion
}

using System.Text;

namespace EIULOVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder(); 

            var numMoney = reader.NextInt();
            var moneyPocket = reader.NextLong();

            Dictionary<int , long> saveMoney = new Dictionary<int , long>();
            
            long maxPrice = -1; 
            
            for (int i = 0; i < numMoney; i++) { 
                var eachMoney = reader.NextLong();

                if (eachMoney <= moneyPocket && eachMoney > maxPrice) { 
                    maxPrice = eachMoney;
                }
                
            }
            Console.WriteLine(maxPrice);

            // show cả dic ra
            //foreach ( KeyValuePair<int, int> show in saveMoney ) { 
            //    Console.WriteLine( show );
            //}
            
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

using System.Text;

namespace EIUGIFTS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var reader = new Reader();
            StringBuilder sb = new StringBuilder();

            var numMoney = reader.NextInt(); 
            long moneyPocket = reader.NextLong();

            List<long> numbers = new List<long>();
            
            for ( int i = 0; i < numMoney; i++ )  { 
                var eachMoney = reader.NextLong();
                numbers.Add( eachMoney );
            }

            // sort Ascending
            numbers = numbers.OrderBy(x => x).ToList();

            // two pointer 
            int left = 0;
            int right = numbers.Count - 1;
            
            long different = int.MaxValue;
            long totalPrice = int.MinValue;

            // core
            while (left < right)
            {
                long currentTotal = numbers[left] + numbers[right];
                long currentDifferent = numbers[right] - numbers[left];

                if ( currentTotal <= moneyPocket)
                {
                    if (currentTotal > totalPrice)
                    {
                        totalPrice = currentTotal;
                        different = currentDifferent;
                    }
                    else if ( currentTotal == totalPrice ) {
                        if (currentDifferent < different) { 
                            different = currentDifferent;
                        }
                    }
                    left++;
                }
                else {
                    right--; 
                }
            }

            if (totalPrice < 0 )
            {
                Console.WriteLine("-1 -1");
            }
            else {
                Console.WriteLine( totalPrice + " " + different);
            }
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

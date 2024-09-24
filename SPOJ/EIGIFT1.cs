namespace EIUGIFT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            
            var giftNum = reader.NextInt(); 
            var WraNum = reader.NextInt(); // paper

            // two Lists
            var giftSizes = new List<long>(giftNum);
            var papperSizes = new List<long>(WraNum);

            for (int i = 0; i < giftNum; i++) { 
                var currentGift = reader.NextLong();
                giftSizes.Add(currentGift);
            }
            
            for (int i = 0; i < WraNum; i++) { 
                var currentPapper = reader.NextLong();
                papperSizes.Add(currentPapper);
            }

            // Sort - Ascending order
            //giftSizes.Sort(); 
            //papperSizes.Sort();

            // cách sort new 
            giftSizes = giftSizes.OrderBy(i => i).ToList();
            papperSizes = papperSizes.OrderBy(i => i).ToList();

            var count = 0;
            for (int i = 0, j = 0; i < papperSizes.Count && j < giftSizes.Count; ) {
                var sizeGap = (double) papperSizes[i] / giftSizes[j] ;

                if (sizeGap >= 2 && sizeGap <= 3) {
                    count++;    // count increase 
                    i++;        // increase both gift and paper
                    j++; 

                } else if ( sizeGap < 2 ) { // is gift is bigger 
                    i++;   // increase papper

                } else  { // is gift is smaller  
                    j++; // increase gift
                }
            }

            Console.WriteLine(count); 
            
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

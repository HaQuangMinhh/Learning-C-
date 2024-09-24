namespace Easy_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numInput = int.Parse(Console.ReadLine());
            var eachNum = new List<int>();

            for (int i = 0; i < numInput; i++) { 
                var currentValue = int.Parse(Console.ReadLine());   
                eachNum.Add(currentValue);
            }

            var result = sortedSquares (eachNum);
            Console.WriteLine("Sorted Squares: ");
            for (int i = 0; i < result.Count ; i++) {
                Console.Write(result[i] + " ");
            }
        }

        public static List<int> sortedSquares (List<int> eachNum) 
        {
            int eachValue = eachNum.Count;  // lấy số lượng phần tử 
            
            var sortedResult = new List<int>(new int[eachValue]); 
            
            int left = 0 , right = eachValue - 1;
            var index = eachValue - 1; // variable follow position

            while (left <= right) {
                if (Math.Abs(eachNum[left]) > Math.Abs(eachNum[right]))
                {
                    sortedResult[index--] = eachNum[left] * eachNum[left];
                    left++ ;
                }
                else
                {
                     sortedResult[index--] = eachNum[right] * eachNum[right];
                    right-- ;
                }
            }
            return sortedResult;
        }
    }
}

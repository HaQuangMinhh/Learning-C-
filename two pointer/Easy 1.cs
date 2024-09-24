namespace Easy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Remove Duplicates from sorted List

            var inputNum = int.Parse(Console.ReadLine());
            List<int> eachNum = new List<int>();
            

            // user input
            for (int i = 0; i < inputNum ; i++) {
                var currentValue = int.Parse(Console.ReadLine());   
                eachNum.Add(currentValue);  
            }
            
            int newLength = removeDuplicates(eachNum);

            Console.WriteLine("New Length is: " + newLength);
            for (int i = 0; i < newLength; i++) {
                Console.Write(eachNum[i] + " ");
            }

     
        }

        public static int removeDuplicates(List<int> eachNum)
        {
            if (eachNum.Count == 0) return 0;
            int i = 0;

            for (int j = 1; j < eachNum.Count; j++)
            {
                if (eachNum[j] != eachNum[i])
                {
                    i++;
                    eachNum[i] = eachNum[j];
                }
            }
            return i + 1;
        }
    }
}

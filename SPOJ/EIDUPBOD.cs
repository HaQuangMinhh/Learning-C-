using System.Text;

namespace EIDUPBOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader(); 
            StringBuilder sb = new StringBuilder();

            var num = reader.NextInt(); 

            Dictionary<string , int> DateOfBirth = new Dictionary<string , int>();

            for (int i = 0; i < num; i++ ) { 
                var day = reader.NextInt();
                var month = reader.NextInt();
                var year = reader.NextInt();    

                var eachPerson = day.ToString("D2")+"/"+month.ToString("D2")+"/"+year;

                if (DateOfBirth.ContainsKey(eachPerson))
                {
                    DateOfBirth[eachPerson]++;
                }
                else {
                    DateOfBirth[eachPerson] = 1;
                }
            }


            // sort theo năm 
            DateOfBirth = DateOfBirth.OrderBy(x => DateTime.ParseExact(x.Key, "dd/MM/yyyy", null ))
                .ToDictionary(x => x.Key, x => x.Value);



            foreach (var show in DateOfBirth) { 
                sb.AppendLine( show.Key + " " + show.Value );
            }

            Console.WriteLine( sb.ToString() );
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

using System.Globalization;

namespace EIGRADU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            
            var students = new List<Student>();   // Object Student

            var numStudent = reader.NextInt();
            var numCredit = reader.NextInt();

            for ( int i = 0; i < numStudent; i++  ) { 
                string id = reader.Next();
                string name = reader.Next();

                int numCourse = reader.NextInt();
                List<long> grades = new List<long>();   // Object grades
                
                for ( int t = 0; t < numCourse; t++) {
                    long eachScore = reader.NextLong();
                    grades.Add( eachScore);
                }


                var student = new Student( id , name , grades ); // create a đối tượng
                
                // tín chỉ 
                if ( student.CreditsEarned >= numCredit ) {
                    students.Add(student); 
                }  
                
            }

             students = students.OrderByDescending(s => s.AvgGPA).ThenBy(s => s.Id)
            .ToList();

            foreach (var show in students) { 
                Console.WriteLine( show );
            }
        }
    }






    #region
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

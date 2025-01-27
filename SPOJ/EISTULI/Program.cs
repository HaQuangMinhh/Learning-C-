namespace EISTULI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rd = new Reader(); 

            var numStu = rd.NextInt();
            var k = rd.NextInt();

            List<Student> students = new List<Student>();   

            for ( int i = 0; i < numStu; i++ ) { 
                long id = rd.NextInt() ;    
                var name = rd.Next() ;
                var course = rd.NextInt() ;

                List<double> scores = new List<double>();

                for ( int t = 0; t < course; t++ ) { 
                    scores.Add( rd.NextDouble() );
                }

                var student = new Student( id , name , scores );
                student.CalculateGPAAndCredits();

                students.Add( student );
            }

            students = students.OrderByDescending(s => s.GPA)
                               .ThenBy(s => students.IndexOf(s) ).ToList();


            var topStudents = students.Take(k).ToList();

            foreach ( var student in topStudents ) { 
                Console.WriteLine( $"{student.Id} {student.Name} {Math.Round(student.GPA)} {student.Credits}" );
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

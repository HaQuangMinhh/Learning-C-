using System.Text;

namespace EIUSLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            StringBuilder sb = new StringBuilder();

            var quantity = reader.NextInt();

            List<Student> students = new List<Student>();

            for ( int i = 0; i < quantity ; i++ ) {
                var name = reader.Next();
                
                long totalScore = 0; 

                var subjectQuantity = reader.NextInt();
                for (int t = 0; t < subjectQuantity; t++ ) { 
                    long eachScore = reader.NextLong();
                    totalScore += eachScore;
                }

                double avgScore = (double) totalScore / subjectQuantity;
                
                students.Add(new Student(name, avgScore)); // add to the students
            }

            students = students.OrderByDescending(x => x.AvgScore).Take(2).ToList();

            foreach ( var student in students ) { 
                Console.WriteLine(student.Name);
            }

        }

        public class Student {
            public String Name { get; set; }
            public double AvgScore { get; set; }

            public Student(string name, double avgScore) {
                Name = name; 
                AvgScore = avgScore;
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

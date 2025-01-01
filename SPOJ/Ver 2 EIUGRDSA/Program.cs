namespace EIUGRDSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader(); 

            var numStudent = reader.NextInt();
            var numProblem = reader.NextInt();
            var numSubmission = reader.NextInt();

            // Danh sách sinh viên và bài tập 
            
            List<int> studentIds = new List<int>();
            List<int> exerciseCodes = new List<int>();

            // Tạo danh sách sinh viên 
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            // Đọc danh sách studentsIds 
            for ( int i = 0; i < numStudent; i++ ) { 
                int studentId = reader.NextInt();
                studentIds.Add(studentId);

                students[studentId] = new Student(studentId);
            }

            // Đọc danh sách exerciseCodes 
            for ( int i = 0; i < numProblem; i++ ) { 
                exerciseCodes.Add(reader.NextInt());
            }

            // Xử lý submissions 
            for ( int i = 0; i < numSubmission; i++ ) { 
                int studentId = reader.NextInt();
                int problemId = reader.NextInt();

                double score = reader.NextDouble();

                if ( students.ContainsKey(studentId) ) {
                    students[studentId].UpdateScore(problemId, score); 
                }
            }


            // Tính và in điểm Avg 
            var orderByStudentIds = studentIds.OrderBy(id => id);

            foreach ( var studentId in orderByStudentIds ) {
                double average = students[studentId].CalculateAvg(numProblem);
                Console.WriteLine( $"{studentId} {average}" ); 
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

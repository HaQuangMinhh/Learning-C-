namespace EIUGRDSA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();  

            int numStudent = reader.NextInt();  
            int numProblem = reader.NextInt();
            int numSubmission = reader.NextInt();

            // Danh sách mã số sinh viên và bài tập hợp lệ 
            HashSet<int> studentIds = new HashSet<int>();
            HashSet<int> exerciseCodes = new HashSet<int>();

            // Đọc NumStudent and NumProblem 
            for ( int i = 0; i < numStudent; i++  ) { 
                studentIds.Add(reader.NextInt());
            }

            for ( int i = 0; i < numProblem; i++  ) { 
                exerciseCodes.Add(reader.NextInt());
            }

            // Lưu thông tin sinh viên 
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            foreach ( var id in studentIds )
            {
                students[id] = new Student(id);
            }

            // Xử lý submissions 
            for ( int i = 0; i < numSubmission; i++  ) { 
                var studentId = reader.NextInt();
                var problemId = reader.NextInt();
                
                double score = reader.NextDouble();

                if (studentIds.Contains(studentId) && exerciseCodes.Contains(problemId) )
                {
                    students[studentId].UpdateScore(problemId, score);
                    students[studentId].SubmissionCount++;  
                }
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

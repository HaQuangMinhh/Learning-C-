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
            for (int i = 0; i < numStudent; i++)
            {
                studentIds.Add(reader.NextInt());
            }

            for (int i = 0; i < numProblem; i++)
            {
                exerciseCodes.Add(reader.NextInt());
            }

            // Lưu thông tin sinh viên 
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            foreach (var id in studentIds)
            {
                students[id] = new Student(id);
            }

            // Xử lý submissions 
            for (int i = 0; i < numSubmission; i++)
            {
                var studentId = reader.NextInt();
                var problemId = reader.NextInt();

                double score = reader.NextDouble();

                if (exerciseCodes.Contains(problemId))
                {
                    var student = students[studentId];

                    if (!student.HighestScore.ContainsKey(problemId) || student.HighestScore[problemId] < score)
                    {
                        student.HighestScore[problemId] = score;
                    }

                    student.SubmissionCount++;
                }
            }

            // Calculate 
            List<Student> studentList = students.Values.ToList();

            // Sort
            studentList.Sort((s1, s2) =>
            {
                int compare = s2.CalculateAvg().CompareTo(s1.CalculateAvg()); // Sort by average score descending
                if (compare == 0)
                {
                    compare = s1.SubmissionCount.CompareTo(s2.SubmissionCount); // Then by submission count ascending
                    if (compare == 0)
                    {
                        compare = s1.Id.CompareTo(s2.Id); // Then by student ID ascending
                    }
                }
                return compare;
            });

            // Output results
            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.Id} {student.CalculateAvg} {student.SubmissionCount}");
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

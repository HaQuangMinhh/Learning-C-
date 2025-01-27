using System.Text;

namespace EISCHSH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rd = new Reader(); 

            var numStu = rd.NextInt();
            var k = rd.NextInt();

            List<Student> students = new List<Student>();

            for ( int i = 0; i < numStu; i++) { 
                var id = rd.NextLong();
                var name = rd.Next(); 
                var course = rd.NextInt();

                List<double> scores = new List<double>();

                for ( int t = 0; t < course; t++  ) { 
                    scores.Add(rd.NextDouble());    
                }

                // Create object 
                students.Add( new Student(id,name,scores ) );

            }

            // Sort danh sách sinh viên 
            students = students.OrderByDescending( s => s.CalculateGPA(s.Scores))
                .ThenBy(s => s.Id).ToList();

            // Rank 

            int rank = 1;
            int temp = 0; // số sinh viên đồng hạng
            StringBuilder sb = new StringBuilder();

            // xử lý danh sách top K sinh viên 
            for ( int i = 0; i < k; i++ ) {

                // Nếu GPA hiện tại khác GPA trước đó, cập nhật rank
                if (i > 0 && students[i].CalculateGPA(students[i].Scores) != students[i - 1].CalculateGPA(students[i - 1].Scores))
                {
                    rank += temp; // Tăng rank dựa trên số lượng sinh viên đồng hạng
                    temp = 0; // Đặt lại temp
                }

                // Ghi thông tin sinh viên vào kết quả
                sb.AppendLine($"{rank} {students[i].Id} {students[i].Name} {Math.Round(students[i].CalculateGPA(students[i].Scores))}");
                temp++; // Tăng số lượng sinh viên đồng hạng

            }

            // Xử lý các sinh viên còn lại (đồng hạng với sinh viên ở vị trí k-1)
            for (int i = k; i < students.Count; i++)
            {
                // Nếu GPA của sinh viên hiện tại bằng GPA của sinh viên trước đó
                if (students[i].CalculateGPA(students[i].Scores) == students[i - 1].CalculateGPA(students[i - 1].Scores))
                {
                    // Ghi thông tin vào kết quả
                    sb.AppendLine($"{rank} {students[i].Id} {students[i].Name} {Math.Round(students[i].CalculateGPA(students[i].Scores))}");
                }
                else
                {
                    break; // Nếu GPA khác, dừng vòng lặp
                }
            }

            Console.WriteLine(sb.ToString());
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



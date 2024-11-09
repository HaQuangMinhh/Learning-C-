namespace EIUGRDSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            
            var numStudent = reader.NextInt();  // 2 
            var numProblem = reader.NextInt();   // 2 
            var numSubmission = reader.NextInt();   // 3 

            // Create a dictionary to hold students by ID
            var eachStudentId = new Dictionary<int, Student>();

            for ( int i = 0; i < numStudent; i++ ) {
                var id = reader.NextInt();    // 1 
                eachStudentId[id] = new Student(id);    
            }

            // create List of exercise 
            var eachProblem = new List<int>();
            for ( int i = 0; i < numProblem; i++ ) { 
                 eachProblem.Add(reader.NextInt());  
            }

            // Process submissions
            for ( int i = 0; i < numSubmission; i++ ) { 
                var studentId = reader.NextInt();   
                var problemId = reader.NextInt();   
                var score = reader.NextInt();

                eachStudentId[studentId].UpdateScore(problemId, score);
            }


            foreach ( var student in eachStudentId.Values ) {
                Console.WriteLine( $"{student.ID} {student.CalculateAvg() }" );
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

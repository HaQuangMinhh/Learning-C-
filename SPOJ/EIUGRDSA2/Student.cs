using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUGRDSA2
{
    internal class Student
    {
        public int Id { get; set; }
        public Dictionary<int, double> HighestScore { get; set; }
        public int SubmissionCount { get; set; }

        public Student(int id)
        {
            Id = id;

            HighestScore = new Dictionary<int, double>();
            SubmissionCount = 0;
        }

        public void UpdateScore(int problemId, double score)
        {
            if (!HighestScore.ContainsKey(problemId))
            {

                HighestScore[problemId] = score;
            }
            else
            {
                HighestScore[problemId] = Math.Max(HighestScore[problemId], score);
            }
        }

        public double CalculateAvg() {
            if ( HighestScore.Count == 0 ) {
                return 0; 
            }

            return HighestScore.Values.Sum() / HighestScore.Count;
        
        }


    }
}

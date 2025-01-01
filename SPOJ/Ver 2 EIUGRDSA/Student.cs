using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUGRDSA
{
    internal class Student
    {
        public int Id {  get; set; }
        private Dictionary<int , double> highestScores { get; set; }

        public Student( int id ) {
            Id = id; 

            highestScores = new Dictionary<int , double>();
        }

        // Update score 
        public void UpdateScore(int problemId, double score) {

            if (!highestScores.ContainsKey(problemId) ) {

                highestScores[problemId] = score;
            } else {
                highestScores[problemId] = Math.Max(highestScores[problemId], score);
            }
        }

        // Avg Score 
        public double CalculateAvg (int totalProblems ) { 
            var totalScore = highestScores.Values.Sum();
            return totalScore / totalProblems;
        }


        




    }
}

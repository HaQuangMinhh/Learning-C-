using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUGRDSA
{
    internal class Student
    {
        public int ID {  get; set; }

        public Dictionary<int, int> highestScore; 

        public Student(int id ) { 
            ID = id;
            highestScore = new Dictionary<int, int>();  
        }


        public void UpdateScore( int problemId , int score  ) {

            if (highestScore.ContainsKey(problemId))
            {
                highestScore[problemId] = Math.Max(highestScore[problemId], score);
            }
            else {
                highestScore[problemId] = score ;
            }
        }

        public int CalculateAvg() { 
            if ( highestScore.Count == 0 ) { 
                return 0;
            }

            // Tính tổng score các score cao nhất
            int sum = 0; 
            foreach ( var score in highestScore.Values ) { 
                sum += score;
            }

            return   sum / highestScore.Count ;
        }
        

    }
}

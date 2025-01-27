using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISCHSH
{
    internal class Student
    {
        public long Id { get; set; } 
        public string Name { get; set; }    
        public List<double> Scores { get; set; } = new List<double>();

        public int Rank { get; set; }

        // Constructor
        public Student(  long id , string name , List<double> scores )  { 
            Id = id;
            Name = name;
            Scores = scores;
        }

        public double CalculateGPA( List<double> scores ) {

            double totalScore = 0;
            var passedCourseCount = 0;

            foreach (var score in Scores) {

                if (score >= 50 ) { 
                    totalScore += score;
                    passedCourseCount++;    
                }
            }
            
            return passedCourseCount > 0 ? totalScore / passedCourseCount : 0;  
        }





    }
}

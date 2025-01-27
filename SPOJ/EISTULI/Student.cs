using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISTULI
{
    internal class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<double> Scores { get; set; } = new List<double>();

        public Student(long id, string name, List<double> scores) { 
            Id = id;
            Name = name;
            Scores = scores;    
        }

        public int Credits { get; set; }
        public double GPA { get; set; }


        public void CalculateGPAAndCredits() {

            double totalScores = 0;
            var passCourseCount = 0;

            foreach ( var score in Scores ) {

                if ( score >= 50 ) {
                    totalScores += score; 
                    passCourseCount++;
                }
            }

            GPA = passCourseCount > 0 ? totalScores / passCourseCount : 0;
            Credits = passCourseCount * 4;
        }

    }
}

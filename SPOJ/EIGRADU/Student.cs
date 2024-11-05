using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIGRADU
{
    public class Student
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public List<long> Grades { get; set; }
        public int CreditsEarned { get; set; }
        public long AvgGPA { get; set; }



        public Student( string id , string name, List<long> grades ) {
            Id = id;
            Name = name;
            Grades = grades;
            
            CalculateCreditsGPA();
        }

        //Calculate tín chỉ  và tính GPA
        public void CalculateCreditsGPA() {
            CreditsEarned = 0; 
            long total = 0;
            int count = 0;

            foreach ( var eachGrade in Grades ) {
                if ( eachGrade >= 50  ) {
                    CreditsEarned += 4;
                    total += eachGrade;
                    count++; 
                }
            }


            if (count > 0)
            {
                AvgGPA = ( long )total / count;
            }
            else { 
                AvgGPA= 0;
            }
        }


        public override String ToString()
        {
            return $"{Id} {Name} {AvgGPA}";
        }
    }
}

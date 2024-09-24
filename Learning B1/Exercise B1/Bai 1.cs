
namespace Exercise_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Student Grades Analysis 

            // Input Grades
            var numStudents = int.Parse(Console.ReadLine());

            var grades = new List<double>();

            var passGrades = new List<double>();
            double sum = 0;

            for (int i = 0; i < numStudents; i++) {

                double currentGrade;
                var isDataNotAccurate = false; 
               
                do
                {  // vòng do-while bắt buộc user input right 
                    
                    currentGrade = double.Parse(Console.ReadLine());
                    
                    isDataNotAccurate = currentGrade < 0 || currentGrade > 100 ; 

                    if (isDataNotAccurate)
                    {
                        Console.WriteLine("each grade for students between 0 and 100");
                    }

                } while (isDataNotAccurate); 
                   
                // Add score hợp lệ 
                grades.Add(currentGrade);
                sum += currentGrade;       // Calculate Average 

                if (currentGrade >= 50) { 
                    passGrades.Add(currentGrade);
                }
            }

            double average = sum / grades.Count ;

            Console.WriteLine($"Average for each grade is: {average}") ;

            Console.WriteLine(); 
            
            // Grade Classification 
            if (average >= 90) {
                Console.WriteLine("Excellent");
            } else if (average >= 70) {
                Console.WriteLine("Good");
            } else if (average >= 50) {
                Console.WriteLine("Pass");
            } else {
                Console.WriteLine("Fail"); 
            }

            // Print List of passing students >= 50
            Console.WriteLine() ;
            Console.WriteLine("List of grades >= 50: ");

            var passGradesCount = passGrades.Count ;

            for (int i = 0; i < passGradesCount; i++) {
                Console.WriteLine(passGrades[i]);
            }
            Console.WriteLine($"have {passGradesCount} grades > 50 ") ;
            
        }
    }
}
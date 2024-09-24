namespace Introduction_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          int a = int.Parse(Console.ReadLine()); 
                        int b = int.Parse(Console.ReadLine());

                        if (a >= b)
                        {
                            Console.WriteLine("Yes");
                        }
                        else {
                            Console.WriteLine("No"); 
                        }                   */

            //int time = int.Parse(Console.ReadLine());

            //string result = (time > 50) ? "Good Day" : "Good Evening"; 

            //Console.WriteLine(result);


            // Double --> int 
            double n = 9.5D;

            int result = (int) n; 

            Console.WriteLine(result);
            Console.WriteLine();

            //String --> double , int 

            var name = "50";

            var name2 = int.Parse(name);
            var name3 = double.Parse(name);

            Console.WriteLine(name2);
            Console.WriteLine();

            // double , int -> string
            
            var myDouble = 5.5;
            var myInt = 9; 

            var resultString1 = myDouble.ToString();
            var resultString2 = myInt.ToString();


            Console.WriteLine(resultString1);
            Console.WriteLine(resultString2);

            Console.WriteLine();
            Console.WriteLine();

            // requirement
            // List in C# --> declare ,  get data , add data , remove
            
            // create more data
            var myList = new List<string>();
            // add data 
            myList.Add("Mango22");
            myList.Add("Apple33");

            // remove
            myList.Remove("Apple33"); 

            foreach (string fruit1 in myList) {
                Console.WriteLine(fruit1); 
            }

            Console.WriteLine();
            Console.WriteLine();

            // containing data
            var fruits = new List<string> { "Apple", "Banana", "Orange", "Mango" };
            // get data 
            string firstFruit = fruits[0];
            var secondFruit = fruits.ElementAt(2); 

            Console.WriteLine(firstFruit);
            Console.WriteLine(secondFruit);

            // add data 
            fruits.Add("Grapes");

            // remove data
            fruits.Remove("Apple");   // remove 1 vật cụ thể 

            fruits.RemoveAt(3); // remove index

            // Result 
            Console.WriteLine("Updated list of fruits");

            foreach (var fruit in fruits) {
                Console.WriteLine(fruit); 
            }


            Console.WriteLine();
            Console.WriteLine();

            // Array 
            int[] scores = new int[3];
            var names = new string[100];
            
            
            // for loop 
            var grades = new List<int>();

            grades.Add(1);
            grades.Add(2);
            grades.Add(4);
            grades.Add(6);
            grades.Add(1); 
            grades.Add(54);
            grades.Add(1);
            grades.Add(4);

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] % 2 == 0)
                {
                    Console.WriteLine($"current index {i}, name: {grades[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine();


            // Advanced 

            // remove even numbers, show odd number following index from 0 to ...

            // Before remove 
            Console.WriteLine("Before remove");
            for (int i = 0; i < grades.Count; i++) {
                Console.WriteLine($"current index {i}, name: {grades[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("After remove: ");

            // remove name
            // grades.remove(2);

            // Remove index  
            // grades.RemoveAt(2);

            // Remove even numbers 
            grades.RemoveAll( n => n % 2 == 0);


            for (int i = 0; i < grades.Count; i++) {
                Console.WriteLine($"current index {i}, name: {grades[i]}");
            }

            Console.WriteLine();
            Console.WriteLine();

                                                // Exercise 2 
            // list  1 2 5 4 6 7 
            // index 0 1 2 3 4 5 

            // out 
            // list     1 5 7 
            // index    0 1 2 
            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(5);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(7);

            Console.WriteLine("Before remove");
            for (int i = 0; i < numbers.Count; i++) {
                Console.WriteLine($"current index {i}, name: {numbers[i]}");
            }

            Console.WriteLine();

            numbers.RemoveAll(n => n % 2 == 0);

            Console.WriteLine("After remove");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"current index {i}, name: {numbers[i]}");
            }



        }
    }
}

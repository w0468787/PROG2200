using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many students?");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine("how many grade entries per student"); 
            var grades = int.Parse(Console.ReadLine());
            var stuArray = new string[size,grades+1];
            for (int i = 0; i < size; i++) {
                Console.WriteLine("Student Name: ");
                String name = Console.ReadLine();
                stuArray[i, 0] = name;
                for (int j = 0; j < grades; j++) {
                    Console.WriteLine("Grade #"+(j+1));
                    String gradeEntry = Console.ReadLine();
                    if (j >= 0)
                    stuArray[i, j+1] = gradeEntry;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Student Name: " + stuArray[i, 0]);
                for (int j = 0; j < grades; j++)
                {
                    Console.WriteLine("Grade #" + (j + 1));
                    if (j >= 0)
                    Console.WriteLine("" + stuArray[i, j+1]);
                }
            }
        }
    }
}

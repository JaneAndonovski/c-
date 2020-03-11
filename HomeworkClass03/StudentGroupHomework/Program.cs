using System;

namespace StudentGroupHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StudentGroupHomework

            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentsG2 = new string[] { "Bojan", "Nikola", "Slavko", "Borjan", "Andrej" };

            Console.WriteLine("Enter number between: 1 or 2");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("The students in G1 are:");
                foreach (string element in studentsG1)
                {
                    Console.WriteLine(element);
                }
            }
            if (userInput == 2)
            {
                Console.WriteLine("The students in G2 are:");
                foreach (string element in studentsG2)
                {
                    Console.WriteLine(element);
                }
            }

            Console.ReadLine();



            #endregion
        }
    }
}

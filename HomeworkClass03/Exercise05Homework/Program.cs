using System;

namespace ArraysExercise05Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region ArraysExercise05Homework

            int[] arrayOfIntegers = new int[5];

            Console.WriteLine("Enter first number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            arrayOfIntegers[0] = userInput1;

            Console.WriteLine("Enter second number: ");
            int userInput2 = int.Parse(Console.ReadLine());
            arrayOfIntegers[1] = userInput2;

            Console.WriteLine("Enter third number: ");
            int userInput3 = int.Parse(Console.ReadLine());
            arrayOfIntegers[2] = userInput3;

            Console.WriteLine("Enter four number: ");
            int userInput4 = int.Parse(Console.ReadLine());
            arrayOfIntegers[3] = userInput4;

            Console.WriteLine("Enter five number: ");
            int userInput5 = int.Parse(Console.ReadLine());
            arrayOfIntegers[4] = userInput5;

            int result = 0;
            foreach (int element in arrayOfIntegers)
            {

                result += element;
            };
            Console.WriteLine("The sum of all values in this array is: " + result);

            Console.ReadLine();

            #endregion


        }
    }
}

using System;

namespace SumOfEvenHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SumOfEvenHomework

            int[] integerArray = new int[6];

            Console.WriteLine("Enter integer no.1: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            integerArray[0] = userInput1;

            Console.WriteLine("Enter integer no.2: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            integerArray[1] = userInput2;

            Console.WriteLine("Enter integer no.3: ");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            integerArray[2] = userInput3;

            Console.WriteLine("Enter integer no.4: ");
            int userInput4 = Convert.ToInt32(Console.ReadLine());
            integerArray[3] = userInput4;

            Console.WriteLine("Enter integer no.5: ");
            int userInput5 = Convert.ToInt32(Console.ReadLine());
            integerArray[4] = userInput5;

            Console.WriteLine("Enter integer no.6: ");
            int userInput6 = Convert.ToInt32(Console.ReadLine());
            integerArray[5] = userInput6;


            int result = 0;

            foreach (int element in integerArray)
            {
                if (element % 2 == 0)
                {
                    result += element;
                }

            }
            Console.WriteLine("The sum of even numbers are: " + result);

            Console.ReadLine();


            #endregion
        }
    }
}

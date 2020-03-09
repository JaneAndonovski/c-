using System;

namespace HomeworkAverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the four number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int result = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of: {0}, {1}, {2} and {3} is: {4}", num1, num2, num3, num4, result);

            Console.ReadLine();
        }
    }
}

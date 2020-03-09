using System;

namespace HomeworkClass02SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int swNum;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            swNum = num1;
            num1 = num2;
            num2 = swNum;

            Console.WriteLine("After Swaping: ");

            Console.WriteLine("First number:" + num1);

            Console.WriteLine("Second number:" + num2);

            Console.ReadLine(); 


        }
    }
}

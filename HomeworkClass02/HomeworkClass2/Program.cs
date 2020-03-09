using System;

namespace HomeworkClass2RealCalculator
{
    class Program
    {
         static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            char operation;

            Console.WriteLine("Enter first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operator: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result is: ");

            if (operation == '+') { 
                Console.WriteLine(firstNum + secondNum);
            } 
            else if (operation=='-')
            {
                Console.WriteLine(firstNum - secondNum);
            } 
            else if (operation=='*')
            {
                Console.WriteLine(firstNum * secondNum);
            }
            else if (operation=='/')
            {
                Console.WriteLine(firstNum / secondNum);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}

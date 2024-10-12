
using System.Reflection.Metadata.Ecma335;

namespace InterviewPrograms
{
    public static class FibonacciSeries
    {
        //Input : 5
        //Ouptut : 0, 1, 1, 2, 3, 5
        public static void printFibonacciSeriesRecursion()
        {
            Console.WriteLine("Enter Fibonacci Series Number.");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                int result = FibonacciInRecursion(i);
                Console.WriteLine("Print Fibo Series for number: " + result);
            }
        }

        private static int FibonacciInRecursion(int number)
        {
            if (number <= 1)
            {
                return number;
            }

           return FibonacciInRecursion(number - 1)+ FibonacciInRecursion(number-2);
        }

        //Input : 5
        //Ouptut : 0, 1, 1, 2, 3, 5
        public static void printFibonacciSeriesIteration()
        {
            int number1 = 0;
            int number2 = 1;
            int number3 = 0;
            Console.WriteLine("Enter Fibonacci Series number:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Print Fibo Series for number: "+number1);
                    continue;
                }

                if (i == 1)
                {

                    Console.WriteLine("Print Fibo Series for number: " + number2);
                    continue;
                }

                number3 = number1 + number2;
                Console.WriteLine("Print Fibo Series for number: " + number3);
                int temp = 0;
                temp = number3;
                number1 = number2;
                number2 = temp;
            }
        }
    }
}

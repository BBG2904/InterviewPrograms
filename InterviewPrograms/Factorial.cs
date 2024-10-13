namespace InterviewPrograms
{
    public static class Factorial
    {
        //Input: 4
        //Output: 24
        public static void printFactorial()
        {
            Console.WriteLine("Enter Factorial Number.");
            int number = Convert.ToInt32(Console.ReadLine());
            var result =DoFactorial(number);
            Console.WriteLine($"Factorial for number {number} is "+result);  
            var resultIteration = DoFactorialInIteration(number);
            Console.WriteLine($"Iteration Factorial for number {number} is " + resultIteration);
        }

        private static int DoFactorial(int number)
        {
            if (number <= 1)
            {
                return number;
            }

            return number * DoFactorial(number - 1);
        }

        private static int DoFactorialInIteration(int number)
        {
            int result = 1;
            for (int i = number; i > 0; i--)
            {
               
                result = result * i;
            }

            return result;
        }
    }
}

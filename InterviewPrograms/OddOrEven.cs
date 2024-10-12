namespace InterviewPrograms
{
    public static class OddOrEven
    {
        public static void PrintOddOrEven()
        {
            Console.WriteLine("Enter the number to figure out it is odd or even.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number +" is even number.");
            }
            else
            {
                Console.WriteLine(number + " is odd number.");
            }
        }
    }
}

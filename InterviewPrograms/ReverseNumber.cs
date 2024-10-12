namespace InterviewPrograms
{
    public static class ReverseNumber
    {
        //Input: 54
        //Output: 45
        public static void PrintReverseNumber()
        {
            int input = Convert.ToInt32 (Console.ReadLine());
            double result = 0;
            int i = 0;
            Console.WriteLine("Input number: "+ input);
            while (input > 0)
            {    
                int number = input % 10;   // get the reminder
                input = input / 10;        // get the quotient
                result = result * Math.Pow(10, i) + number;
                i++;
            }
            Console.WriteLine("Reverse number: "+ result);
        }
    }
}

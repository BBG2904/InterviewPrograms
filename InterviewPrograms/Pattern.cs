namespace InterviewPrograms
{
    public static class Pattern
    {
        public static void PrintTriangles()
        {
            TrainglePattern();
            InvertedTraingle();
            TraingleNumberPattern();
        }
        //up side triangle
        private static void TrainglePattern()
        {
            Console.WriteLine("Print Triangle");
            for (int i = 0; i < 5; i++)
            {
                for(int k =0; k < 5 - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        //down side triangle
        private static void InvertedTraingle()
        {
            Console.WriteLine("");
            Console.WriteLine("Print Inverted Triangle");
            for(int i = 0;i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(" ");

                }

                for(int k=0; k < 5 - i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        //Number triangle
        private static void TraingleNumberPattern()
        {
            Console.WriteLine();
            Console.WriteLine("Print Number Triangle");
            int number = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4 - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($" {number}");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}

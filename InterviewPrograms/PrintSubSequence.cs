namespace InterviewPrograms
{
    public static class PrintSubSequence
    {
        public static void printSubSequence()
        {
            var input = new int[] { 1, 2, 3 };
            var output = new List<int>();
            Console.WriteLine("Print SubSequence:");
            DoSubSequence(input, 0, output);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Print SubSequence in reverse"); 
            DoSubSequenceInReverse(input, 0, output);
        }

        // Output
        //1, 2, 3
        //1, 2
        //1, 3
        //1
        //2, 3
        //2
        //3
        //{}
        private static void DoSubSequence(int[] input, int v, List<int> output)
        {
            if (input.Length == v)
            {
                Console.WriteLine((output.Count == 0) ? "{}" : string.Join(", ", output));
                return;
            }
            //consider the number
            output.Add(input[v]);
            DoSubSequence(input, v + 1, output);
            if (output.Count > 0)
            {
                //backtrack
                output.RemoveAt(output.Count - 1);
            }
            //not consider the number
            DoSubSequence(input, v + 1, output);
        }

        // Output
        //{}
        //3
        //2
        //2, 3
        //1
        //1, 3
        //1, 2
        //1, 2, 3
        private static void DoSubSequenceInReverse(int[] input, int v, List<int> output)
        {
            if(input.Length   == v)
            {
                Console.WriteLine((output.Count == 0)? "{}" :string.Join(", ", output));
                return;
            }
            //not consider the number
            DoSubSequenceInReverse(input, v+1, output);
            output.Add(input[v]);
            //consider the number
            DoSubSequenceInReverse(input, v + 1, output);

            if (output.Count > 0)
            {
                //backtrack
                output.RemoveAt(output.Count - 1);
            }
        }
        

    }
}

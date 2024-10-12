namespace InterviewPrograms
{
    public static class SumOfSubSet
    {
        //Input :{ 1, 3, 5, 4, 2 } Target Sum: 8
        //Output : [3, 5] [1, 5, 2] [1, 3, 4]
        public static void PrintSumOfSubSets()
        {
            int targetSum = 8;
            var input = new int[] { 1, 3, 5, 4, 2 };
            var output = new List<int>();
            Console.WriteLine("Print all Sum Of Subsets:");
            DoSumOfSubSets(input, 0, targetSum, output);
        }

        private static void DoSumOfSubSets(int[] input, int v, int targetSum, List<int> output)
        {
            if (targetSum == 0)
            {
                Console.WriteLine(output.Count == 0? "[]":"["+string.Join(", ", output)+"]");
                return;
            }

            if (input.Length == v)
            {
                return;
            }

            //not consider for sum
            DoSumOfSubSets(input, v + 1, targetSum, output);

            if(targetSum - input[v] >= 0)
            {
                output.Add(input[v]);
                //consider for sum
                DoSumOfSubSets(input, v+1, targetSum - input[v], output);
                if (output.Count > 0)
                {
                    //backtrack
                    output.RemoveAt(output.Count - 1);
                }
            }
        }
    }
}

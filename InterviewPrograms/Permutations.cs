namespace InterviewPrograms
{
    public static class Permutations
    {
        //swap first character in first row(00, 01, 02) and provide three result abc bac cba
        //Keep second character swap in second row(11, 12) to get third row. First character will be unchanged here.
                            //abc
                   //abc    bac    cba
                  //abc acb  bac bca  cba cab

        //Input:  abc
        //Output: abc,bac,cba,acb,bca,cab
        public static void PermutationIteration()
        {
            var input = "abc";
            var interList = new List<string>();
            var tempList = new List<string>();

            interList.Add(input);
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    foreach (var c in interList)
                    {
                        var swapResult = Swap(c.ToCharArray(), i, j);
                        if (!interList.Contains(swapResult))
                        {
                            tempList.Add(swapResult);
                        }
                    }
                }

                foreach (var c in tempList)
                {
                    if (!interList.Contains(c))
                    {
                        interList.Add(c);
                    }
                }
            }

            Console.WriteLine("Print all Permuations of a given string "+input);
            Console.WriteLine(string.Join(",", interList));
        }


        private static string Swap(char[] input, int i, int j)
        {
            char temp = '\0';
            temp = input[i];
            input[i] = (char)input[j];
            input[j] = temp;
            return new string(input);
        }
    }
}

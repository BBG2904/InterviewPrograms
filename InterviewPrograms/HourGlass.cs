//Explanation
// 0 -4, -6  0 -7 -6
//-1 -2  -6 -8 -3 -1 
//-8 -4  -2 -8 -8 -6
//-3 -1  -2 -5 -7 -4
//-3 -5  -3 -6 -6 -6
//-3 -6   0 -8 -6 -7


// 0 -4 -6
//   -2 
//-8 -4 -2

//Here we removed -1 and -6 from second row. Then we do the sum.
//Sum is -26

//Do the same for all the combinations by following steps
//1) pick first 3*3 matrix from left end
//2) Get Sum of it then move one step to right and them sum it.
//3) Continue and reach the right end with this 3*3 matrix.
//4) One step down, then start again from left to right with 3*3 matrix.
//5) Find the maximum sum out of this for all combinations.

namespace InterviewPrograms
{
    public class HourGlass
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int limit = 3;
            int maxSum = arr[0][0] + arr[0][1] + arr[0][2] + arr[1][1] + arr[2][0] + arr[2][1] + arr[2][2]; 
            int sum = 0;
            for (int l = 0; l <= limit; l++)
            {
                for (int k = 0; k <= limit; k++)
                {
                    for (int i = 0 + l; i < limit + l; i++)
                    {
                        for (int j = 0 + k; j < limit + k; j++)
                        {
                            if (i == l + 1)
                            {
                                if (j == limit + k - 2)
                                {
                                    sum += arr[i][j];
                                }
                            }
                            else
                            {
                                sum += arr[i][j];
                            }
                        }
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }

            return maxSum;
        }


        public static void DoHourGlass()
        {
            var input = new List<List<int>>();
            input.Add(new List<int>() {0, -4, -6, 0, -7, -6 });
            input.Add(new List<int>() {-1,-2,-6,-8,-3,-1 });
            input.Add(new List<int>() {-8,-4,-2,-8,-8,-6 });
            input.Add(new List<int>() {-3,-1,-2,-5,-7,-4 });
            input.Add(new List<int>() {-3,-5,-3,-6,-6,-6 });
            input.Add(new List<int>() {-3,-6,0, -8,-6,-7 });
            hourglassSum(input);
        }
    }
}

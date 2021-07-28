using System;

namespace algo.samples
{
    public static partial class Algo
    {
        private static readonly int[] arr = new int[10];
        public static void SubArray(int n)
        {
            // Pick starting point
            for (int i = 0; i < n; i++)
            {
                // Pick ending point
                for (int j = i; j < n; j++)
                {
                    // Print subarray between current
                    // starting and ending points
                    for (int k = i; k <= j; k++)
                        Console.Write(arr[k] + " ");
                    Console.WriteLine("");
                }
            }
        }

        public static int SubarraySum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; i++)
                {
                    sum += arr[j];
                    result += sum;
                }
            }
            return result;
        }
    }
}
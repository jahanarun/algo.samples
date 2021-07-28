using System;

namespace algo.samples
{
    // subsequesnce and subset are similar
    public partial class Algo
    {
        public static void PrintSubsequences(int[] arr, int n)
        {
            // Number of subsequences is (2**n -1)
            int opsize = (int)Math.Pow(2, n);

            // Run from counter 000..1 to 111..1
            for (int counter = 1; counter < opsize; counter++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Check if jth bit in the counter is set
                    // If set then print jth element from arr[]
                    if ((counter & (1 << j)) != 0)
                        Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
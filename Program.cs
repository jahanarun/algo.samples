using System;

namespace algo.samples
{
    internal static class Program
    {
        private static void Main()
        {
            var arr = new int[] { 4, 2, 6, 3 };
            Algo.PrintSubsequences(arr, arr.Length);
        }

        // private static void Reader()
        // {
        //     var patientsDoctors = Console.ReadLine()
        //                             .Split(' ')
        //                             .Where(x => Int32.TryParse(x, out _))
        //                             .Select(x => Convert.ToInt32(x))
        //                             .ToArray();
        //     Doctors = patientsDoctors[0];
        //     Patients = patientsDoctors[1];

        //     matrix = new int[Doctors, Patients];

        //     for (int i = 0; i < Doctors; i++)
        //     {
        //         var doctoreffort = Console.ReadLine()
        //                         .Split(' ')
        //                         .Where(x => Int32.TryParse(x, out _))
        //                         .Select(x => Convert.ToInt32(x))
        //                         .ToArray();
        //         for (int j = 0; j < Patients; j++)
        //         {
        //             matrix[i, j] = doctoreffort[j];
        //         }
        //     }

        // }
    }
}

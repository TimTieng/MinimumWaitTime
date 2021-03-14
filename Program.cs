using System;

namespace MinimumWaitTime
{
    class Program
    {
        static void MinimumWaitTime(int[] queryTimes)
        {
            // take the input array and sort
            // Simplest way => Array.Sort(arrayName)
            Array.Sort(queryTimes);

            // Declare a running sum of execution Times
            int executionTime = 0;

            // Iterate through the array, update the value of executionTime at each index
            for (int i = 0; i < queryTimes.Length; i++)
            {
                // min time = value at index 0  * (remaining query execution time values)
                // at i =0; executionTime = 1 * (5 - (0+1)) => 4
                executionTime += queryTimes[i] * (queryTimes.Length - (i + 1));
            }
            // Present minimum time to user
            Console.WriteLine($"The Minimum Wait Time to execute your list of queries: {executionTime} seconds");
        }
        static void Main(string[] args)
        {
            // Test 1 - should be 17
            int[] queries1 = {3,2,1,2,6};
            MinimumWaitTime(queries1);

            // Test 2 - Should be 78
            int[] queries2 = {3,45,32,1,7,5};
            MinimumWaitTime(queries2);
        }
    }
}

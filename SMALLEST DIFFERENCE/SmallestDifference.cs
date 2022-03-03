using System;
namespace Exercise002
{
    public class SmallestDifference
    {
        public int Calculate(int[] t)
        {
            int n= t.Length;
            // Initialize difference as infinite
            int difference = int.MaxValue;

            // Find the min diff by comparing difference
            // of all possible pairs in given array
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (Math.Abs((t[i] - t[j]) ) < difference)
                    {
                        difference = Math.Abs((t[i] - t[j]));
                    }
                }

            }


            // Return min diff
            return difference;
        }
    }
}

using System;
using System.Text;

namespace Exercise005
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
          int[] arr = new int[n];
          /*
          result is array with items 1 to n
          inversions = 0
          latest = n-1
          lowest = 0
          while inversions < k
              swap result[latest] and result[latest-1]
              inversions += 1
              latest--
              if latest is lowest
                  latest is n-1
                  lowest += 1
          return result
          */
          for (int i = 0; i < n; i++)
          {
            arr[i] = i + 1;
          }
          int inversions = 0;
          int latest = n-1;
          int lowest = 0;

          while (inversions < k)
          {
            int temp = arr[latest];
            arr[latest] = arr[latest - 1];
            arr[latest - 1] = temp;

            inversions+=1;
            latest--;

            if (latest == lowest)
            {
              latest = (n - 1);
              lowest+=1;
            }
          }
          return arr;
        }
    }
}

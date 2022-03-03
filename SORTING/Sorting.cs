namespace Exercise003
{
    public class Sorting
    {

        public int[] MergeSort(int[] t)
        {
            int a = 0;
            int b = t.Length;
            int k = (a + b) / 2;
            int[] left = new int[k];
            int[] right = new int[b - k];

            if (t.Length == 1)
            {
                return t;
            }
            for (int i = 0; i <= t.Length - 1; i++)
            {
                if (i < k)
                {
                    left[i] = t[i];
                }
                else
                {
                    right[i - k] = t[i];
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private int[] Merge(int[] a, int[] b)
        {
            int totalLength = a.Length + b.Length;
            int[] result = new int[totalLength];
            int[] helper = new int[totalLength];

            // The variables from the example
            int a1 = 0;
            int b1 = a.Length - 1;
            int a2 = 0;
            int b2 = b.Length - 1;

            for (int i = 0; i <= totalLength - 1; i++)
            {
                if (a2 > b2 || (a1 <= b1 && a[a1] <= b[a2]))
                {
                    helper[i] = a[a1];
                    a1++;
                }
                else
                {
                    helper[i] = b[a2];
                    a2++;
                }
            }
            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = helper[i];
            }
            return result;
        }


        public int[] QuickSort(int[] t, int a, int b)
        {
            if (a >= b)
            {
                return t;
            }
            int k = Pivot(t, a, b);

            QuickSort(t, a, k - 1);
            QuickSort(t, k + 1, b);
            return t;
        }

        private int Pivot(int[] t, int a, int b)
        {
            int k = a;

            for (int i = a + 1; i <= b; i++)
            {

                if (t[i] < t[a])
                {
                    k += 1;
                    int swap = t[k];
                    t[k] = t[i];
                    t[i] = swap;
                }
            }
            int temp = t[k];
            t[k] = t[a];
            t[a] = temp;
            return k;
        }
    }
}

namespace Epam_Task2
{
    internal class BinarySearch
    {
        public int BSearch(int[] input, int key)
        {
            int L = 0;
            int R = input.Length - 1;
            while (L <= R)
            {
                int m = (L + R) / 2;

                if (input[m] < key)
                {
                    L = m + 1;
                }
                else if (input[m] > key)
                {
                    R = m - 1;
                }
                else return m;
            }
            return -1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task2
{
    class BinarySearch
    {
        public void BSearch(int[] input, int key, int start, int end)
        {
            int index = -1;
            int mid = (start + end) / 2;            
            if (input[start] <= key && key <= input[end])
            {
                if (key < input[mid])
                {
                    BSearch(input, key, start, mid);
                }
                else if (key > input[mid])
                {
                    BSearch(input, key, mid + 1, end);
                }
                else if (key == input[mid])
                {
                    index = mid;
                }
                if (index != -1)
                {
                    Console.WriteLine($"Элемент найден на позиции ->{index}");                    
                }                
            }            
        }
    }
}

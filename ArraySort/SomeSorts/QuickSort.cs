using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort.SomeSorts
{
    /// <summary>
    ///快速排序
    /// </summary>
    class QuickSort
    {
        public static int[] Sort(int[] inputSrc)
        {
            int[] input = inputSrc.ToArray();
            if (input == null || input.Count() == 0)
                return null;
            ChildSort(input,0,input.Length-1);
            return input;
        }

        private static void ChildSort(int[] input, int left, int right)
        {
            if (left >= right)
                return;
            int partitionIndex = Partition(input, left, right);
            ChildSort(input, left, partitionIndex - 1);
            ChildSort(input, partitionIndex + 1, right);
        }
        private static int Partition(int[] input, int left, int right)
        {
            
            int low = left;
            int high = right;
            int pivot = input[low];
            while (low < high)
            {
                while (low < high && input[high] >= pivot)
                    high--;

                input[low] = input[high];


                while (low < high && input[low] <= pivot)
                    low++;

                input[high] = input[low];

              


            }

            input[low] = pivot;
            return low;
        }
    }
}

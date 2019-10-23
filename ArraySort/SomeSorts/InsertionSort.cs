using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort.SomeSorts
{
    /// <summary>
    /// 插入排序
    /// </summary>
    class InsertionSort
    {
        public static int[] Sort(int[] inputSrc)
        {
            if (inputSrc == null || inputSrc.Length <= 1)
                return inputSrc;
            int[] input = inputSrc.ToArray();
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j >=1; j--)
                {
                    if (input[j - 1] > input[j])
                    {
                        input.Swap(j-1,j);
                    }
                }
            }
            return input;
        }
    }
}

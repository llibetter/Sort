using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort.SomeSorts
{
    /// <summary>
    /// 选择排序
    /// </summary>
    class SectionSort
    {
        public static int[] Sort(int[] inputSrc)
        {
            if (inputSrc == null || inputSrc.Length <= 1)
                return inputSrc;
            int[] input = inputSrc.ToArray();
        
            for (int i = 0; i < input.Length-1; i++)
            {
                int maxIndex = 0;
                for (int j = maxIndex + 1; j < input.Length-i; j++)
                {
                    if (input[maxIndex] < input[j])
                    {
                        maxIndex = j;
                    }
                }
                if (maxIndex!= input.Length - 1 - i)
                {
                    input.Swap(maxIndex, input.Length - 1 - i);
                }
            }
            return input;
        }
    }
}

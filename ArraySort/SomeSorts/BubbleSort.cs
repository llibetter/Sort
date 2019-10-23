using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort.SomeSorts
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    class BubbleSort
    {
        public static int[] Sort(int[] inputSrc)
        {
            int[] input = inputSrc.ToArray();
            if (input == null || input.Count() == 0)
                return null;
            for (int i = 0; i < input.Count()-1; i++)
            {
                bool isSwap = false;

                for (int j = 0; j < input.Count()-i-1; j++)
                {
                    if (input[j] > input[j+1])
                    {
                        input.Swap(j,j+1);
                        isSwap = true;
                    }
                }

                if (!isSwap)
                    break;
            }
            return input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    static class Utils
    {
        public static string Array2String(this int[] a)
        {
          string result=string.Join(",",a);
          return result;
        }

        public static void Swap(this int[] input,int index1,int index2)
        {
            int temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
        }
    }
}

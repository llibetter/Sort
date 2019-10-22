using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] {2,43,54,234,754,213,3,4,543,23,23,654,3,4,2341 };
            Console.WriteLine($"冒泡排序结果：\t{BubbleSort.Sort(test).Array2String()}");
            Console.WriteLine($"选择排序结果：\t{SectionSort.Sort(test).Array2String()}");
            Console.WriteLine($"选择排序结果：\t{SectionSort.Sort(test).Array2String()}");
            Console.ReadKey();
        }
    }
}

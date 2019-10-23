using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ArraySort.SomeSorts;
namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 2, 43, 54, 234, 754, 213, 3, 4, 543, 23, 23, 654, 3, 4, 2341, -1 };
            //int[] test = new int[] { 2, 3,1,5,9};


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            string str1 = BubbleSort.Sort(test).Array2String();
            Console.Write($"冒泡排序结果：\t{str1}");
            stopWatch.Stop();
            Console.WriteLine($"\t耗时：{stopWatch.Elapsed.TotalMilliseconds}ms");

            stopWatch.Restart();
            string str2 = SectionSort.Sort(test).Array2String();
            Console.Write($"选择排序结果：\t{str2}");
            stopWatch.Stop();
            Console.WriteLine($"\t耗时：{stopWatch.Elapsed.TotalMilliseconds}ms");

            stopWatch.Restart();
            string str3 = QuickSort.Sort(test).Array2String();
            Console.Write($"快速排序结果：\t{str3}");
            stopWatch.Stop();
            Console.WriteLine($"\t耗时：{stopWatch.Elapsed.TotalMilliseconds}ms");


            if (str1 == str2 && str2 == str3)
                Console.WriteLine("所有排序算法结果相同！");


            Console.ReadKey();
        }
    }
}

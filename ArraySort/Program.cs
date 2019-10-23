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
            int[] test = new int[] {2,43,54,234,754,213,3,4,543,23,23,654,3,4,2341,-1 };
            //int[] test = new int[] { 2, 3,1,5,9};


            Stopwatch sw = new Stopwatch();
            sw.Restart();
            string s1 = BubbleSort.Sort(test).Array2String();
            Console.WriteLine($"冒泡排序结果：\t{s1}");
            sw.Stop();
            Console.WriteLine($"耗时：\t{sw.Elapsed.TotalMilliseconds}ms");
            
            sw.Restart();
            string s2 = SectionSort.Sort(test).Array2String();

            Console.WriteLine($"选择排序结果：\t{s2}");
            sw.Stop();
            Console.WriteLine($"耗时：\t{sw.Elapsed.TotalMilliseconds}ms");

            sw.Restart();
            string s3 = QuickSort.Sort(test).Array2String();

            Console.WriteLine($"快速排序结果：\t{s3}");
            sw.Stop();
            Console.WriteLine($"耗时：\t{sw.Elapsed.TotalMilliseconds}ms");

            if (s1 == s2 && s2 == s3)
                Console.WriteLine("所有排序算法结果相同！");


            Console.ReadKey();
        }
    }
}

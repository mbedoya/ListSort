using ListSort.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListSort.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int listSize = 20000;
            Console.WriteLine("Please wait, we are generating the numbers...");
            List<int> list = GenerateList(listSize);
            ProcessSort(list, new BubbleSort());

            Console.WriteLine("Please wait, we are generating the numbers (again)...");
            list = GenerateList(listSize);
            ProcessSort(list, new SelectionSort());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ProcessSort(List<int> list, Sorter sorter)
        {
            Console.WriteLine("Sorting...");
            StopWatch watch = StopWatch.StartNew();
            list = sorter.Sort(list);
            double ms = watch.ElapsedMilliseconds();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0, 5}", list[i]);
            }
            Console.WriteLine("{0, -10} {1, 10:N} seconds", sorter.GetType().Name, ms/1000.0);
        }

        private static List<int> GenerateList(int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(new Random().Next(size * 10) + i);
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sortering
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Sorting = new Class1();
            List<int> list = new List<int>();
            Random number = new Random();
            for (int i = 0; i < 10000; i++)
            {
                int nr = number.Next(1, 10001);
                list.Add(nr);
            }
            List<int> bubblesort = new List<int>(list);
            List<int> insertionsort = new List<int>(list);
            List<int> mergesort = new List<int>(list);

            double bubbletime = Sorting.Bubblesort(bubblesort);
            Console.WriteLine("Bubbletime = " + bubbletime + " ms");
            double insertiontime = Sorting.Insertionsort(insertionsort);
            Console.WriteLine("Insertiontime = " + insertiontime + " ms");
            double mergetime = Sorting.StopwatchMerge(mergesort);
            Console.WriteLine("Mergetime = " + mergetime + " ms");
        }
    }
}

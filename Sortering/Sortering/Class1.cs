using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sortering
{
    public class Class1
    {
        public double Bubblesort(List<int> bubble)
        {
            Stopwatch Bubblewatch = new Stopwatch();
            Bubblewatch.Start();
            for (int i = 0; i < bubble.Count - 1; i++)
            {
                for (int j = 0; j < bubble.Count - 1; j++) 
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        int x = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = x;
                    }
                }
            }
            Bubblewatch.Stop();
            return Bubblewatch.ElapsedMilliseconds;
        }
        public double Insertionsort(List<int> insertion)
        {
            Stopwatch Insertionwatch = new Stopwatch();
            Insertionwatch.Start();
            for (int i = 1; i < insertion.Count; i++)
            {
                int j = i;
                while (j > 0 && insertion[j - 1] > insertion[j])
                {
                    int x = insertion[j];
                    insertion[j] = insertion[j - 1];
                    insertion[j - 1] = x;
                    j--;
                }
            }
            Insertionwatch.Stop();
            return Insertionwatch.ElapsedMilliseconds;
        }
        public double StopwatchMerge(List<int> merge)
        {
            Stopwatch Mergewatch = new Stopwatch();
            Mergewatch.Start();
            List<int> Sorted = Mergesort(merge);
            Mergewatch.Stop();
            return Mergewatch.ElapsedMilliseconds;
        }
        private List<int> Mergesort(List<int> merge)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            if (merge.Count <= 1)
            {
                return merge;
            }

            int x = merge.Count / 2;
            left = merge.GetRange(0, x);
            right = merge.GetRange(x, merge.Count - x);
            left = Mergesort(left);
            right = Mergesort(right);
            return Merge(left, right);
        }
        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left = left.GetRange(1, left.Count - 1);
                }
                else
                {
                    result.Add(right[0]);
                    right = right.GetRange(1, right.Count - 1);
                }
            }
            if (left.Count > 0)
            {
                result.AddRange(left);
            }
            else
            {
                result.AddRange(right);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;

namespace DP3_Comportamental_09_Strategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSort list ");
        }
    }
}
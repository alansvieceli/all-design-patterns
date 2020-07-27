using System;
using System.Collections.Generic;

namespace DP3_Comportamental_09_Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSort list ");
        }
    }
}
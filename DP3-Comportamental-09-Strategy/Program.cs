using System;

namespace DP3_Comportamental_09_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("Teste01");
            sl.Add("Teste02");
            sl.Add("Teste03");
            sl.Add("Teste04");
            sl.Add("Teste05");
            sl.Add("Teste06");
            
            sl.SetSortStrategy(new QuickSort());
            sl.Sort();
            
            sl.SetSortStrategy(new ShellSort());
            sl.Sort();
            
            sl.SetSortStrategy(new MergeSort());
            sl.Sort();
            
            sl.SetSortStrategy(new QuickSort());
            sl.Sort();
            
        }
    }
}
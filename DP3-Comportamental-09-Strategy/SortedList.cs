using System;
using System.Collections.Generic;

namespace DP3_Comportamental_09_Strategy
{
    public class SortedList
    {
        private List<String> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy ss)
        {
            this._sortStrategy = ss;
        }

        public void Add(string nome)
        {
            this._list.Add(nome);
        }

        public void Sort()
        {
            this._sortStrategy.Sort(this._list);
            
            foreach (var nome in this._list)
            {
                Console.WriteLine(" " + nome); 
            }
            
            Console.WriteLine();
            
        }
    }
}
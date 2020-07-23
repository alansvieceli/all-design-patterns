using System.Collections;

namespace DP3_Comportamental_04_Interator
{
    public class Aggregate : IAggregate
    {
        
        private ArrayList _items = new ArrayList();
        
        public IIterator CreateIterator()
        {
            return new Interator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value);}
        }
    }
}
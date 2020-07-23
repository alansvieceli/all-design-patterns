namespace DP3_Comportamental_04_Interator
{
    public class Interator : IIterator
    {

        public Interator(Aggregate aggregate)
        {
            this._aggregate = aggregate;

        }
        
        private Aggregate _aggregate;
        private int _current = 0;
        
        public object First()
        {
            return _aggregate[0];
        }

        public object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }
            return ret;
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public object CurrentItem()
        {
            return _aggregate[_current];
        }
    }
}
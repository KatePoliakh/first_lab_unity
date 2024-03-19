using System;

namespace _Source.Core
{
    public class ObservableInt
    {
        private int _value;
        public event Action<int> ValueChanged;

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    ValueChanged?.Invoke(_value);
                }
            }
        }
    }
}
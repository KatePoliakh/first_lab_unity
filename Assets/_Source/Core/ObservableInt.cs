using System;

namespace _Source.Core
{
    public class ObservableInt
    {
        private int _value;
        public Action<int> OnValueChanged ;
        
        public ObservableInt(int value )
        {
            _value = value;
        }

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    OnValueChanged?.Invoke(_value);
                    _value = value;
                }
            }
        }

        
    }
}
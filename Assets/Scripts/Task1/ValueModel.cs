using System;

namespace GyreRigTask.Task1
{
    public class ValueModel
    {
        public event Action<int> onChangeValue;

        private int _value = 0;

        public int Value
        {
            get{return _value;}
            set
            {
                _value = value;
                onChangeValue(_value);
            }
        }
    }
}


using System;

namespace Assets._Project.Scripts.MVVM
{
    public class ReactiveProperty<T>
    {
        private T _value;
        
        public Action<T> OnChanged;

        public T Value
        {
            get=>_value;
            set
            {
                _value = value;
                OnChanged?.Invoke(_value);
            }
        }    
    }
}

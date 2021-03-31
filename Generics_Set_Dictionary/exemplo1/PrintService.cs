using System;

namespace exemplo1
{
    public class PrintService<T>
    {
        private T[] _value = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("O vetor está cheio");
            }
            _value[_count] = value;
            _count++;
        }

        public T First()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Não há números");
            }
            return _value[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_value[i] + ", ");
            }
            if(_count > 0)
            {
                Console.WriteLine(_value[_count - 1] + "]");
            }
        }
    }
}
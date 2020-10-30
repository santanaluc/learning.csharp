using System;

namespace Generics1
{
    class PrintService<T>
    {
        //object nao tem type safety
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("Is full");
            }

            _values[_count] = value;
            _count++;//atualiza o valor da variável count
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if (_count > 0)
            {
                Console.Write(_values[_count -1]);
            }
            Console.WriteLine("]");
        }
    }
}

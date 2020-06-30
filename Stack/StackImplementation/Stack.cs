using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    internal sealed class Stack<T> : IStack<T>, IEnumerable<T>
    {
        private readonly int _size;
        private T[] _array;
        private int _head;
        private const int _defaulSize = 10;

        public Stack()
        {
            _array = new T[_defaulSize];
        }

        public Stack(int size)
        {
            _size = size;
            _head = 0;
            _array = new T[size];
        }

        public int Top => _head;

        public int Size => _size;

        public int Count => _head;

        public bool IsEmpty => _head == 0;

        public bool IsFull => _head == _size;

        public T Peek => _array[_head - 1];

        [Obsolete("Нет проверки на IsEmpty")]
        public T pop => _array[--_head];

        public void Push(T element)
        {
            if (IsFull)
                throw new InvalidOperationException("Stack Overflow");

            /////////////////
            if (_head == _array.Length)
                Resize(_array.Length + 10);
            ////////////////

            _array[_head] = element;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            T array = _array[--_head];

            _array[_head] = default;

            ////////////
            if(-Count > 0 && _head < _array.Length - 10)
                Resize(_array.Length - 10);
            ////////////

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек не заполнен.");

            for (int i = _head; i > 0; i--)
            {
                yield return _array[i - 1];
            }
        }

        private void Resize(int max)
        {
            T[] tempItem = new T[max];

            for (int i = 0; i < _head; i++)
            {
                tempItem[i] = _array[i];
            }

            _array = tempItem;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

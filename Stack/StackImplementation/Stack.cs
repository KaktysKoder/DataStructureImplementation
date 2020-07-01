using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    internal sealed class Stack<T> : IStack<T>, IValidation, IPrivateStack, IEnumerable<T>
    {
        private readonly int _size;
        private readonly T[] _array;
        private int          _head;

        public Stack(int size)
        {
            _size  = size;
            _head  = 0;
            _array = new T[size];
        }

        public int Top   { get => _head; }
        public int Size  { get => _size; }
        public int Count { get => _head; }

        public bool IsEmpty => _head == 0;
        public bool IsFull  => _head == _size;

        public T Peek => _array[_head - 1];

        public void Push(T element)
        {
            if (IsFull)
                throw new InvalidOperationException("Stack Overflow");

            _array[_head++] = element;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            T array = _array[--_head];

            _array[_head] = default;

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек не заполнен.");

            for (int i = _head; i > 0; i--)
            {
                yield return _array[i - 1];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

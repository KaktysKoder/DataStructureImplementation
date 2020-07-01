using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    internal sealed class Stack<T> : IEnumerable<T>
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

        //Маркер верхнего элемента стека
        public int Top { get => _head; }

        //Размер стека
        public int Size { get => _size; }

        //Количество элементов стека
        public int Count { get => _head; }

        //Проверить пустой ли стек
        public bool IsEmpty => _head == 0;

        //Проверить заполнен ли стек
        public bool IsFull => _head == _size;

        //Вернуть верхний элемент
        public T Peek => _array[_head - 1];

        //Добавляем элемент в стек
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
            if (IsEmpty) throw new InvalidOperationException("Стек не заполнен.");

            for (int i = _head; i > 0; i--)
            {
                yield return _array[i - 1];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

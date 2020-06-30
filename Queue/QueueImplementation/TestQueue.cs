using System.Collections;
using System.Collections.Generic;

namespace QueueImplementation
{
    /// <summary>
    /// Моя реализация кучи на основе изученных ранее структур данных.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class TestQueue<T> : IQueue<T>, IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Count    { get; private set;  }
        public bool IsEmpty { get => Count == 0; }

        public T Front => _head.Data;
        public T Back  => _tail.Data;

        public void Push(T addsElement)
        {
            Node<T> node = new Node<T>(addsElement);

            if (IsEmpty)
            {
                _head = _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail      = node;
            }

            Count++;
        }

        public T Pop()
        {
            T value = _head.Data;

            if (_head == _tail)
            {
                _head = _tail = null;
            }
            else { _head = _head.Next; }

            Count--;

            return value;
        }

        public void Foreach(TestQueue<T> instance)
        {
            foreach (var item in instance)
            {
                System.Console.WriteLine(instance.Pop());
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

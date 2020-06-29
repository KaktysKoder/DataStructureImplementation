namespace LinkedListImplementation
{
    internal sealed class LinkedList<T> : IContractList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        private int _count;

        public int Count { get => _count; }
        public bool IsEmpty { get => _count == 0; }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _head.Next = node;
            }

            _tail = node;

            _count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную _tail
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение _head
                        _head = _head.Next;

                        // если после удаления список пуст, сбрасываем _tail
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    _count--;
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);

            node.Next = _head;

            _head = node;

            if(IsEmpty)
            {
                _count++;
            }
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = _head;

            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
    }
}

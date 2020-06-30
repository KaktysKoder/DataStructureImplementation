using System.Collections.Generic;

namespace QueueImplementation
{
    internal class TestQueue<T>
    {
        //Указатель на голову очереди
        private LinkedListNode<T> _head;

        //Указатель на хвост очереди
        private LinkedListNode<T> _tail;

        private int _count;

        public int Count { get => _count; }

        public bool IsEmpty { get => Count == 0; }

        public TestQueue()
        {

        }

        //Добавлние элемента в конец очереди
        public void Push(T addsElement)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(addsElement);

            //кастыль
            //var nextTail = _tail.Next;

            if(IsEmpty)
            {
                //И голова и хвост указывают на 1 элемент
                _head = _tail = node;
            }
            else
            {
                // Исправить эту ошибку _tail.Next = node;
                //_ = _tail.Next;
   
                _tail.Next = node;
                _tail = node;
            }

            _count++;
        }

        /// <summary>
        /// Извлечение элемента из очереди
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T value = _head.Value;

            //Если оччередь из 1 эл
            if(_head == _tail)
            {
                _head = _tail = null;
            }
            else
            {
                _head = _head.Next;
            }

            _count--;

            return value;
        }


        //Возврат эл из очереди без его извлечения
        public T Front()
        {
            return _head.Value;
        }


        //Получ посл эл из очередт
        public T Back()
        {
            return _tail.Value;
        }
        
    }
}

namespace QueueImplementation
{
    internal interface IQueue<T>
    {
        int Count    { get; }

        bool IsEmpty { get; }

        /// <summary>
        /// Добавлние элемента в конец очереди
        /// </summary>
        /// <param name="addsElement">Элемент</param>
        void Push(T addsElement);

        /// <summary>
        /// Извлечение элемента из очереди
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// Возврат элемента из очереди без его извлечения
        /// </summary>
        /// <returns></returns>
        T Front { get; }

        /// <summary>
        /// Получить последний элемент из очереди
        /// </summary>
        /// <returns></returns>
        T Back  { get; }

        /// <summary>
        /// Это инкапсулированный итератор
        /// </summary>
        /// <param name="instance"></param>
        void Foreach(TestQueue<T> instance);
    }
}
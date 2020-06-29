namespace LinkedListImplementation
{
    internal interface IContractList<T>
    {
        /// <summary>
        /// Добавление элемента в список.
        /// </summary>
        /// <param name="data">Элемент</param>
        void Add(T data);

        /// <summary>
        /// Удаление элемента из списка.
        /// </summary>
        /// <param name="data">Элемент</param>
        /// <returns>Элемент</returns>
        bool Remove(T data);

        /// <summary>
        /// Получить кол-во элементов списка.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Пустой ли элемент
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Очистка списка.
        /// </summary>
        void Clear();

        /// <summary>
        /// Содержит ли список элемент.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Элемент</returns>
        bool Contains(T data);

        /// <summary>
        /// Добавить в начало.
        /// </summary>
        /// <param name="data">Элемент</param>
        void AppendFirst(T data);
    }
}

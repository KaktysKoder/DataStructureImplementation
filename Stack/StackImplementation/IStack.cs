namespace StackImplementation
{
    interface IStack<T>
    {
        /// <summary>
        /// Маркер верхнего элемента стека
        /// </summary>
        int Top { get; }

        /// <summary>
        /// Размер стека
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Количество элементов стека
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Проверить заполнен ли стек
        /// </summary>
        /// <returns></returns>
        bool IsFull { get; }

        /// <summary>
        /// Проверить пустой ли стек
        /// </summary>
        /// <returns></returns>
        bool IsEmpty { get; }

        /// <summary>
        /// Добавляем элемент в стек
        /// </summary>
        /// <param name="element">Элемент</param>
        void Push(T element);

        /// <summary>
        /// Вернуть верхний элемент
        /// </summary>
        /// <returns>Элемент</returns>

        T Peek { get; }
        /// <summary>
        /// Считывание из стека верхнего элемента
        /// </summary>
        /// <returns>Элемент</returns>

        T Pop();
        /// <summary>
        /// Считывание из стека верхнего элемента
        /// </summary>
        /// <returns>Элемент</returns>

        /// <summary>
        /// Считывание из стека верхнего элемента
        /// </summary>
        T pop { get; }
    }
}

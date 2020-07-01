namespace StackImplementation
{
    /// <summary>
    /// || en - The main functions of the stack.
    /// || ru - Основные функции стека.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IStack<T>
    {
        /// <summary>
        /// || en - Add an element to the stack.
        /// || ru - Добавляем элемент в стек.
        /// </summary>
        /// <param name="element"></param>
        void Push(T element);

        /// <summary>
        /// || en - Reading the top element from the stack.
        /// || ru - Считывание из стека верхнего элемента.
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// || en - Return top item.
        /// || ru - Вернуть верхний элемент.
        /// </summary>
        T Peek { get; }
    }
}

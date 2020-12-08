namespace StackImplementation
{
    /// <summary>
    /// || en - encapsulation of the main variables of the stack.   
    /// || ru - инкапсуляция основных переменных стека.
    /// </summary>
    internal interface IPrivateStack
    {
        /// <summary>
        /// || en - Stack size.
        /// || ru - Размер стека.
        /// </summary>
        int Size { get; }

        /// <summary>
        /// || en - Stack Element top Marker.
        /// || ru - Маркер верхнего элемента стека.
        /// </summary>
        int Top { get; }

        /// <summary>
        /// || en - Number of Stack Elements.
        /// || ru - Количество элементов стека.
        /// </summary>
        int Count { get; }
    }
}

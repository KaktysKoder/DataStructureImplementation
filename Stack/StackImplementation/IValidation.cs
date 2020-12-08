namespace StackImplementation
{
    /// <summary>
    /// || en - value validation.
    /// || ru - проверка значения.
    /// </summary>
    internal interface IValidation
    {
        /// <summary>
        /// || en - Check if the stack is empty.
        /// || ru - Проверить пустой ли стек.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// || en - Check if the stack is full.
        /// || ru - Проверить заполнен ли стек.
        /// </summary>
        bool IsFull { get; }
    }
}

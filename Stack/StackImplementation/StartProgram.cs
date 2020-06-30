using System;

namespace StackImplementation
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            TestStack1();

        }

        private static void TestStack1()
        {
            try
            {
                Stack<string> stack = new Stack<string>();

                stack.Push("Shild");
                stack.Push("CODEBLOG");
                stack.Push("Vasya");
                stack.Push("Jojo");

                string head = stack.Pop();
                Console.WriteLine(head);

                // просто получаем верхушку стека без извлечения
                head = stack.Peek;

                Console.WriteLine(head);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
                Console.WriteLine(exc.TargetSite);
            }
        }
    }
}

using System;

namespace StackImplementation
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            Test2();

        }

        private static void TestStack1()
        {
            try
            {
                Stack<string> stack = new Stack<string>(8);

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

        private static void Test2()
        {
            try
            {
                Console.Title = "Custom simple Stack in native C#";

                Stack<string> s = new Stack<string>(5);
                Console.WriteLine("Добавляем на склад коробки: 1, 2, 3...");
                s.Push("первая коробка");
                s.Push("вторая коробка");
                s.Push("третья коробка");
                Console.WriteLine("Всего коробок: " + s.Count.ToString());
                Console.WriteLine();

                Console.WriteLine("Достаём крайнюю коробку: " + s.Pop());
                Console.WriteLine("Достаём крайнюю коробку: " + s.Pop());
                Console.WriteLine("Узнать какая коробка осталась: " + s.Peek);
                Console.WriteLine("Всего коробок: " + s.Count.ToString());
                Console.WriteLine();

                Console.WriteLine("Добавим ещё коробки: 4, 5...");
                s.Push("четвертая коробка");
                s.Push("пятая коробка");
                Console.WriteLine("Всего коробок: " + s.Count.ToString());
                Console.WriteLine();

                Console.WriteLine("Переберём оставшиеся коробки на складе:");
                foreach (string box in s)
                {
                    Console.WriteLine('-' + box);
                }
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

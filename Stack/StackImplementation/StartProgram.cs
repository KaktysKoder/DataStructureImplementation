using System;

namespace StackImplementation
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            Test2();
        }

        private static void Test2()
        {
            try
            {
                Console.Title = "Custom simple Stack in native C#";

                Stack<string> stack = new Stack<string>(5);

                Console.WriteLine("Добавляем на склад коробки: 1, 2, 3...");

                stack.Push("первая коробка");
                stack.Push("вторая коробка");
                stack.Push("третья коробка");

                Console.WriteLine($"Всего коробок: {stack.Count}");
                Console.WriteLine();

                Console.WriteLine($"Достаём крайнюю коробку:       {stack.Pop()}");
                Console.WriteLine($"Достаём крайнюю коробку:       {stack.Pop()}");
                Console.WriteLine($"Узнать какая коробка осталась: {stack.Peek} ");
                Console.WriteLine($"Всего коробок:                 {stack.Count}");
                Console.WriteLine();

                Console.WriteLine("Добавим ещё коробки: 4, 5...");

                stack.Push("четвертая коробка");
                stack.Push("пятая коробка");

                Console.WriteLine($"Всего коробок: {stack.Count}");
                Console.WriteLine();

                Console.WriteLine("Переберём оставшиеся коробки на складе:");

                foreach (string box in stack)
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

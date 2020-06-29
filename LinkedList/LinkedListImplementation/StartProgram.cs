using System;

namespace LinkedListImplementation
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            TestList();

            Console.ReadLine();
        }

        //Testing Class Linced List
        private static void TestList()
        {
            LinkedList<string> linkedList = new LinkedList<string>
            {
                "Shild",
                "Gabe ",
                "Vasya",
                "Helen"
            };

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            linkedList.Remove("Gabe");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Helen");

            Console.WriteLine(isPresent == true ? "Helen присутствует" : "Helen отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("Vasya");
        }
    }
}

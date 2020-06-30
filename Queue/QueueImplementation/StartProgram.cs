//Очередь и её реализация с помощью односвязных списков

using System;

namespace QueueImplementation
{
    internal class StartProgram
    {
        private static void Main()
        {
            TestQueue();
        }
        private static void TestQueue()
        {
            TestQueue<int> queue = new TestQueue<int>();

            queue.Push(10);
            queue.Push(12);
            queue.Push(15);

            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            

            queue.Push(25);
            queue.Push(30);


            Console.WriteLine(queue.Pop());



        }

    }
}

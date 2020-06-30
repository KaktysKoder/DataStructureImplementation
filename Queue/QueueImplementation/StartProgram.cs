using System;

namespace QueueImplementation
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            TestQueue();
        }

        private static void TestQueue()
        {
            TestQueue<int> queue = new TestQueue<int>();

            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);
            queue.Push(6);
            queue.Push(7);
            queue.Push(8);
            queue.Push(9);

            queue.Foreach(queue);

            Console.WriteLine();

            queue.Push(20);
            queue.Push(30);
            queue.Push(40);
            queue.Push(50);
            queue.Push(60);
            queue.Push(70);
            queue.Push(80);
            queue.Push(90);

            queue.Foreach(queue);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(8);
            stack.Push(15);
            stack.Pop();
            stack.Push(12);
            Console.WriteLine("Stack");
            foreach (int my in stack)
            {       
                Console.WriteLine(my);
            }
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(16);
            list.Add(10);
            list.Add(8);
            list.RemoveAt(2);
            Console.WriteLine("List");
            foreach (int my in list)
            {
                Console.WriteLine(my);
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(1);
            queue.Dequeue();
            queue.Enqueue(7);
            Console.WriteLine("Queue");
            foreach (int my in queue)
            {
                Console.WriteLine(my);
            }

        }
    }
}

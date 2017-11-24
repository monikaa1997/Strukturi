using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak
{
    class QueueA
    {
        public int value;
        QueueA previous;
        QueueA next;
    
    public class Queue
    {
        QueueA head;
        QueueA tail;

        public void Enqueue(int v)
        {

                if (head == null)
                {
                    head = tail = new QueueA()
                    {
                        value = v
                    };
                }
                else if (head == tail)
                {
                    tail = new QueueA()
                    {
                        value = v,
                        previous = tail
                    };
                    tail.previous.next = tail;
                }
            }
        }
    }
}

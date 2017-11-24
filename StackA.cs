using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak
{
    class StackA
    {
        public Stack<int> stack = new Stack<int>();

        public void Push(int value)
        {
            stack.Push(value);
        }
        public void Pop(int value)
        {
            stack.Pop();
        }
    }
}

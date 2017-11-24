using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak
{
    class ListA
    {
        List<int> list = new List<int>();
       
        public void Push(int value)
        {
            list.Add(value);
        }
        public int Pop(int value)
        {
            int mash = list[0];
            this.list.RemoveAt(0);
            return mash;
        }
    }
}

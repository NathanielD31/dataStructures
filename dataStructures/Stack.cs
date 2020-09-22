using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructures
{
    class Stack
    {
        int[] stack;
        int sp;
        int max;

        public Stack(int size)
        {
            max = size;
            stack = new int[max];
            sp = 0;
        }

        public void Push(int item)
        {
            if (sp < max)
            {
                stack[sp] = item;
                sp++;
            }
            throw new Exception("Stack full dickhead");
        }

        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp];
            }
            
            
            throw new Exception("Stack empty you retard");
            
        }
    }
}

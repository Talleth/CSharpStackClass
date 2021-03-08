using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StackClass stackClass = new StackClass();

            stackClass.Push(1000);
            stackClass.Push(2000);
            stackClass.Push(3000);
            stackClass.Push(4000);

            Console.WriteLine("Stack Size - " + stackClass.Size);
            Console.WriteLine();
            Console.WriteLine("Printing stack \"Last in First Out\"");
            Console.WriteLine();

            while (stackClass.Size != 0)
                Console.WriteLine(stackClass.Pop());
        }
    }

    public class StackClass
    {
        private int             m_size;
        private LinkedList<int> m_stack;

        public StackClass()
        {
            this.m_size     = 0;
            this.m_stack    = new LinkedList<int>();
        }

        public void Push(int data)
        {
            this.m_size++;

            this.m_stack.AddFirst(data);
        }

        public int Pop()
        {
            int result = 0;

            if (this.m_stack.First != null)
                result = this.m_stack.First.Value;

            this.m_size--;
            this.m_stack.RemoveFirst();

            return result;
        }

        public int Size
        {
            get { return this.m_size; }
        }
    }
}

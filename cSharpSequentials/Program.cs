using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSequentials
{
    class Program
    {
        static void Main(string[] args)
        {
            var justAQueue = new Queue<string>();
            justAQueue.Enqueue("First");
            justAQueue.Enqueue("Second");
            justAQueue.Enqueue("Third");
            justAQueue.Enqueue("Forth");
            
            while (justAQueue.Count > 0)
            {
                justAQueue.Peek();
                Console.WriteLine(justAQueue.Peek());
                justAQueue.Dequeue();
            }

            

            Console.ReadLine();
        }
    }
}

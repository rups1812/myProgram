using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class DemoLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddFirst(300);
            ll.AddFirst(50);

            LinkedListNode<int> n1 = ll.Find(100);
            ll.AddAfter(n1, 150);
            ll.AddBefore(n1, 90);

            ll.Remove(150);


            foreach (int data in ll)
            {
                Console.WriteLine(data);
            }

        }
    }


}
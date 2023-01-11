using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProgram
{
    public class LinkedList
    {
        Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head= node;
            }
            else
            {
                Node temp = new Node(data);
               
                temp.next = head;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linkedlist",node.data);
        }
        public void Display()
        {
            Node temp=head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
                if (temp != null)
                {
                    Console.Write("->");
                }
            }
        }

    }
}

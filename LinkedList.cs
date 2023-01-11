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
                Node temp = head;
               while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;                
            }
            Console.WriteLine("{0} inserted into linkedlist",node.data);
        }
       public  Node InsertAtPerticularPosition(int position,int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if(position == 1) 
            {
                var newNode = new Node(data);
                newNode.next = head;
                head= newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position ==1)
                    {
                        Node node=new Node(data);
                        node.next = head.next;
                        head.next= node;
                        break;
                    }
                    head= head.next;
                }
               
            }
            Console.WriteLine("\nInserted value is : "+data);
            return head;

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

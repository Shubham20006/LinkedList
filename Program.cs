using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class Program
    {
         public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine();
            list.InsertAtPerticularPosition(2,40);
            list.Display();
            Console.WriteLine();

            //list.poplast();
            //list.Display();

            list.MsTest(30);
            list.Display();
            Console.ReadLine();
        }
    }
}

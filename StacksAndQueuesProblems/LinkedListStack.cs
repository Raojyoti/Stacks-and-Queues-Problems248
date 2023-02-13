using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesProblems
{
    public class LinkedListStack
    {
        Node top;
        Node temp;
        public void CreateStack()
        {
            Console.WriteLine("Enter number of node wanted to inserted");
            int node=Convert.ToInt32(Console.ReadLine());
            if(node==0)
            {
                return;
            }
            for(int i=1; i<=node; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                int data=Convert.ToInt32(Console.ReadLine());
                Push(data);
            }
        }
        public void Push( int data)
        {
            Node newNode = new Node(data);
            if (top==null)
            {
                //Console.WriteLine("{0} is push into stack",data);
                top = newNode;
                return;
            }
            temp = top;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            //Console.WriteLine("{0} is push into stack", data);
        }
        public void DisplayStackList()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Node temp = top;
                Console.WriteLine("Element Present in Stack\n--------------------------");
                while (temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
            }
        }
    }
}

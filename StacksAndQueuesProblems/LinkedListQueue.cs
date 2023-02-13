using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesProblems
{
    public class LinkedListQueue
    {
        Node head;
        public void CreateQueue()
        {
            Console.WriteLine("Enter number of node wanted to inserted");
            int node = Convert.ToInt32(Console.ReadLine());
            if (node == 0)
            {
                return;
            }
            for (int i = 1; i <= node; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                int data = Convert.ToInt32(Console.ReadLine());
                Enqueue(data);
            }
        }
        public void Enqueue(int data)
        {
            Node newNode=new Node(data);
            if(head==null)
            {
                //Console.WriteLine("{0} is enqueue into queue", newNode.data);
                head = newNode;
                return;
            }
            else
            {
                Node temp=head;
                while(temp.next!=null)
                {
                    temp=temp.next;
                }
                temp.next=newNode;
                //Console.WriteLine("{0} is enqueue into queue", newNode.data);
            }
        }
        public void TopElementInQueue()
        {
            if(head==null)
            {
                Console.WriteLine("Here Queue is empty so no element present in top");
                return;
            }
            Console.WriteLine("{0} is topmost element in queue", head.data);
        }
        public void DisplayQueueList()
        {
            if(head==null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                Node temp=head;
                Console.WriteLine("Element Present in Queue List\n--------------------------");
                while (temp!=null)
                {
                    Console.Write(temp.data + "  ");
                    temp=temp.next;
                }
            }
        }
    }
}

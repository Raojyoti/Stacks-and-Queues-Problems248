﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack listStack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            Console.WriteLine("Welcome to the Stack and Queues Problems");
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.WriteLine("Please choose any options");
                Console.WriteLine("1.CreateStack\n" +
                    "2.Push element into stack\n" +
                    "3.Display stack list\n" +
                    "4.Pop element from stack\n" +
                    "5.Top element in stack\n" +
                    "6.Check stack is empty or not\n" +
                    "7.Create Queue\n" +
                    "8.Enqueue element into queue\n" +
                    "9.Display queue list\n" +
                    "10.Top element in queue\n" +
                    "11.Deqnqueue element from queue\n" +
                    "12.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        listStack.CreateStack();
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter the element to be push into stack: ");
                        int data = Convert.ToInt32(Console.ReadLine());
                        listStack.Push(data);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        listStack.DisplayStackList();
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        listStack.Pop();
                        Console.WriteLine("Element is deleted successfully....\n");
                        Console.WriteLine("After deletions if you want to see how many elements present in Stacklist \n\nSo first Press any key to continue...\n\nAnd then select option 3 ");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        listStack.Peek();
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        listStack.IsEmpty();
                        Console.Write("Is stack is empty? : {0}", listStack.IsEmpty());
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        queue.CreateQueue();
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.Clear();
                        Console.Write("Enter the element to be enqueue into queue: ");
                        int data1 = Convert.ToInt32(Console.ReadLine());
                        queue.Enqueue(data1);
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.Clear();
                        queue.DisplayQueueList();
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.Clear();
                        queue.TopElementInQueue();
                        Console.Write("\nPress any key to continue...... ");
                        Console.ReadLine();
                        break;
                    case 11:
                        Console.Clear();
                        queue.DequeueElement();
                        Console.WriteLine("Element is deleted successfully....\n");
                        Console.WriteLine("After deletions if you want to see how many elements present in Queuelist \n\nSo first Press any key to continue...\n\nAnd then select option 9 ");
                        Console.ReadLine();
                        break;
                    case 12:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only valid options");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

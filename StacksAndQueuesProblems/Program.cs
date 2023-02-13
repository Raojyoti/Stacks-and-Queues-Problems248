using System;
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
            Console.WriteLine("Welcome to the Stack and Queues Problems");
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.WriteLine("Please choose any options");
                Console.WriteLine("1.CreateStack\n2.Push element into stack\n3.Display stack list\n10.Exit\n");
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
                    case 10:
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

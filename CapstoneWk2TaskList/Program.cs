using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneWk2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaskManager> taskList = new List<TaskManager> { };
            taskList.Add(new TaskManager("Bob", "clean", DateTime.Parse("05/15/2018")));
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\nMain Menu \n1. List Tasks \n2. Add Task \n3. Delete Task \n4. Mark Task Complete \n5. Quit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    foreach (TaskManager element in taskList)
                    {
                        Console.Clear();
                        element.PrintInfo();
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter description: ");
                    string d = Console.ReadLine();
                    Console.WriteLine("Enter Due Date: ");
                   
                    DateTime due = DateTime.Parse(Console.ReadLine());
                    taskList.Add(new TaskManager(n, d, due));

                }
                else if (choice == "3")
                {
                    foreach (TaskManager elements in taskList)
                    {
                        elements.PrintInfo();
                    }
                    Console.Clear();
                    Console.WriteLine($"Which task number would you like to remove?");
                    int index = int.Parse(Console.ReadLine());
                    taskList.RemoveAt(index - 1);
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine($"Which task number would you like to mark as complete?");
                    foreach (TaskManager elements in taskList)
                    {
                        elements.PrintInfo();
                    }
                    int index = int.Parse(Console.ReadLine());
                    taskList[index - 1].Complete = true;
                }
                else if (choice == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Are you sure? y/n");
                    string doublecheck = Console.ReadLine();
                    {
                        if (doublecheck.ToLower() == "y" || doublecheck.ToLower() == "yes")
                        {
                            Console.WriteLine("Goodbye");
                            repeat = false;
                        }
                        else
                        {
                            repeat = true;
                        }
                    }
                }


            }
            
        }
    }
}
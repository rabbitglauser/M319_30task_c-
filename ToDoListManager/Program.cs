using System;
using System.Collections.Generic;

class Task
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return IsCompleted ? $"[X] {Description}" : $"[ ] {Description}";
    }
}

class ToDoList
{
    private List<Task> tasks;

    public ToDoList()
    {
        tasks = new List<Task>();
    }

    public void AddTask(string description)
    {
        tasks.Add(new Task(description));
        Console.WriteLine($"Task \"{description}\" added.");
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            string description = tasks[index].Description;
            tasks.RemoveAt(index);
            Console.WriteLine($"Task \"{description}\" removed.");
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    public void MarkTaskAsComplete(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].IsCompleted = true;
            Console.WriteLine($"Task \"{tasks[index].Description}\" marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    public void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to display.");
        }
        else
        {
            Console.WriteLine("Current tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ToDoList toDoList = new ToDoList();
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. Mark Task as Complete");
            Console.WriteLine("4. Display Tasks");
            Console.WriteLine("5. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();
                    toDoList.AddTask(description);
                    break;
                case 2:
                    Console.Write("Enter task index to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int removeIndex))
                    {
                        toDoList.RemoveTask(removeIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;
                case 3:
                    Console.Write("Enter task index to mark as complete: ");
                    if (int.TryParse(Console.ReadLine(), out int completeIndex))
                    {
                        toDoList.MarkTaskAsComplete(completeIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;
                case 4:
                    toDoList.DisplayTasks();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
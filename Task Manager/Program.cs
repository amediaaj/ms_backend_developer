class TaskManager{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. View Tasks");
            Console.Write("4. Exit");
            string choice = Console.ReadLine() ?? string.Empty;

            switch(choice){
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter Task Description");
        string task = Console.ReadLine();
        tasks.Add(task);
        taskStatus.Add(false);
        Console.WriteLine("Task Added Successfully");
    }

    static void CompleteTask()
    {
        if(tasks.Count == 0){
            Console.WriteLine("No Tasks Available to Complete\n");
            return;
        }
        Console.WriteLine("Enter Task Number to Mark as Completed");
        if(int.TryParse(Console.ReadLine(), out int taskNumber) 
            && taskNumber > 0 
            && taskNumber <= tasks.Count)
        {
            taskStatus[taskNumber - 1] = true;
            Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as Completed\n");
        }
        else
        {
            Console.WriteLine("Invalid Task Number\n");    
        }
    }

    static void ViewTasks()
    {
        if(tasks.Count == 0){
            Console.WriteLine("No Tasks Available\n");
            return;
        }
        Console.WriteLine("Tasks");
        for(int i = 0; i < tasks.Count; i++){
            Console.WriteLine($"{i + 1}. {tasks[i]} - {(taskStatus[i] ? "Completed" : "Pending")}");
        }
        Console.WriteLine();
    }
}
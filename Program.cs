var taskManager = new TaskManager();
int command;
while (true){
    Console.WriteLine("Commands :");
    Console.WriteLine("1.Show all Tasks.");
    Console.WriteLine("2.Add a new task");
    Console.WriteLine("3.Find a task (by id)");
    Console.WriteLine("4.Update task");
    Console.WriteLine("5.Delete task");
    Console.WriteLine("6.Get information about tasks");
    Console.WriteLine("7.Get completed tasks");
    Console.WriteLine("8.Get not completed tasks");
    Console.WriteLine("9.Get sort tasks");
    Console.WriteLine("10.Get tasks by priority");
    Console.WriteLine("11.End");
    Console.WriteLine("-------------------------");
    Console.WriteLine("|Write only command number|");
    Console.WriteLine("-------------------------");
    command = Convert.ToInt32(Console.ReadLine());
    if(command == 1)   
    {
        foreach (var item in taskManager.GetAllTasks())
        {
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Description);
            System.Console.WriteLine(item.Assignee);
            System.Console.WriteLine(item.TaskCategory);
            System.Console.WriteLine(item.CreatedAt);
        }
    }
    else if(command == 2) 
    {
        var task = new Task();
        System.Console.WriteLine("Enter a task id : ");
        task.TaskId = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter a task title : ");
        task.Title = Console.ReadLine();
        System.Console.WriteLine("Enter a task description : ");
        task.Description = Console.ReadLine();   
        System.Console.WriteLine("Enter who must dothis task : ");
        var u = new User();
        u.UserName = Console.ReadLine();
        u.UserId = 1;
        task.Assignee = u;
        var c = new Category();
        c.CategoryId = 1;
        System.Console.WriteLine("Enter a task category name : ");
        c.CategoryName = Console.ReadLine();
        task.TaskCategory = c;
        Console.WriteLine("Enter the new priority of the task (1: Low, 2: Medium, 3: High) : ");
        int priorityInput = Convert.ToInt32(Console.ReadLine());
        Enum.IsDefined(typeof(TaskPriority), priorityInput);
        task.taskPriority = (TaskPriority)priorityInput;
        task.Done = false;
        task.CreatedAt = Convert.ToDateTime(Console.ReadLine());
        taskManager.AddTask(task);
        Console.WriteLine("Task Updated succesfuly!!!");
        Console.WriteLine("---------------------------------------");
    }
    else if (command == 5){
        Console.WriteLine("---------------------------------------");
        Console.Write("Enter a task ID : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------------------");
    }
    else if (command == 6){
        Console.WriteLine("---------------------------------------");
        taskManager.GetInfoAboutTasks();
        Console.WriteLine("---------------------------------------");
    }
    else if (command == 7){
        Console.WriteLine("---------------------------------------");
        foreach (var item in taskManager.GetCompletedTasks())
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Title);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assignee);
            Console.WriteLine(item.taskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }
    else if (command == 8){
        Console.WriteLine("---------------------------------------");
        foreach (var item in taskManager.GetNotCompletedTasks())
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Title);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assignee);
            Console.WriteLine(item.taskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }
    else if (command == 9){
        Console.WriteLine("---------------------------------------");
        foreach (var item in taskManager.GetSortedTasks())
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Title);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assignee);
            Console.WriteLine(item.taskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }
    else if(command == 10){
        Console.WriteLine("---------------------------------------");
        int priorityInput = Convert.ToInt32(Console.ReadLine());
        Enum.IsDefined(typeof(TaskPriority), priorityInput);
        foreach (var item in taskManager.GetTasksByPriority((TaskPriority)priorityInput))
        {
            Console.WriteLine(item.TaskId);
            Console.WriteLine(item.Title);
            Console.WriteLine(item.Description);
            Console.WriteLine(item.Assignee);
            Console.WriteLine(item.taskPriority);
            Console.WriteLine(item.Done);
            Console.WriteLine(item.CreatedAt);
        }
        Console.WriteLine("---------------------------------------");
    }
    else if (command == 11){
        break;
        Console.WriteLine("---------------------------------------");
    }
}

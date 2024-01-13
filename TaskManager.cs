using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class TaskManager
{
    public List<Task> task { get; set; } = new List<Task>();
    public List<User> user { get; set; } = new List<User>();
    public List<Category> categories { get; set; } = new List<Category>();
    public TaskManager(){}
    public TaskManager(List<Task> tasks,List<User> user, List<Category> categories)
    {
        task = tasks;
        this.user = user;
        this.categories = categories;
    }
    public  List<Task> GetAllTasks()
    {
        return task;
    }
    public void AddTask(Task tasked)
    {
        task.Add(tasked);
    }
    public List<Task> GetTaskById  (int id)
    {
        var cnt = task.Where(e => e.TaskId == id).ToList();
        return cnt; 
    }
    public void DeleteTask (int id)
    {
        foreach (var item in task)
        {
            if(item.TaskId == id)
            {
                task.Remove(item);
            }
        }
    }
    public void GetInfoAboutTasks()
    {
        foreach (var item in task)
        {
            System.Console.WriteLine(item.TaskId);
            System.Console.WriteLine(item.Title);
            System.Console.WriteLine(item.Description);
            System.Console.WriteLine(item.Assignee);
            System.Console.WriteLine(item.TaskCategory);
            System.Console.WriteLine(item.taskPriority);
            System.Console.WriteLine(item.Done);
            System.Console.WriteLine(item.CreatedAt);
        }
    }
    public List<Task> GetCompletedTasks()
    {
        var cnt = task.FindAll(e => e.Done == true);
        return cnt;
    }
    public List<Task> GetNotCompletedTasks()
    {
        var cnt = task.FindAll(e => e.Done == false);
        return cnt;
    }
    public List<Category> GetTasksByCategoryId(Category c)
    {       
        var cnt = categories.FindAll(e => e.CategoryId == c.CategoryId);
        return cnt;
    }
    public List<Task> GetSortedTasks(){
            return task.OrderByDescending(e => e.CreatedAt).ToList();
    }
    public List<Task> GetTasksByPriority(TaskPriority t){
        var cnt = task.Where(e => e.taskPriority == t).ToList();
        return cnt;
    }
}
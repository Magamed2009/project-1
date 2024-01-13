public class Task
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User Assignee  { get; set; }
    public Category TaskCategory { get; set; }
    public TaskPriority taskPriority { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; set; }
    public Task() {}
    public Task(int taskId,string title,string description,User assigne,Category taskCategory,DateTime createdAt)
    {
        TaskId = taskId;
        Title = title;
        Description = description;
        Assignee = assigne;
        TaskCategory = taskCategory;
        CreatedAt = createdAt;
    }
}
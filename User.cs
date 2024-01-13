public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public int MyProperty { get; set; }
    public User(int userId,string userName)
    {
        UserId = userId;
        UserName = userName;
    }
    public User() {}
}
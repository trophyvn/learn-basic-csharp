public class UserManager
{
    private readonly Logger _logger;

    public UserManager(Logger logger)
    {
        _logger = logger;
    }

    public void AddUser(string username, string email)
    {
        // Thêm người dùng vào cơ sở dữ liệu
        Console.WriteLine($"User {username}, {email} added");

        // Ghi log sử dụng Logger class
        _logger.Log("User added at " + DateTime.Now);
    }
}
public class UserManager
{
    public void AddUser(string username, string email)
    {
        // Thêm người dùng vào cơ sở dữ liệu
        Console.WriteLine($"User {username}, {email} added");

        // Ghi log
        Console.WriteLine("Log entry: User added at " + DateTime.Now);
    }
}

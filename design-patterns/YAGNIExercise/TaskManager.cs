public class Task
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class TaskManager
{
    public void AddTask(Task task) { /* ... */ }
    public void CompleteTask(int taskId) { /* ... */ }

    // Các phương thức dưới đây chưa cần thiết lúc này
    // Loại bỏ hoặc trì hoãn việc phát triển các tính năng phức tạp và không cần thiết
    // Chỉ tập trung vào những gì người dùng cần ngay bây giờ
}

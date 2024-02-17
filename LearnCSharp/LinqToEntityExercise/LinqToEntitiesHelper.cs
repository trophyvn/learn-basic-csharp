using Microsoft.EntityFrameworkCore;

// Giả định có DbContext và class Student được định nghĩa như sau
public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("SchoolDbInMemory");
    }
}

public class LinqToEntitiesHelper
{
    public void ExcuteCRUD()
    {
        using (var context = new SchoolContext())
        {
            // Thêm mới dữ liệu
            var newStudent = new Student { Name = "Student", Score = 89 };
            context.Students.Add(newStudent);
            context.SaveChanges();

            // Truy vấn dữ liệu
            var highScoreStudents = from student in context.Students
                                    where student.Score > 90
                                    select student;

            foreach (var student in highScoreStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Score}");
            }

            // Cập nhật dữ liệu
            var studentToUpdate = context.Students.FirstOrDefault(s => s.Id == 1);
            if (studentToUpdate != null)
            {
                studentToUpdate.Score = 95;
                context.SaveChanges();
            }

            highScoreStudents = from student in context.Students
                                    where student.Score > 90
                                    select student;
            foreach (var student in highScoreStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Score}");
            }

            // Xóa dữ liệu
            var studentToDelete = context.Students.FirstOrDefault(s => s.Id == 1);
            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
            }
        }
    }
}

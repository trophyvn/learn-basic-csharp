using System.Collections.Generic;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

#region query syntax
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
var evenNumbers1 = from num in numbers
                   where num % 2 == 0
                   select num;

Console.WriteLine("Cú pháp truy vấn (query syntax)");
foreach (var num in evenNumbers1)
{
    Console.WriteLine(num); // Xuất 2, 4, 6
}
#endregion

#region method syntax
var evenNumbers2 = numbers.Where(num => num % 2 == 0);
Console.WriteLine("Cú pháp phương thức (method syntax)");
foreach (var num in evenNumbers2)
{
    Console.WriteLine(num); // Xuất 2, 4, 6
}
#endregion

#region Linq to Objects
Console.WriteLine("Linq to Objects");
List<Student> students = new List<Student>
{
    new Student { Name = "Alice", Score = 82 },
    new Student { Name = "Bob", Score = 60 },
    new Student { Name = "Charlie", Score = 90 },
    new Student { Name = "Daisy", Score = 72 },
    new Student { Name = "Ella", Score = 95 }
};

var filteredStudents = from student in students
                       where student.Score > 75
                       orderby student.Score descending
                       group student by student.Score into studentGroup
                       select new { Score = studentGroup.Key, Students = studentGroup };

foreach (var group in filteredStudents)
{
    Console.WriteLine($"Score: {group.Score}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($" - {student.Name}");
    }
}

#endregion

#region Linq to XML
Console.WriteLine("Linq to XML");
XMLStudentHelper studentHelper = new XMLStudentHelper("Students.xml");

// Truy vấn sinh viên có điểm cao hơn 90
studentHelper.QueryHighScoreStudents(90);

// Thêm sinh viên mới
studentHelper.AddNewStudent("4", "Daisy", "85");

// Cập nhật điểm số cho Daisy
studentHelper.UpdateStudentScore("Daisy", "95");

Console.WriteLine("Linq to XML: Sau khi cập nhật");

studentHelper.QueryHighScoreStudents(90);
#endregion

#region Aggregation

Console.WriteLine("Linq Aggregation");
List<int> numbersAgg = new List<int> { 1, 2, 3, 4, 5 };

// Tính tổng
int sum = numbersAgg.Sum();
Console.WriteLine($"Sum: {sum}"); // Sum: 15

// Max (Giá trị Lớn nhất)
int max = numbersAgg.Max();
Console.WriteLine($"Max: {max}"); // Max: 5

// Min (Giá trị Nhỏ nhất)
int min = numbersAgg.Min();
Console.WriteLine($"Min: {min}"); // Min: 1

// Count (Đếm)
int count = numbersAgg.Count();
Console.WriteLine($"Count: {count}"); // Count: 5

// Average (Trung bình)
double average = numbersAgg.Average();
Console.WriteLine($"Average: {average}"); // Average: 3

#endregion

#region Grouping
Console.WriteLine("Linq Groupping");

var studentList = new[] {
    new { Name = "Alice", Score = 90 },
    new { Name = "Bob", Score = 80 },
    new { Name = "Charlie", Score = 90 }
};

var groupedByScore = from s in students
                     group s by s.Score into g
                     select new { Score = g.Key, Students = g };

foreach (var group in groupedByScore)
{
    Console.WriteLine($"Score: {group.Score}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($" - {student.Name}");
    }
}

#endregion

#region Join
Console.WriteLine("Linq Join");
var studentJoins = new[] {
    new { Id = 1, Name = "Alice" },
    new { Id = 2, Name = "Bob" }
};

var scores = new[] {
    new { StudentId = 1, Score = 90 },
    new { StudentId = 2, Score = 80 }
};

var studentScores = from s in studentJoins
                    join sc in scores on s.Id equals sc.StudentId
                    select new { s.Name, sc.Score };

foreach (var item in studentScores)
{
    Console.WriteLine($"{item.Name}: {item.Score}");
}

#endregion

#region Set
// Các phương thức thao tác với tập hợp như: Distinct, Except, Intersect, Union.
// Distinct: Loại bỏ các phần tử trùng lặp.
int[] numbersToDistinct = { 1, 2, 2, 3, 4, 4, 5 };
Console.WriteLine($"Distinct: {String.Join(", ", numbersToDistinct.Distinct())}"); // 1, 2, 3, 4, 5

// Except: Trả về các phần tử chỉ có trong tập hợp đầu tiên mà không có trong tập hợp thứ hai.
int[] firstSet = { 1, 2, 3, 4, 5 };
int[] secondSet = { 4, 5, 6, 7, 8 };
Console.WriteLine($"Except: {String.Join(", ", firstSet.Except(secondSet))}"); // 1, 2, 3

// Intersect: Lấy các phần tử chung giữa hai tập hợp.
int[] firstSetIntersect = { 1, 2, 3, 4, 5 };
int[] secondSetIntersect = { 4, 5, 6, 7, 8 };
Console.WriteLine($"Intersect: {String.Join(", ", firstSetIntersect.Intersect(secondSetIntersect))}"); // 4, 5

// Union: Kết hợp các phần tử từ hai tập hợp, loại bỏ trùng lặp.
int[] firstSetUnion = { 1, 2, 3, 4, 5 };
int[] secondSetUnion = { 4, 5, 6, 7, 8 };
Console.WriteLine($"Intersect: {String.Join(", ", firstSetUnion.Union(secondSetUnion))}"); // 1, 2, 3, 4, 5, 6, 7, 8
#endregion

#region Partition
// Chia tập hợp thành các phần nhỏ hơn dựa trên chỉ số. Ví dụ: Skip, Take.
var firstThree = students.Take(3).Select(x => x.Name); // Lấy 3 sinh viên đầu tiên
Console.WriteLine($"Take: {String.Join(", ", firstThree)}"); // Alice, Bob, Charlie
#endregion

#region Projection
// Phép chiếu: Chuyển đổi các phần tử của tập hợp sang một dạng mới. Ví dụ: Select.
var names = students.Select(s => s.Name);
Console.WriteLine($"Select: {String.Join(", ", names)}"); // Alice, Bob, Charlie, Daisy, Ella
#endregion

#region Element
// Truy cập các phần tử cụ thể trong tập hợp. Ví dụ: First, FirstOrDefault, Last, LastOrDefault.
var firstHighScoreStudent = students.FirstOrDefault(s => s.Score > 85);
Console.WriteLine($"FirstOrDefault: {firstHighScoreStudent?.Name}"); // Charlie
#endregion

// Trên đây là những ví dụ tiêu biểu, Còn nhiều ví dụ, thư viên hàm của Linq bạn có tham khảo thêm tại link này:
// https://github.com/dotnet/try-samples/blob/main/101-linq-samples/src/Program.cs
#region character escape sequences
Console.WriteLine("==========character escape sequences============");
/*Một số chuỗi escape ký tự đặc biệt phổ biến trong C# bao gồm:

\n: Xuống dòng mới (line feed).
\t: Ký tự tab (tabulation).
\\: Ký tự gạch chéo ngược (backslash).
\": Ký tự dấu ngoặc kép (double quote), cho phép chèn dấu ngoặc kép vào trong một chuỗi được bao quanh bởi dấu ngoặc kép.
\': Ký tự dấu nháy đơn (single quote), sử dụng trong chuỗi được bao quanh bởi dấu nháy đơn.
\uXXXX: Ký tự Unicode, với XXXX là mã hexa của ký tự đó.
@"": Chuỗi chữ nguyên bản (verbatim string literal)

*/

// vi du 1:
string example = "Xin chao, \"lau qua khong gap!\"\nDao nay the nao?";
Console.WriteLine(example);

// vi du 2:
Console.WriteLine("c:\\data\\my-photo\\my-family.jpg");

// vi du 3: 
Console.WriteLine(@"c:\data\my-photo\my-family.jpg");

// vi du 4:
Console.WriteLine("\u0042\u006F\u006E\u006A\u006F\u0075\u0072!"); // tieng phap
Console.WriteLine("\u0048\u006F\u006C\u0061!"); // tieng tay ban nha

// vi du 5:
Console.WriteLine("Hoa don nuoc nam 2023: \"Khach hang A\" ...\n");
Console.WriteLine("Hoa don: thang 9\t\tDa thanh toan!");
Console.WriteLine("Hoa don: thang 10\t\tDa thanh toan!");
Console.WriteLine("Hoa don: thang 11\t\tDa thanh toan!");
Console.WriteLine("Hoa don: thang muoi hai \tChua thanh toan!");

#endregion

#region string concatenation
Console.WriteLine("==========string concatenation============");
// vi du 1: kết hợp với biến
string name = "Bob";
string msg = "Hello " + name;
Console.WriteLine(msg);

// vi du 2: kết hợp với nhiều biến và tạo ra biến trung gian
string greeting = "Hello";
string intermediateVariable = greeting + " " + name + "!";
Console.WriteLine(intermediateVariable);

// vi du 3: Thực thi ghép chuỗi và đồng thời in ra kết quả không qua biến trung gian.
// Lưu ý: Tránh sử dụng biến trung gian nếu không cần thiết.
Console.WriteLine(greeting + " " + name + "!");

#endregion

#region string interpolation
Console.WriteLine("==========string interpolation============");
// vi du 1: nhung bien vao chuoi
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message); // Kết quả sẽ là: "Hello Bob!"

// vi du 2: Nội suy chuỗi cho phép thực hiện nhiều hoạt động trong một dòng mã.
int version = 11;
string updateText = "Cap nhat len phien ban";
string message2 = $"{updateText} {version}";
Console.WriteLine(message2);

// vi du 3: Nếu muốn xứ lý chuỗi trong chuỗi nguyên bản, bạn có thể kết hợp ký tự @ và $.
string folderName = "my-photo";
string fileName = "my-family.jpg";
Console.WriteLine($@"C:\Output\{folderName}\{fileName}");

#endregion


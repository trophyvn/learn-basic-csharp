// See https://aka.ms/new-console-template for more information

#region Literal vs variable
var val = 22;
var literalNumber = 42 + val;
var literalString = "Hello";

// literal
Console.WriteLine(10);

// variable
Console.WriteLine(literalNumber);
Console.WriteLine(literalString);
#endregion

#region Data type
// char literal
Console.WriteLine('a');

// string literal
Console.WriteLine("hello");

// number literals

// integer literal
Console.WriteLine(123);

// float literal
Console.WriteLine(0.55F); // literal suffix F or f. Precision: ~6-9 digits

// double literal
Console.WriteLine(0.25); //  default type is double if without suffix. Precision: ~15-17 digits

// decimal literal
Console.WriteLine(5.256254533m); // literal suffix M or m. Precision: ~28-29 digits

// boolean literals
Console.WriteLine(true); //True
Console.WriteLine(false); //False
#endregion

#region Declare variables
int myVariable123 = 10;
string my_Name = "Liem";

int variable1 = 5; // Hợp lệ
//int 1variable = 5; // Không hợp lệ

string Value = "Hello";
string value = "World";

int firstName;
//firstName = "John"; // Không hợp lệ

// reasign, gan lai gia tri
string lastName;
lastName = "Nguyen";
Console.WriteLine(lastName);
lastName = "Tran";
Console.WriteLine(lastName);
lastName = "Le";
Console.WriteLine(lastName);

// Không hợp lệ vì "decimal" là từ khóa trong C#
//decimal decimal;

// Không hợp lệ vì "string" là từ khóa trong C#
//string string;
#endregion

#region Declare lmplicitly typed local variables
var message = "Hello world!"; // valid

// message = 10.703m; // Không hợp lệ. Sẽ báo lỗi vì không thể chuyển đổi kiểu tự động từ chuỗi sang số thực

// var alert; // Không hợp lệ
#endregion
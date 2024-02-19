
// vi du 1: 
double diameter = 10.0;
double circumference = ConstantsExample.Pi * diameter;
Console.WriteLine($"Chu vi cua hinh tron co duong kinh {diameter} là {circumference}");

// vi du 2:
string[] dayNames = EnumExample.GetNamesOfDaysOfWeek();
foreach (var dayName in dayNames)
{
    Console.WriteLine(dayName);
}

// vi du 3:
Array dayValues = EnumExample.GetValuesOfDaysOfWeek();
foreach (var dayValue in dayValues)
{
    Console.WriteLine($"{dayValue} = {(int)dayValue}");
}

#region Constants
// Kiểu dữ liệu mặc định của phần tử enum là int
public class ConstantsExample
{
    public const double Pi = 3.14159;
    public const int Size = 100;

    //Bạn cũng có thể đặt tên const theo kiểu _{UPPERCASE}:
    //public const double _PI = 3.14159;
    //public const int _SIZE = 100;
}

// Kiểu dữ liệu khác phần tử enum là: byte, sbyte, short, ushort, int, uint, long, hoặc ulong
public enum ErrorCode : byte
{
    None = 0,
    Unknown = 1,
    ConnectionLost = 2,
    OutOfMemory = 3
}

#endregion

#region Enumerations
public enum DaysOfWeek
{
    Sunday,    // 0
    Monday,    // 1
    Tuesday,   // 2
    Wednesday, // 3
    Thursday,  // 4
    Friday,    // 5
    Saturday   // 6
}

public class EnumExample
{
    public static string[] GetNamesOfDaysOfWeek()
    {
        return Enum.GetNames(typeof(DaysOfWeek));
    }

    public static Array GetValuesOfDaysOfWeek()
    {
        return Enum.GetValues(typeof(DaysOfWeek));
    }
}
#endregion
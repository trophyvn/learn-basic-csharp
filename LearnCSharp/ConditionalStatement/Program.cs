using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Ví dụ 1: if
Console.WriteLine("Ví dụ 1:");
int number = 10;
if (number > 0)
{
    Console.WriteLine("Số là dương.");
}

// Ví dụ 2: if else
Console.WriteLine("Ví dụ 2:");
int number2 = -10;
if (number2 > 0)
{
    Console.WriteLine("Số là dương.");
}
else
{
    Console.WriteLine("Số không phải là dương.");
}

// Ví dụ 3: if else-if else
Console.WriteLine("Ví dụ 3:");
int number3 = 0;
if (number3 > 0)
{
    Console.WriteLine("Số là dương.");
}
else if (number3 < 0)
{
    Console.WriteLine("Số là âm.");
}
else
{
    Console.WriteLine("Số là không.");
}

// Ví dụ 4: switch
Console.WriteLine("Ví dụ 4:");
int dayOfWeek = 3;
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Thứ Hai");
        break;
    case 2:
        Console.WriteLine("Thứ Ba");
        break;
    case 3:
        Console.WriteLine("Thứ Tư");
        break;
    case 4:
        Console.WriteLine("Thứ Năm");
        break;
    case 5:
        Console.WriteLine("Thứ Sáu");
        break;
    case 6:
        Console.WriteLine("Thứ Bảy");
        break;
    case 7:
        Console.WriteLine("Chủ Nhật");
        break;
    default:
        Console.WriteLine("Giá trị không hợp lệ");
        break;
}

// Ví dụ 5: nested if else
Console.WriteLine("Ví dụ 5: Sử dụng nested if else");
bool isAuthenticated = true;
bool hasPermission = false;
bool isOwner = false;
bool isAdmin = false;
string resourceType = "document";

if (isAuthenticated)
{
    if (resourceType == "document")
    {
        if (isOwner)
        {
            Console.WriteLine("Bạn có quyền chỉnh sửa tài liệu này.");
        }
        else if (isAdmin)
        {
            Console.WriteLine("Bạn có quyền chỉnh sửa tất cả tài liệu.");
        }
        else if (hasPermission)
        {
            Console.WriteLine("Bạn có quyền chỉnh sửa tài liệu này.");
        }
        else
        {
            Console.WriteLine("Bạn không có quyền chỉnh sửa tài liệu này.");
        }
    }
    else if (resourceType == "settings")
    {
        if (isAdmin)
        {
            Console.WriteLine("Bạn có quyền truy cập cài đặt hệ thống.");
        }
        else
        {
            Console.WriteLine("Bạn không có quyền truy cập cài đặt hệ thống.");
        }
    }
    else
    {
        Console.WriteLine("Loại tài nguyên không được hỗ trợ.");
    }
}
else
{
    Console.WriteLine("Bạn cần phải đăng nhập để tiếp tục.");
}

// Ví dụ 6: refactor nested if else
Console.WriteLine("Ví dụ 6: Không sử dụng nested if else");
var userAccessControl = new UserAccessControl
{
    IsAuthenticated = true,
    HasPermission = false,
    IsOwner = false,
    IsAdmin = false
};

string accessResult = userAccessControl.CheckAccess("document");
Console.WriteLine(accessResult);
// Đây là một single-line comment
/* Đây là một multi-line comment
   và nó có thể kéo dài qua nhiều dòng. */

/*
 * Khai báo biến counter
 * Duyệt qua vòng lập và tăng giá trị cho counter
 * In kết quả counder
 */

/// XML Documentation Comments
/// Dùng để tạo tài liệu kỹ thuật cho mã nguồn.
/// Sử dụng dấu /// trước khi khai báo.

// Khai báo biến đếm
int counter = 0;

// Vòng lặp for để in ra số từ 1 đến 5
for (int i = 1; i <= 5; i++)
{
    // In ra giá trị hiện tại của i
    Console.WriteLine(i);
    // Tăng biến đếm
    counter++;
}

// In ra số lần lặp đã thực hiện
Console.WriteLine("Đã thực hiện " + counter + " lần lặp.");

GreetingHelper.GetHelloMessage("World");
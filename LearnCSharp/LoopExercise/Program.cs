using System.Text;
Console.OutputEncoding = Encoding.UTF8;

// ví dụ 1:
/*
 * for được sử dụng khi số lần lặp được biết trước.
 * Có ba thành phần chính: khởi tạo, điều kiện lặp, và cập nhật biến lặp.
 * Thích hợp cho việc lặp với chỉ số, như duyệt qua các phần tử của mảng.
 
for (khởi_tạo; điều_kiện; cập_nhật)
{
    // Khối lệnh để thực hiện
}
*/
Console.WriteLine("Ví dụ 1:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Lần lặp thứ " + i);
}

// ví dụ 2:
/*
 * while kiểm tra điều kiện trước khi thực hiện khối lệnh.
 * Chỉ có một điều kiện lặp và không có phần khởi tạo hoặc cập nhật rõ ràng như for.
 
while (điều_kiện) {
    // Khối lệnh để thực hiện
}
 */
Console.WriteLine("Ví dụ 2:");
int j = 0;
while (j < 5)
{
    Console.WriteLine("Lần lặp thứ " + j);
    j++;
}

// ví dụ 3:
/*
 * do-while đảm bảo rằng khối lệnh sẽ được thực hiện ít nhất một lần, sau đó mới kiểm tra điều kiện.
 * Cũng chỉ có một điều kiện lặp như while.

do {
    // Khối lệnh để thực hiện
} while (điều_kiện);
 */
Console.WriteLine("Ví dụ 3:");
int k = 0;
do
{
    Console.WriteLine("Lần lặp thứ " + k);
    k++;
} while (k < 5);

// ví dụ 4:
/*
 * foreach được thiết kế để lặp qua từng phần tử của một tập hợp (như mảng hoặc collection) mà không cần sử dụng chỉ số.
 * Không thể thay đổi giá trị của phần tử trong tập hợp khi sử dụng foreach.

foreach (kiểu_dữ_liệu tên_biến in tập_hợp) {
    // Khối lệnh để thực hiện
}
 */
Console.WriteLine("Ví dụ 4:");
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
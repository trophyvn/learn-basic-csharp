#region perform addition
using System.Collections.Generic;
using System.ComponentModel;

Console.WriteLine("==========Phep cong va nap chong toan tu============");
// vi du 1:
int firstNumber = 22;
int secondNumber = 33;
Console.WriteLine(firstNumber + secondNumber); // ket qua: 55

// vi du 2:
string ten = "Be Thu";
int tuoi = 8;
Console.WriteLine(ten + " nam nay " + tuoi + " tuoi."); // ket qua: Be Thu nam nay 8 tuoi.

// vi du 3:
int tinh_nam_sinh = 1;
Console.WriteLine(ten + " nam nay " + tuoi + tinh_nam_sinh + " tuoi."); // ket qua: Be Thu nam nay 81 tuoi.

// vi du 4:
Console.WriteLine(ten + " nam nay " + (tuoi + tinh_nam_sinh) + " tuoi."); // ket qua: Be Thu nam nay 9 tuoi.
#endregion

#region perform math operations

// vi du 1:
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Tong: " + sum);
Console.WriteLine("Hieu: " + difference);
Console.WriteLine("Tich: " + product);
Console.WriteLine("Thuong: " + quotient);

// vi du 2: 
//Để phép chia hoạt động đúng, bạn cần sử dụng một loại dữ liệu hỗ trợ các chữ số thập phân sau dấu thập phân như kiểu decimal.
decimal quotient2 = 9.0m / 5;
Console.WriteLine($"Decimal quotient: {quotient2}"); // = 1.8

// vi du 3:
int first = 7;
int second = 5;
decimal quotient3 = (decimal)first / (decimal)second;
Console.WriteLine(quotient3);

// CHÚ Ý
// Để kết quả  chính xác, thương số (bên trái toán tử gán) phải thuộc loại thập phân
// VÀ ít nhất một trong các số được chia cũng phải thuộc loại thập phân (cả hai số cũng có thể là loại thập phân).

// DUNG
decimal correctResult1 = 7 / 5.0m;
decimal correctResult2 = 7.0m / 5.0m;

// SAI
//int incorrectResult1 = 7 / 5.0m;
//int incorrectResult2 = 7.0m / 5;
//int incorrectResult3 = 7.0m / 5.0m;
//decimal incorrectResult4 = 7 / 5;

// vi du 4:
Console.WriteLine($"Modulus 20 / 5 : {20 % 5}"); // phần dư của 20/5 là 0.
Console.WriteLine($"Modulus of 9 / 5 : {9 % 5}"); // phần dư của 9/5 là 4. 
// Modulus còn được gợi là toán tử chia lấy dư.

// vi du 5:
/* 
    PEMDAS
    Parentheses: Dấu ngoặc đơn
    Exponents: Lũy thừa (số mũ)
    Multiplication and Division: Phép nhân và chia (từ trái sang phải)
    Addition and Subtraction Phép cộng và trừ (từ trái sang phải)
*/
Console.WriteLine($"PEMDAS of 3 + (15-2) * 2 ^ 2 - 4 / 2: {3 + (15 - 2) * Math.Pow(2, 2) - 4 / 2}"); // = 53
                                                                                                     // 1: (15-2) = 13
                                                                                                     // 2: 2 ^ 2 =  4
                                                                                                     // 3: 13 * 4 = 52
                                                                                                     // 4: 4/2 = 2
                                                                                                     // 5: 3 + 52 = 55
                                                                                                     // 6: 55 - 2 (ket qua của #4) = 53
#endregion

#region Increment and decrement values
// vi du 1:

int value = 0;     // giá trị bây giờ là 0.
value = value + 5; // giá trị bây giờ là 5.
value += 5;        // giá trị bây giờ là 10.

// vi du 2:
int value2 = 0;     // giá trị bây giờ là 0.
value2 = value2 + 1; // giá trị bây giờ là 1.
value2++;           // giá trị bây giờ là 2.

// vi du 3:
value = 1;

value = value + 1;
Console.WriteLine("Tang lan 1: " + value);

value += 1;
Console.WriteLine("Tang lan 2: " + value);

value++;
Console.WriteLine("Tang lan 3: " + value);

value = value - 1;
Console.WriteLine("Giam lan 1: " + value);

value -= 1;
Console.WriteLine("Giam lan 2: " + value);

value--;
Console.WriteLine("Giam lan 3: " + value);

// vi du 4: Vị trí của toán tử tăng và giảm
int val1 = 1;
int val2 = 1;
Console.WriteLine("Tang truoc khi lay: " + ++val1); // tăng sẽ xảy ra trước khi giá trị được lấy 
Console.WriteLine("Tang sau khi lay: " + val2++); // tăng sẽ xảy ra sau khi giá trị đã được lấy.
#endregion
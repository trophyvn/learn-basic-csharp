bool isAdult = true;
int age = 18;
bool canVote = isAdult && age >= 18; // '&&' là toán tử logic AND, '>=' là toán tử so sánh
Console.WriteLine($"Duoc phep di bau cu: {(canVote? "YES": "NO")}");
/*
 * Trong ví dụ này:
 * && là toán tử logic AND, nó sẽ trả về true nếu cả hai toán hạng là true.
 * >= là toán tử so sánh, nó sẽ trả về true nếu toán hạng bên trái lớn hơn hoặc bằng toán hạng bên phải.
 * isAdult và age là các toán hạng.
 * isAdult && age >= 18 là một biểu thức, kết quả của biểu thức này sẽ xác định liệu một người có đủ điều kiện để bỏ phiếu dựa trên hai điều kiện: 
 * họ phải là người lớn (isAdult là true) và tuổi của họ phải lớn hơn hoặc bằng 18.
 * Biểu thức canVote sẽ đánh giá và trả về true nếu cả hai điều kiện đều được thỏa mãn, cho thấy rằng người đó có thể bỏ phiếu.
 * Trong biểu thức Console.WriteLine, Toán tử điều kiện ?: kiểm tra giá trị của biến canVote để quyết dịnh trả về YES hoặc NO.
*/
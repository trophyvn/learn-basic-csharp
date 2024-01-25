using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Ví dụ 1: Xử lý ngoại lệ try-catch-finally
/*
try
{
    // Mã lệnh có thể phát sinh ngoại lệ
}
catch (Exception ex)
{
    // Xử lý ngoại lệ chung
}
finally
{
    // Mã lệnh luôn được thực thi
}
*/
Console.WriteLine("Vi du 1:");
TryCatchHelper.UseTryCatchFinally();

// Ví dụ 2: Xử lý ngoại lệ lồng nhau
/*
try
{
    try
    {
        // Mã lệnh có thể phát sinh ngoại lệ
    }
    catch (SomeSpecificException ex)
    {
        // Xử lý ngoại lệ cụ thể
    }
}
catch (Exception ex)
{
    // Xử lý ngoại lệ chung
}
finally
{
    // Mã lệnh luôn được thực thi
}
*/
Console.WriteLine("Vi du 2:");
TryCatchHelper.UseNestedTryCatchFinally();
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

var helper = new LinqToEntitiesHelper();

// Add a new student
Console.WriteLine("Thực hiện CRUD...");
helper.ExcuteCRUD();
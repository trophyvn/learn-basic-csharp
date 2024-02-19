using ListExercise;
using System.Collections.ObjectModel;

// vi du 1: Enumerable IEnumerable<T>
Console.WriteLine("Vi du 1:");
IEnumerable<int> numbers = ListHelper.GetNumbers();
ListHelper.PrintNumbers(numbers);

// vi du 2: Collection ICollection<T>
Console.WriteLine("Vi du 2:");
ICollection<int> colNumbers = new Collection<int>();
ListHelper.AddNumbers(colNumbers);
ListHelper.PrintNumbers(colNumbers);

// vi du 3: List IList<T>
Console.WriteLine("Vi du 3:");
IList<int> lisNumbers = new List<int> { 5, 3, 1, 2, 4 };
ListHelper.SortNumbers(lisNumbers);
ListHelper.PrintNumbers(lisNumbers);
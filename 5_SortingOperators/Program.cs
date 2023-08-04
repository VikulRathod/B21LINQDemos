#region Reverse() Method

//List<int> numbers = new List<int> { 20, 12, 45, 11 };

//foreach (var number in numbers)
//{
//    Console.Write($"{number} ");
//}
//Console.WriteLine();
//numbers.Reverse();
//foreach (var number in numbers)
//{
//    Console.Write($"{number} ");
//}
//Console.WriteLine();

//List<Student> students = Student.GetStudents();
//Console.WriteLine("*** ALL Student ***");
//Student.Print(students);

//Console.WriteLine("*** Students after Reverse() method ***");
//students.Reverse();
//Student.Print(students);


//Console.ReadLine();

#endregion Reverse() Method

#region OrderBy() & OrderByDescending() method

//List<Student> students = Student.GetStudents();
//Console.WriteLine("*** All Student ***");
//Student.Print(students);

//var result1 = students.OrderBy(s => s.Gender);
//Console.WriteLine("*** All Student after OrderBy(s => s.Gender); ***");
//Student.Print(result1);

//var result2 = students.OrderByDescending(s => s.Gender);
//Console.WriteLine("*** All Student after OrderByDescending(s => s.Gender); ***");
//Student.Print(result2);

// Console.ReadLine();

#endregion OrderBy() & OrderByDescending() method

#region ThenBy() & ThenByDescending() method

List<Student> students = Student.GetStudents();
Console.WriteLine("*** All Student ***");
Student.Print(students);

IOrderedEnumerable<Student> result1 = students.OrderBy(s => s.Gender);
Console.WriteLine("*** All Student after OrderBy(s => s.Gender) ***");
Student.Print(result1);

// var result2 = result1.ThenBy(s => s.Name);
var result2 = result1.ThenByDescending(s => s.Name);
Console.WriteLine("*** All Student after ThenByDescending(s => s.Name) ***");
Student.Print(result2);

var result3 = students.OrderBy(s => s.Gender).ThenBy(s => s.Age);
Console.WriteLine("*** All Student after OrderBy(s => s.Gender).ThenBy(s => s.Age) ***");
Student.Print(result3);

Console.ReadLine();

#endregion ThenBy() & ThenByDescending() method

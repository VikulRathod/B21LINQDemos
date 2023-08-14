//using System.Collections;

//IList<int> numbers = new List<int>() { 1, 2, 3 };

//ArrayList numbers2 = new ArrayList() { 1, 2, 3, 4, 5, 6 };
//// var numbers3 = numbers2.AsQueryable();
//var numbers3 = numbers2.Cast<int>();

//// AsEnumerable() -> it returns IEnumerable
//// AsQueryable() -> it returns IQueryable

//int[] numbers4 = new int[2];
//IEnumerable<int> numbers5 = numbers4.AsEnumerable<int>();

// var result = employees.Where(e => e.Salary > 50000); // IEnumerable<Employee>
//var result = from e in employees
//             where e.Salary > 50000
//             select e;

// var result = employees.FindAll(e => e.Salary > 50000); // List<Employee>

// List<int> numbers = new List<int>() { 1,2,3};

List<Trainer> trainers = new List<Trainer>()
{
new Trainer(){ Id = 1, Name = "Vikul", Experience = 13},
new Trainer(){ Id = 2, Name = "Usha", Experience = 2},
new Trainer(){ Id = 3, Name = "Atul", Experience = 3}
};

Console.WriteLine("*** ALL TRAINERS ***");
foreach (var item in trainers)
{
    Console.WriteLine($"Id : {item.Id} Name : {item.Name} Experience : {item.Experience}");
}

List<Student> students = new List<Student>()
{
new Student(){ RollNumber = 1, Name = "Vishal", City = "Pune", TrainerId = 1},
new Student(){ RollNumber = 2, Name = "Ramesh", City = "Mumbai", TrainerId = 2},
new Student(){ RollNumber = 3, Name = "Shital", City = "Pune", TrainerId = 1},
new Student(){ RollNumber = 4, Name = "Dipak", City = "Pune", TrainerId = null},
new Student(){ RollNumber = 5, Name = "Snehal", City = "Pune", TrainerId = null}
};
Console.WriteLine("*** ALL STUDENTS ***");
foreach (var item in students)
{
    Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} " +
        $"City : {item.City} Trainer Id : {item.TrainerId}");
}


//var result = from s in students
//             join t in trainers
//             on s.TrainerId equals t.Id
//             select new { StudentName = s.Name, TrainerName = t.Name};

//var result = from s in students
//             join t in trainers
//             on s.TrainerId equals t.Id
//             into studentsHavingTrainerNull
//             from trainer in studentsHavingTrainerNull.DefaultIfEmpty()
//             select new { StudentName = s.Name, TrainerName = trainer?.Name};

//var result = students.Join(trainers, s => s.TrainerId, t => t.Id,
//    (student, trainer) => 
//    new { StudentName = student.Name, TrainerName = trainer.Name} );

var result = from t in trainers
             join s in students
             on t.Id equals s.TrainerId
             into trainerWithNoStudents
             from student in trainerWithNoStudents.DefaultIfEmpty()
             select new { StudentName = student?.Name, TrainerName = t.Name };

foreach (var item in result)
{
    Console.WriteLine($"SName: {item.StudentName} TName : {item.TrainerName}");
}

Console.ReadLine();
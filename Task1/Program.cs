using Task1;

GroupMate groupMate = new GroupMate();

groupMate.AddStudent(new Student("John", "Doe", 20));
groupMate.AddStudent(new Student("Jane", "Smith", 22));
groupMate.AddStudent(new Student("Alex", "Johnson", 19));

Console.WriteLine("Before Sorting:");
groupMate.PrintStudents();

groupMate.Sort();

Console.WriteLine("\nAfter Sorting:");
groupMate.PrintStudents();
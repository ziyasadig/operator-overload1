
namespace Task1
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " " + Surname + ", Age: " + Age;
        }
    }
}

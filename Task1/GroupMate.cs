

namespace Task1
{
    class GroupMate
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void Sort()
        {
            students.Sort((s1, s2) => s2.Age.CompareTo(s1.Age));
        }

        public void PrintStudents()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}

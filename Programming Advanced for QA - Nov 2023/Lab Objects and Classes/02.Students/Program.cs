namespace _02.Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new();
            while (command != "end")
            {
                string[] currentCommand = command.Split();
                Student currentStudent = new Student(currentCommand[0], currentCommand[1], int.Parse(currentCommand[2]), currentCommand[3]);
                students.Add(currentStudent);

                command = Console.ReadLine();
            }
            string cityName = Console.ReadLine();
            students = students.Where(city => city.HomeTown == cityName).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }
}
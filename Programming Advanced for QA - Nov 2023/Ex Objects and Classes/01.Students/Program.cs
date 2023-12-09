using System.Collections.Generic;
using System.Diagnostics;

namespace _01.Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int countStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countStudents; i++)
            {
                string input = Console.ReadLine();
                //string[] data = input.Split();
                //"{first name} {second name} {grade}"
                string firstName = input.Split()[0];
                string lastName = input.Split()[1];
                double grade = double.Parse(input.Split()[2]);
                
                Student currentStudent = new Student(firstName, lastName, grade);

                students.Add(currentStudent);

            }
            students = students.OrderByDescending(g => g.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
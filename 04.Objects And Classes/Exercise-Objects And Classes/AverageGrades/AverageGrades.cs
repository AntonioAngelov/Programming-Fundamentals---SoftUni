using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class AverageGrades
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student currentStud = Student.ReadStudent();             
                currentStud.avgGrade = currentStud.grades.Average();
                students.Add(currentStud);
            }
      
            students.Sort((x, y) => x.name.CompareTo(y.name));

            for (int i = 0; i < students.Count - 1; i++)
            {
                if (students[i].name == students[i + 1].name && students[i + 1].avgGrade > students[i].avgGrade)
                {
                    Student buffer = students[i];
                    students[i] = students[i + 1];
                    students[i + 1] = buffer;
                }
            }

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].avgGrade >= 5.00)
                {
                    Console.WriteLine("{0} -> {1:f2}", students[i].name, students[i].avgGrade);
                }
            }

        }
    }

    class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; }
        public double avgGrade { get; set; }

        public static Student ReadStudent()
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<double> list = new List<double>();
            for (int i = 1; i < input.Length; i++)
            {
                list.Add(double.Parse(input[i]));
            }
            var current = new Student();
            current.name = input[0];
            current.grades = list;

            return current;

        }
    }
}

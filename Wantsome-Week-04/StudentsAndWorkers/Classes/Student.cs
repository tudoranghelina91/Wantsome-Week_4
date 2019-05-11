using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Classes
{
    class Student:Human
    {
        public Student(string firstName, string lastName, float grade) : base(firstName, lastName)
        {
            Grade = grade;
        }

        public float Grade { get; set; }
        public void PrintStudent()
        {
            PrintHuman();
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}

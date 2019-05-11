using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            const string WORKER = "StudentsAndWorkers.Classes.Worker";
            const string STUDENT = "StudentsAndWorkers.Classes.Student";

            List<Student> students = new List<Student>() {
                new Student("Andrei", "Gorunu", 9.70f),
                new Student("Marian", "Dumitrescu", 5.43f),
                new Student("Ionel", "Teodorian", 10.00f),
                new Student("Vasile", "Bulan", 4.43f),
                new Student("Ciprian", "Radu", 7.75f),
                new Student("Andrei", "Vasilescu", 9.94f),
                new Student("Gogu", "Dumitras", 3.24f),
                new Student("Patraulea", "Sapunaru", 6.43f),
                new Student("Dula", "Besleaga", 4.41f),
                new Student("Mitrut", "Bulibasa", 2.21f)
            };

            List<Worker> workers = new List<Worker>() {
                new Worker("Bubico", "Patronu'", 799.3f, 4),
                new Worker("Iulian", "Manageru'", 300f, 6),
                new Worker("Gigi", "Soferu'", 124f, 6),
                new Worker("Dorel", "Vasilescu'", 120f, 6),
                new Worker("Marian", "Fiul Primarului", 1000.24f, 3),
                new Worker("Gogu", "Brutaru'", 100.15f, 8),
                new Worker("Ionel", "Ciuma", 111.33f, 5),
                new Worker("Daniel", "Stuf", 123.21f, 9),
                new Worker("Iulian", "Sandu", 111.63f, 7),
                new Worker("Vasile", "Vasilescu", 98.32f, 8)
            };

            Console.WriteLine("Students ordered by grade in ascending order: ", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            List<Student> studentsSorted = students.OrderBy(student => student.Grade).ToList();
            foreach (Student student in studentsSorted)
            {
                student.PrintStudent();
                Console.WriteLine();
            }

            Console.WriteLine("Workers ordered by pay per hour in descending order:", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            List<Worker> workersSorted = workers.OrderByDescending(worker => worker.MoneyPerHour).ToList();
            foreach (Worker worker in workersSorted)
            {
                worker.PrintWorker();
                Console.WriteLine();
            }

            Console.WriteLine("Merged Lists ordered by first name and last name", ConsoleColor.Green);
            Console.ResetColor();

            List<Human> humans = new List<Human>();
            humans.AddRange(workersSorted);
            humans.AddRange(studentsSorted);

            List<Human> humansSortedFirstName = humans.OrderBy(human => human.FirstName).ToList();
            List<Human> humanSortedLastName = humansSortedFirstName.OrderBy(human => human.LastName).ToList();

            foreach (Human human in humanSortedLastName)
            {
                if (human.ToString() == WORKER)
                {
                    Worker tempWorker = (Worker)human;
                    tempWorker.PrintWorker();
                }

                if (human.ToString() == STUDENT)
                {
                    Student tempStudent = (Student)human;
                    tempStudent.PrintStudent();
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

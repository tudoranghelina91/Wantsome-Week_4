using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;

namespace StudentsAndWorkers
{
    class OutputHandling
    {
        public static void PrintList(List<Student> students)
        {
            Console.WriteLine("Students ordered by grade in ascending order: ", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            foreach (Student student in students)
            {
                student.PrintStudent();
                Console.WriteLine();
            }
        }

        public static void PrintList(List<Worker> workers)
        {
            Console.WriteLine("Workers ordered by pay per hour in descending order:", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            foreach (Worker worker in workers)
            {
                worker.PrintWorker();
                Console.WriteLine();
            }
        }

        public static void PrintList(List<Human> humans)
        {
            const string WORKER = "StudentsAndWorkers.Classes.Worker";
            const string STUDENT = "StudentsAndWorkers.Classes.Student";

            Console.WriteLine("Merged Lists ordered by first name and last name", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();

            foreach (Human human in humans)
            {
                if (human.ToString() == WORKER)
                {
                    Console.WriteLine("WORKER", Console.ForegroundColor = ConsoleColor.Cyan);
                    Console.ResetColor();
                    Worker tempWorker = (Worker)human;
                    tempWorker.PrintWorker();
                }

                if (human.ToString() == STUDENT)
                {
                    Console.WriteLine("STUDENT", Console.ForegroundColor = ConsoleColor.Magenta);
                    Console.ResetColor();
                    Student tempStudent = (Student)human;
                    tempStudent.PrintStudent();
                }

                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;

namespace StudentsAndWorkers
{
    class Sorting
    {
        public static List<Student> Sort(List<Student> students)
        {
            students = students.OrderBy(student => student.Grade).ToList();
            return students.ToList();
        }
        public static List<Worker> Sort(List<Worker> workers)
        {
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour).ToList();
            return workers.ToList();
        }

        public static List<Human> Sort(List<Human> humans)
        {
            humans = humans.OrderBy(human => human.LastName).ToList();
            humans = humans.OrderBy(human => human.FirstName).ToList();

            return humans;
        }

        public static void Merge(List<Human> humans, List<Worker> workers, List<Student> students)
        {
            humans.AddRange(students);
            humans.AddRange(workers);
        }
    }
}

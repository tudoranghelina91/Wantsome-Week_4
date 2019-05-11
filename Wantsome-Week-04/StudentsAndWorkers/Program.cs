using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;
using StudentsAndWorkers.Structs;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentStructs.students = Sorting.Sort(StudentStructs.students);
            OutputHandling.PrintList(StudentStructs.students);

            WorkersStruct.workers = Sorting.Sort(WorkersStruct.workers);
            OutputHandling.PrintList(WorkersStruct.workers);

            List<Human> humans = new List<Human>();
            Sorting.Merge(humans, WorkersStruct.workers, StudentStructs.students);

            humans = Sorting.Sort(humans);

            OutputHandling.PrintList(humans);

            Console.ReadKey();
        }
    }
}

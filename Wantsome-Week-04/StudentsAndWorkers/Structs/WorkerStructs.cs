using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;

namespace StudentsAndWorkers.Structs
{
    struct WorkersStruct
    {
        public static List<Worker> workers = new List<Worker>() {
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
    }
}

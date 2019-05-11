using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Classes;

namespace StudentsAndWorkers.Structs
{
    struct StudentStructs
    {
        public static List<Student> students = new List<Student>() {
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
    }
}

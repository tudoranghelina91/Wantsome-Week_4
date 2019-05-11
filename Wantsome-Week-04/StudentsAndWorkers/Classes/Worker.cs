using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Classes
{
    class Worker:Human
    {
        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public Worker(string firstName, string lastName, float weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
            MoneyPerHour = CalculateMoneyPerHour(weekSalary, workHoursPerDay);
        }

        public float WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public float MoneyPerHour { get; set; }

        private float CalculateMoneyPerHour(float weekSalary, int workHoursPerDay)
        {
            return (weekSalary / 7f) / workHoursPerDay;
        }

        public void PrintWorker()
        {
            PrintHuman();
            Console.WriteLine($"Week Salary: {WeekSalary}");
            Console.WriteLine($"Work Hours Per Day: {WorkHoursPerDay}");
            Console.WriteLine($"Money Per Hour {Math.Round(MoneyPerHour,2)}");
        }
    }
}

using System;

namespace OOP2.StaffMembers
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName) : base(firstName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Department { get; set; }
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"{Department}: ");
            Console.WriteLine();
        }
    }
}

using System;

namespace OOP2.StaffMembers
{
    // clasa derivata
    public class Programmer : Employee
    {
        public Programmer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Technology { get; set; }

        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Technology: {Technology}");
            Console.WriteLine();
        }
    }
}

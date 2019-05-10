﻿using System;

namespace OOP2.StaffMembers
{
    // clasa de baza
    public class Employee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        protected Employee(string test)
        {
            Console.WriteLine(test);
        }
       
        protected void Print()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
        }
    }
}

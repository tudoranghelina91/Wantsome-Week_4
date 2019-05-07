using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Human
    {
        readonly string firstName;
        readonly string lastName;
        readonly string gender;
        readonly int age;

        private DateTime dateOfBirth;
        private decimal height;

        public decimal Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public Human(string firstName, string lastName, string gender, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine("First Name: {0}", this.firstName);
            Console.WriteLine("Last Name: {0}", this.lastName);
            Console.WriteLine("Gender: {0}", this.gender);
            Console.WriteLine("Age: {0}", this.age);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsoleApp
{
    internal class Student : User
    {
        public int grade;

        public Student(string _FirstName, string _LastName, int _BirthYear, string _Email, int _grade)
            : base(_FirstName, _LastName, _BirthYear, _Email)
        {
            this.grade = _grade;
        }

        public override void PrintUserInfo()
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName} | Birth Year: {this.BirthYear} | Email: {this.Email} | Grade: {this.grade}");

        }

    }
}

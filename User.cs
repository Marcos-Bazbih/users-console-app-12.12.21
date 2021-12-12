using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsoleApp
{
    internal class User : IComparable
    {
        string firstName;
        string lastName;
        int birthYear;
        string email;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public User() { }

        public void PrintUserInfo()
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName} | Birth Year: {this.BirthYear} | Email: {this.Email}");
        }
        public int CompareTo(object obj)
        {
            User u = (User)obj;
            if (this.BirthYear < u.BirthYear) return -1;
            if (this.BirthYear > u.BirthYear) return 1;
            return 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Hobby { get; set; }
        public char Sex { get; set; }

        public string CountAge(DateTime dateOfBirth)
        {
            return (DateTime.Today.Year - dateOfBirth.Year).ToString();
        }

        public void Greeting(string firstName, string lastName, string yearsOld)
        {
            Console.WriteLine($"Hello my name is {firstName} {lastName} and I am {yearsOld}");
        }
    }
}

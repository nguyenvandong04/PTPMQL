using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Employee : Person
    {
       public string EmployeeId { get; set; }
        public int Age { get; set; }

        public Employee(string personId, string fullName, string address, string employeeId, int age)
            : base(personId, fullName, address)
        {
            EmployeeId = employeeId;
            Age = age;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"EmployeeId: {EmployeeId}, Age: {Age}");
        } 
    }
}
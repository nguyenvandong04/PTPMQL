using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string EmployeeId {get; set;}
        public int Age {get; set;}

        public Employee(string personId, string fullName, string address,string employeeId,int age)
        {
            PersonId = personId;
            FullName = fullName;
            Address = address;
            EmployeeId = employeeId;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"PersonId: {PersonId}, FullName: {FullName}, Address: {Address},EmployeeId: {EmployeeId},Age: {Age}");
        }
    }
}
using System;
using System.Collections.Generic;

namespace MyESN.Core.Employee
{
    public class EmployeeDto
    {
        public int Id { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
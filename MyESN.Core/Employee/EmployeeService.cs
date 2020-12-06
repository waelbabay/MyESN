using System;

namespace MyESN.Core.Employee
{
    public class EmployeeService
    {
        public EmployeeService()
        {
        }

        public EmployeeDto Add(EmployeeDto employeeToAdd)
        {
            if (employeeToAdd == null)
                throw new ArgumentNullException(nameof(employeeToAdd));


            return new EmployeeDto
            {
                FirstName = employeeToAdd.FirstName,
                LastName = employeeToAdd.LastName,
                DateOfBirth = employeeToAdd.DateOfBirth
            };
        }
    }
}
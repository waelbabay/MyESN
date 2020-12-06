using System;
using Xunit;

namespace MyESN.Core.Employee
{
    public class EmployeeTests
    {
        private readonly EmployeeService _employeeService;
        public EmployeeTests()
        {
            _employeeService = new EmployeeService();
        }

        [Fact]
        public void ShouldReturnEmployeeAdded()
        {
            //Arrange
            EmployeeDto employeeToAdd = new EmployeeDto
            {
                FirstName = "Wael",
                LastName = "Babay",
                DateOfBirth = new DateTime(1986, 1, 27)
            };


            //Act
            EmployeeDto employeeAdded = _employeeService.Add(employeeToAdd);

            //Assert
            Assert.NotNull(employeeAdded);
            Assert.Equal(employeeToAdd.FirstName, employeeAdded.FirstName);
            Assert.Equal(employeeToAdd.LastName, employeeAdded.LastName);
            Assert.Equal(employeeToAdd.DateOfBirth, employeeAdded.DateOfBirth);
        }

        [Fact]
        public void ShouldThrowExceptionIfEmployeeAddedIsNull()
        {
            //Arrange
            EmployeeDto employeeToAdd = null;

            //Assert
            var exception= Assert.Throws<ArgumentNullException>(() => _employeeService.Add(employeeToAdd));

            Assert.Equal(nameof(employeeToAdd), exception.ParamName);


        }
    }
}
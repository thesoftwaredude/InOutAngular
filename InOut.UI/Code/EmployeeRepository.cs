using System.Collections.Generic;
using System.Linq;
using InOut.UI.Models;

namespace InOut.UI.api
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static readonly ICollection<Employee> Employees = new List<Employee>
            {
                new Employee {Id = 1, ImageUrl = "/Assets/Images/male01.png", Name = "Daniel Craig", InOffice = false},
                new Employee {Id = 2, ImageUrl = "/Assets/Images/male02.png", Name = "Christoph Waltz", InOffice = true},
                new Employee {Id = 3, ImageUrl = "/Assets/Images/female01.png", Name = "Léa Seydoux", InOffice = true},
                new Employee {Id = 4, ImageUrl = "/Assets/Images/male03.png", Name = "Ralph Fiennes", InOffice = true},
                new Employee {Id = 5, ImageUrl = "/Assets/Images/female02.png", Name = "Monica Bellucci", InOffice = true },
                new Employee {Id = 6, ImageUrl = "/Assets/Images/male04.png", Name = "Ben Whishaw", InOffice = true},
                new Employee {Id = 7, ImageUrl = "/Assets/Images/female03.png", Name = "Naomie Harris", InOffice = true}
            };

        public IEnumerable<Employee> Get()
        {
            return Employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = Employees.FirstOrDefault(c => c.Id == employee.Id);
            if ( employeeToUpdate != null ) employeeToUpdate.InOffice = employee.InOffice;
        }
    }
}
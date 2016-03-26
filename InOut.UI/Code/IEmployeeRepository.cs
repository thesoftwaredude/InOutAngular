using System.Collections.Generic;
using InOut.UI.Models;

namespace InOut.UI.api
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Get();
        void UpdateEmployee(Employee employee);
    }
}
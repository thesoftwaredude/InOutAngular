using System.Linq;
using System.Web.Http;
using InOut.UI.Models;

namespace InOut.UI.api
{
    [Route("api/office")]
    public class OfficeController : ApiController
    {
        private readonly IEmployeeRepository _employeeRepository;

        public OfficeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public OfficeController() : this(new EmployeeRepository())
        {
            
        }

        public IHttpActionResult Get()
        {
            var employees = _employeeRepository.Get();
            return Ok(employees);
        }

        public IHttpActionResult Post(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
            return Ok();
        }

    }
}

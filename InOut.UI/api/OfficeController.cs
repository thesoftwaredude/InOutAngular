using System.Web.Http;
using InOut.UI.Models;

namespace InOut.UI.api
{
    [Route("api/office")]
    public class OfficeController : ApiController
    {
        public IHttpActionResult Get()
        {
            var employees = GetEmployees();
            return Ok(employees);
        }

        private Employee[] GetEmployees()
        {
            return new[]
            {
                new Employee {Id = 1, ImageUrl = "/Assets/Images/male01.png", Name = "Daniel Craig", InOffice = false},
                new Employee {Id = 2, ImageUrl = "/Assets/Images/male02.png", Name = "Christoph Waltz", InOffice = true},
                new Employee {Id = 3, ImageUrl = "/Assets/Images/female01.png", Name = "Léa Seydoux", InOffice = true},
                new Employee {Id = 4, ImageUrl = "/Assets/Images/male03.png", Name = "Ralph Fiennes", InOffice = true},
                new Employee {Id = 5, ImageUrl = "/Assets/Images/female02.png", Name = "Monica Bellucci", InOffice = true},
                new Employee {Id = 6, ImageUrl = "/Assets/Images/male04.png", Name = "Ben Whishaw", InOffice = true},
                new Employee {Id = 7, ImageUrl = "/Assets/Images/female03.png", Name = "Naomie Harris", InOffice = true}
            };
        }

    }
}

using Employee.Business;
using Employee.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<Models.Employee>> Get()
            => Ok(_employeeService.GetAll());

        [HttpPost]
        public ActionResult<Models.Employee> Post([FromBody] CreateEmployeeRequest request)
        {
            var newEmployee = _employeeService.Create(request.FirstName, request.LastName);
            return Created($"api/Employees/{newEmployee.Id}", newEmployee);
        }
    }
}

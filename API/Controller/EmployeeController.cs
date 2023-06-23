using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controller
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _repository.GetAll();

            if (!employee.Any())
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpGet("{guid}")]
        public IActionResult GetByGuid(Guid guid)
        {
            var employee = _repository.GetByGuid(guid);
            if (employee is null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var createdEmployee = _repository.Create(employee);
            return Ok(createdEmployee);
        }

        [HttpPut]
        public IActionResult Update(Employee employee) 
        { 
            var isUpdated = _repository.Update(employee);
            if (!isUpdated)
            {
                return NotFound();
            }
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var isDeleted = _repository.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return Ok();
        }
        
    }
}

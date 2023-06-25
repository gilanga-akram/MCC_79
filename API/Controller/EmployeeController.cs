using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/universities")]
public class EmployeeController : GeneralController<Employee>
{
    public EmployeeController(IEmployeeRepository repository) : base(repository)
    {
    }
}

using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controller
{
    [ApiController]
    [Route("api/employee")]
    public class AccountRoleController : ControllerBase
    {
        private readonly IAccountRoleRepository _repository;

        public AccountRoleController(IAccountRoleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var accountrole = _repository.GetAll();

            if (!accountrole.Any())
            {
                return NotFound();
            }

            return Ok(accountrole);
        }

        [HttpGet("{guid}")]
        public IActionResult GetByGuid(Guid guid)
        {
            var accountrole = _repository.GetByGuid(guid);
            if (accountrole is null)
            {
                return NotFound();
            }

            return Ok(accountrole);
        }

        [HttpPost]
        public IActionResult Create(AccountRole accountrole)
        {
            var createdaccountrole = _repository.Create(accountrole);
            return Ok(createdaccountrole);
        }

        [HttpPut]
        public IActionResult Update(AccountRole accountrole)
        {
            var isUpdated = _repository.Update(accountrole);
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

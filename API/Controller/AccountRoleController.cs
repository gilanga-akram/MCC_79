﻿using API.DTOs.AccountRoles;
using API.DTOs.Accounts;
using API.Services;
using API.Utilities;
using API.Utilities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/AccountRole/roles")]
    [Authorize(Roles = $"{nameof(RoleLevel.Admin)}")]
    public class AccountRoleController : ControllerBase
    {
        private readonly AccountRoleService _service;

        public AccountRoleController(AccountRoleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _service.GetAccountRole();

            if (entities == null)
            {
                return NotFound(new ResponseHandler<GetAccountRoleDto>
                {
                    Code = StatusCodes.Status404NotFound,
                    Status = HttpStatusCode.NotFound.ToString(),
                    Message = "Data not found"
                });
            }

            return Ok(new ResponseHandler<IEnumerable<GetAccountRoleDto>>
            {
                Code = StatusCodes.Status200OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = "Data found",
                Data = entities
            });
        }

        [HttpGet("{guid}")]
        public IActionResult GetByGuid(Guid guid)
        {
            var accountRole = _service.GetAccountRole(guid);
            if (accountRole is null)
            {
                return NotFound(new ResponseHandler<GetAccountRoleDto>
                {
                    Code = StatusCodes.Status404NotFound,
                    Status = HttpStatusCode.NotFound.ToString(),
                    Message = "Data not found"
                });
            }

            return Ok(new ResponseHandler<GetAccountRoleDto>
            {
                Code = StatusCodes.Status200OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = "Data found",
                Data = accountRole
            });
        }

        [HttpPost]
        public IActionResult Create(NewAccountRoleDto newAccountRoleDto)
        {
            var createAccountRole = _service.CreateAccountRole(newAccountRoleDto);
            if (createAccountRole is null)
            {
                return BadRequest(new ResponseHandler<GetAccountRoleDto>
                {
                    Code = StatusCodes.Status400BadRequest,
                    Status = HttpStatusCode.BadRequest.ToString(),
                    Message = "Data not created"
                });
            }

            return Ok(new ResponseHandler<GetAccountRoleDto>
            {
                Code = StatusCodes.Status200OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = "Successfully created",
                Data = createAccountRole
            });
        }

        [HttpPut]
        public IActionResult Update(UpdateAccountDto updateAccountRoleDto)
        {
            var update = _service.UpdateAccountRole(updateAccountRoleDto);
            if (update is -1)
            {
                return NotFound(new ResponseHandler<UpdateAccountDto>
                {
                    Code = StatusCodes.Status404NotFound,
                    Status = HttpStatusCode.NotFound.ToString(),
                    Message = "Id not found"
                });
            }
            if (update is 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseHandler<UpdateAccountRoleDto>
                {
                    Code = StatusCodes.Status500InternalServerError,
                    Status = HttpStatusCode.InternalServerError.ToString(),
                    Message = "Check your data"
                });
            }
            return Ok(new ResponseHandler<UpdateAccountRoleDto>
            {
                Code = StatusCodes.Status200OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = "Successfully updated"
            });
        }

        [HttpDelete]
        public IActionResult Delete(Guid guid)
        {
            var delete = _service.DeleteAccountRole(guid);

            if (delete is -1)
            {
                return NotFound(new ResponseHandler<GetAccountRoleDto>
                {
                    Code = StatusCodes.Status404NotFound,
                    Status = HttpStatusCode.NotFound.ToString(),
                    Message = "Id not found"
                });
            }
            if (delete is 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseHandler<GetAccountRoleDto>
                {
                    Code = StatusCodes.Status500InternalServerError,
                    Status = HttpStatusCode.InternalServerError.ToString(),
                    Message = "Check connection to database"
                });
            }

            return Ok(new ResponseHandler<GetAccountRoleDto>
            {
                Code = StatusCodes.Status200OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = "Successfully deleted"
            });
        }
    }
}
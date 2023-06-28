using API.Contracts;
using API.DTOs.AccountRoles;
using API.DTOs.Rooms;
using API.Models;

namespace API.Services
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<GetAccountRoleDto>? GetRole()
        {
            var roles = _roleRepository.GetAll();
            if (!roles.Any())
            {
                return null; // No role  found
            }

            var toDto = roles.Select(role =>
                                                new GetAccountRoleDto
                                                {
                                                    Guid = role.Guid,
                                                    
                                                }).ToList();

            return toDto; // role found
        }

        public GetAccountRoleDto? GetRole(Guid guid)
        {
            var role = _roleRepository.GetByGuid(guid);
            if (role is null)
            {
                return null; // role not found
            }

            var toDto = new GetAccountRoleDto
            {
                Guid = role.Guid,
            };
            
               

            return toDto; // roles found
        }

        public GetAccountRoleDto? CreateRole(NewAccountRoleDto newRoleDto)
        {
            var role = new Role
            {
                Guid = new Guid(),
              
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var createdRole = _roleRepository.Create(role);
            if (createdRole is null)
            {
                return null; // role not created
            }

            var toDto = new GetAccountRoleDto
            {
                Guid = role.Guid,
                
            };

            return toDto; // role created
        }

        public int UpdateRole(UpdateAccountRoleDto updateRoleDto)
        {
            var isExist = _roleRepository.IsExist(updateRoleDto.Guid);
            if (!isExist)
            {
                return -1; // role not found
            }

            var getRole = _roleRepository.GetByGuid(updateRoleDto.Guid);

            var role = new Role
            {
                Guid = updateRoleDto.Guid,
                ModifiedDate = DateTime.Now,
                CreatedDate = getRole!.CreatedDate
            };

            var isUpdate = _roleRepository.Update(role);
            if (!isUpdate)
            {
                return 0; // role not updated
            }

            return 1;
        }

        public int DeleteRole(Guid guid)
        {
            var isExist = _roleRepository.IsExist(guid);
            if (!isExist)
            {
                return -1; // role not found
            }

            var role = _roleRepository.GetByGuid(guid);
            var isDelete = _roleRepository.Delete(role!);
            if (!isDelete)
            {
                return 0; // role not deleted
            }

            return 1;
        }
    }
}
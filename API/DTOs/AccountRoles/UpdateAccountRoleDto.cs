using System.ComponentModel.DataAnnotations;

namespace API.DTOs.AccountRoles
{
    public class UpdateAccountRoleDto
    {
        public Guid Guid { get; set; }
        [Required]
        public Guid AccountGuid { get; set; }
        [Required]
        public Guid RoleGuid { get; set; }
    }
}
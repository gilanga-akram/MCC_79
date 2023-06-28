using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Accounts
{
    public class UpdateAccountDto
    {
        [Required]
        public Guid Guid { get; set; }
        [Required]
        public string Password { get; set; }

        public bool IsDeleted { get; set; }
        public int Otp { get; set; }

        public bool IsUsed { get; set; }

        [Required]
        public DateTime ExpiredTime { get; set; }
    }
}
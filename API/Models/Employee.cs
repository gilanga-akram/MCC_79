using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_m_employees")]
    public class Employee
    {
        [Key]
        [Column("guid")]
        public Guid Guid { get; set; }

        [Column("nik", TypeName = "nchar(6)")]
        public string Nik { get; set; }

        [Required, Column("first_name", TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [Required, Column("last_name", TypeName="nvarchar(100)")]
        public string LastName { get; set; }
       
        [Required, Column("birthdate")]
        public DateTime BirthDate { get; set; }
        
        [Required, Column("gender")]
        public int Gender { get; set; }
       
        [Required, Column("hiringdate")]
        public DateTime HireingDate { get; set; }
        
        [Required, Column("email", TypeName ="nvarchar(100)")]
        public string Email { get; set; }
        
        [Column("phonenumber", TypeName ="nvarchar(20)")]
        public string? PhoneNumber { get; set; }
        
        [Required, Column("create_date")]
        public DateTime CreateDate { get; set; }
        
        [Required, Column("modifed_date")]
        public DateTime ModifedDate { get; set; }
    }
}

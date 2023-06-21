using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace API.Models
{
    [Table("tb_m_educations")]
    public class Education
    {
        [Key]
        [Column("guid")]
        public Guid Guid { get; set; }
        [Column("major", TypeName = "nvarchar(100)")]
        public string Major { get; set; }
        [Column("degree", TypeName ="nvarchar(100)")]
        public string Degree { get; set; }
        [Column("gpa")]
        public double Gpa { get; set; }
        [Column("university_guid")]
        public string UniversityGuid { get; set; }
        [Column("create_date")]
        public string DateTime { get; set; }
        [Required, Column("modifed_date")]
        public DateTime ModifedDate { get; set; }
    }

}


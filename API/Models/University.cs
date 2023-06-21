using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_m_universities")]
    public class University : BaseEntity

    {
        [Key]
        [Column("guid")]
        public Guid Guid { get; set; }

        [Column("name", TypeName= "nvarchar(50)")]
        public string Name { get; set; }
        
        [Column("code", TypeName = "nvarchar(100)")]
        public string Code { get; set; }
        
        [Column("create_date")]
        public DateTime CreateDate { get; set; }
        
        [Column("modifed_date")]
        public DateTime ModifedDate { get; set; }

        //Cardinality
        public ICollection<Education> Educations { get; set; }
    }
}

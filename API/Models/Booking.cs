using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_tr_bookings")]
    public class booking
    {
        [Key]
        [Column("guid")]
        public Guid Guid { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        
        [Column("end_date")]
        public DateTime EndDate { get; set; }
        
        [Column("status")]
        public int Status { get; set; }

        [Column("remarks", TypeName= "nvarchar(max)")]
        public string Remarks { get; set; }

        [Column("create_date")]
        public DateTime CreatDate { get; set; }

        [Column("modifed_date")]
        public DateTime ModifedTime { get; set; }

    }
}

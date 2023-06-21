﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Numerics;

namespace API.Models
{
    [Table("tb_m_accounts")]
    public class Account
    {
        [Key]
        [Column("guid")]
        public Guid Guid { get; set; }

        [Column("password", TypeName = "nvarchar(max)")]
        public string Password { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        [Column("otp")]
        public int OTP { get; set; }

        [Column("is_used")]
        public bool IsUsed { get; set;}

        [Column("expired_time")]
        public DateTime ExpiredTime { get; set; }

        [Column("created_date")]
        public DateTime CreateDate { get; set;}

        [Column("modifed_date")]
        public DateTime ModifedDate { get; set;}

    }
}
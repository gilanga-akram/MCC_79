﻿using API.Utilities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_m_rooms")]
    public class Room : BaseEntity
    {
      

        [Column("name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column("floor")]
        public int Floor { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }
        
        //Cardinality
        public ICollection<Booking>? Bookings { get; set; }
      
        public object StartDate { get; internal set; }
        public StatusLevel Status { get; internal set; }
        public object RoomGuid { get; internal set; }
    }
}

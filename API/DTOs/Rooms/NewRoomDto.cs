using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Rooms;

public class NewRoomDto
{
    public string Name { get; set; }
    [Required]
    public int Floor { get; set; }
    [Required]
    public int Capacity { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Rooms;

public class UpdateRoomDto
{
    public Guid Guid { get; set; }
    public string Name { get; set; }
    [Required]
    public int Floor { get; set; }
    [Required]
    public int Capacity { get; set; }
}
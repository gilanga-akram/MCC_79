using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/universities")]
public class RoomController : GeneralController<Room>
{
    public RoomController(IRoomRepository repository) : base(repository)
    {
    }
}

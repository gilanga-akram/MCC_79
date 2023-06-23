using API.Contracts;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace API.Controller
{
    [ApiController]
    [Route("api/employee")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _repository;

        public BookingController(IBookingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var booking = _repository.GetAll();

            if (!booking.Any())
            {
                return NotFound();
            }

            return Ok(booking);
        }

        [HttpGet("{guid}")]
        public IActionResult GetByGuid(Guid guid)
        {
            var booking = _repository.GetByGuid(guid);
            if (booking is null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            var createdBooking = _repository.Create(booking);
            return Ok(createdBooking);
        }

        [HttpPut]
        public IActionResult Update(Booking booking)
        {
            var isUpdated = _repository.Update(booking);
            if (!isUpdated)
            {
                return NotFound();
            }
            return Ok();

        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var isDeleted = _repository.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }

            return Ok();
        }

    }
}

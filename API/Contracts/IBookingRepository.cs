using API.DTOs.Bookings;
using API.Models;

namespace API.Contracts
{
    public interface IBookingRepository : IGeneralRepository<Booking>
    {
        //bool Update(UpdateBookingDto booking);
        ICollection<GetRoomTodayDto> GetByDateNow();
        IEnumerable<BookingDetailsDto> GetBookingDetails();
    }
}

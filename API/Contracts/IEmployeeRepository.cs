using API.Models;

namespace API.Contracts
{
    public interface IEmployeeRepository : IGeneralRepository<Employee>
    {
        public Employee? GetByEmail(string email);
        public Employee? GetByEmailAndPhoneNumber(string nama);

        public Employee? GetEmailLogin(string email);
        string? GetLastEmployeeNik();
    }
}
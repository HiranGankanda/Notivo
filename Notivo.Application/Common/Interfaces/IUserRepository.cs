using Notivo.Core.Domain.Entities;
using Notivo.Domain.Entities;
using System.Threading.Tasks;

namespace Notivo.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        // Method to get a user by their email address
        Task<User> GetByEmailAsync(string email);

        // Method to add a new user to the repository
        Task AddAsync(User user);
    }
}
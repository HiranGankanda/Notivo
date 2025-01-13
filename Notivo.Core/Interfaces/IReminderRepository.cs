using Notivo.Core.Domain.Entities;

namespace Notivo.Core.Interfaces
{
    public interface IReminderRepository
    {
        Task<Reminder> GetByIdAsync(Guid id);
        Task<IEnumerable<Reminder>> GetByUserIdAsync(Guid userId);
        Task AddAsync(Reminder reminder);
        Task UpdateAsync(Reminder reminder);
        Task DeleteAsync(Guid id);
    }
}
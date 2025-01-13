namespace Notivo.Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; private set; }

        public void SetUpdatedDate()
        {
            UpdatedDate = DateTime.UtcNow;
        }
    }
}
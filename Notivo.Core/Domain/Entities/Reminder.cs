using Notivo.Core.Domain.Enums;

namespace Notivo.Core.Domain.Entities
{
    public class Reminder : BaseEntity
    {
        public Guid UserId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime ReminderTime { get; private set; }
        public ReminderType Type { get; private set; }

        public Reminder(Guid userId, string title, string description, DateTime reminderTime, ReminderType type)
        {
            UserId = userId;
            Title = title;
            Description = description;
            ReminderTime = reminderTime;
            Type = type;
        }

        public void Update(string title, string description, DateTime reminderTime, ReminderType type)
        {
            Title = title;
            Description = description;
            ReminderTime = reminderTime;
            Type = type;
            SetUpdatedDate();
        }
    }
}
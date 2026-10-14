namespace Entities.Chat
{
    /// <summary>Уведомление пользователя.</summary>
    public class Notification : BaseEntity
    {
        public Guid UserId { get; set; }                    // кому адресовано
        public User User { get; set; } = null!;

        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public NotificationType Type { get; set; } = NotificationType.System;
        public string? RelatedUrl { get; set; }             // ссылка на связанный объект

        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}
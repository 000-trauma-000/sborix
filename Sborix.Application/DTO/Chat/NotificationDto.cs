using Entities.Chat;

namespace Sborix.Application.DTO.Chat
{
    public class NotificationDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public NotificationType Type { get; set; }
        public string? RelatedUrl { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}
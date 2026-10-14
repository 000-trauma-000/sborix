namespace Entities.Chat
{
    /// <summary>Сообщение в чате.</summary>
    public class ChatMessage : BaseEntity
    {
        public Guid ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; } = null!;

        public Guid SenderId { get; set; }
        public User Sender { get; set; } = null!;

        public string Content { get; set; } = null!;
        public bool IsEdited { get; set; }
        public DateTime? EditedAt { get; set; }

        public Guid? ReplyToMessageId { get; set; }         // ответ на сообщение
        public ChatMessage? ReplyTo { get; set; }

        public ICollection<ChatAttachment> Attachments { get; set; } = [];
    }
}
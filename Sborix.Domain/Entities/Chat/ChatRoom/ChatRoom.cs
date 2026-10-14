namespace Entities.Chat
{
    /// <summary>Чат (комната).</summary>
    public class ChatRoom : BaseEntity
    {
        public string? Title { get; set; }                  // для групповых чатов
        public ChatType Type { get; set; } = ChatType.Direct;

        public Guid OwnerId { get; set; }                   // кто создал чат
        public User Owner { get; set; } = null!;

        public bool IsArchived { get; set; }

        public ICollection<ChatParticipant> Participants { get; set; } = [];
        public ICollection<ChatMessage> Messages { get; set; } = [];
    }
}
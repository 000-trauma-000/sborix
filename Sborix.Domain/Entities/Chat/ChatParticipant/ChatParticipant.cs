namespace Entities.Chat
{
    /// <summary>Участник чата.</summary>
    public class ChatParticipant : BaseEntity
    {
        public Guid ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; } = null!;

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public ParticipantRole Role { get; set; } = ParticipantRole.Member;
        public DateTime JoinedAt { get; set; }
        public DateTime? LastReadAt { get; set; }           // для непрочитанных сообщений
        public bool IsMuted { get; set; }
    }
}
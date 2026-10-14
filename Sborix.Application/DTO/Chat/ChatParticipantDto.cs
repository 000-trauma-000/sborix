using Entities.Chat;

namespace Sborix.Application.DTO.Chat
{
    public class ChatParticipantDto
    {
        public Guid Id { get; set; }
        public Guid ChatRoomId { get; set; }
        public Guid UserId { get; set; }
        public ParticipantRole Role { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime? LastReadAt { get; set; }
        public bool IsMuted { get; set; }
    }
}
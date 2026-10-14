using Entities.Chat;

namespace Sborix.Application.DTO.Chat
{
    public class ChatRoomDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public ChatType Type { get; set; }
        public Guid OwnerId { get; set; }
        public bool IsArchived { get; set; }
        public ICollection<ChatParticipantDto> Participants { get; set; } = [];
    }

    public class CreateChatRoomDto
    {
        public string? Title { get; set; }
        public ChatType Type { get; set; }
        public ICollection<Guid> ParticipantIds { get; set; } = [];
    }
}
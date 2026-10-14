namespace Sborix.Application.DTO.Chat
{
    public class ChatMessageDto
    {
        public Guid Id { get; set; }
        public Guid ChatRoomId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; } = null!;
        public bool IsEdited { get; set; }
        public DateTime? EditedAt { get; set; }
        public Guid? ReplyToMessageId { get; set; }
        public ICollection<ChatAttachmentDto> Attachments { get; set; } = [];
    }

    public class SendMessageDto
    {
        public Guid ChatRoomId { get; set; }
        public string Content { get; set; } = null!;
        public Guid? ReplyToMessageId { get; set; }
    }
}
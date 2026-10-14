namespace Sborix.Application.DTO.Chat
{
    public class ChatAttachmentDto
    {
        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public string FileName { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public long FileSizeBytes { get; set; }
    }
}
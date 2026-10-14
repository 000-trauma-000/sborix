namespace Entities.Chat
{
    /// <summary>Вложение к сообщению.</summary>
    public class ChatAttachment : BaseEntity
    {
        public Guid MessageId { get; set; }
        public ChatMessage Message { get; set; } = null!;

        public string FileName { get; set; } = null!;
        public string Url { get; set; } = null!;            // путь до файла в хранилище
        public string ContentType { get; set; } = null!;    // image/png, application/pdf ...
        public long FileSizeBytes { get; set; }
    }
}
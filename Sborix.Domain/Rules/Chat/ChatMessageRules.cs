namespace Entities.Rules.Chat
{
    using Entities.Chat;
    using Entities.DomainExceptions;

    /// <summary>Бизнес-правила сообщений чата.</summary>
    public static class ChatMessageRules
    {
        public const int MaxContentLength = 4000;

        /// <summary>Текст сообщения заполнен и не слишком длинный.</summary>
        public static void EnsureContentIsValid(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new DomainValidationException("Сообщение не может быть пустым.", nameof(ChatMessage.Content));

            if (content.Length > MaxContentLength)
                throw new DomainValidationException(
                    $"Сообщение не может быть длиннее {MaxContentLength} символов.",
                    nameof(ChatMessage.Content));
        }

        /// <summary>Редактировать можно только своё сообщение.</summary>
        public static void EnsureCanEdit(ChatMessage message, Guid userId)
        {
            if (message.SenderId != userId)
                throw new ForbiddenAccessException("Редактировать можно только свои сообщения.");
        }

        /// <summary>Удалять можно только своё сообщение.</summary>
        public static void EnsureCanDelete(ChatMessage message, Guid userId)
        {
            if (message.SenderId != userId)
                throw new ForbiddenAccessException("Удалять можно только свои сообщения.");
        }
    }
}
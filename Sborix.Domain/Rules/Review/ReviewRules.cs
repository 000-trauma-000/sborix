namespace Entities.Rules.Review
{
    using Entities.DomainExceptions;
    using Rating = Entities.Review.Rating;
    using Review = Entities.Review.Review;

    /// <summary>Бизнес-правила отзывов и оценок.</summary>
    public static class ReviewRules
    {
        public const int MinRatingValue = 1;
        public const int MaxRatingValue = 5;
        public const int MaxTitleLength = 100;
        public const int MaxContentLength = 2000;

        /// <summary>Оценка в диапазоне 1–5.</summary>
        public static void EnsureRatingIsValid(int value)
        {
            if (value is < MinRatingValue or > MaxRatingValue)
                throw new DomainValidationException(
                    $"Оценка должна быть от {MinRatingValue} до {MaxRatingValue}.",
                    nameof(Rating.Value));
        }

        /// <summary>Заголовок и текст отзыва заполнены и не слишком длинные.</summary>
        public static void EnsureContentIsValid(string title, string content)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new DomainValidationException("Заголовок отзыва обязателен.", nameof(Review.Title));

            if (title.Length > MaxTitleLength)
                throw new DomainValidationException(
                    $"Заголовок не может быть длиннее {MaxTitleLength} символов.",
                    nameof(Review.Title));

            if (string.IsNullOrWhiteSpace(content))
                throw new DomainValidationException("Текст отзыва обязателен.", nameof(Review.Content));

            if (content.Length > MaxContentLength)
                throw new DomainValidationException(
                    $"Текст отзыва не может быть длиннее {MaxContentLength} символов.",
                    nameof(Review.Content));
        }

        /// <summary>Нельзя оставлять отзыв на собственную сборку.</summary>
        public static void EnsureAuthorIsNotOwner(Guid authorId, Guid ownerId)
        {
            if (authorId == ownerId)
                throw new BusinessRuleViolationException(
                    "REVIEW_SELF",
                    "Нельзя оставлять отзыв на собственную сборку.");
        }
    }
}
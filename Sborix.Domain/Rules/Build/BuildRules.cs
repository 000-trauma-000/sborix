namespace Entities.Rules.Build
{
    using Entities.Catalog;
    using Entities.DomainExceptions;

    /// <summary>Бизнес-правила сборки ПК.</summary>
    public static class BuildRules
    {
        /// <summary>Максимальная длина названия.</summary>
        public const int MaxNameLength = 100;

        /// <summary>Цена аренды в сутки должна быть положительной.</summary>
        public static void EnsurePriceIsValid(decimal pricePerDay)
        {
            if (pricePerDay <= 0)
                throw new DomainValidationException(
                    "Цена аренды за день должна быть больше нуля.",
                    nameof(Build.PricePerDay));
        }

        /// <summary>Название обязательно и не слишком длинное.</summary>
        public static void EnsureNameIsValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainValidationException("Название сборки обязательно.", nameof(Build.Name));

            if (name.Length > MaxNameLength)
                throw new DomainValidationException(
                    $"Название не может быть длиннее {MaxNameLength} символов.",
                    nameof(Build.Name));
        }

        /// <summary>Slug: нижний регистр, без пробелов.</summary>
        public static void EnsureSlugIsValid(string slug)
        {
            if (string.IsNullOrWhiteSpace(slug))
                throw new DomainValidationException("Slug обязателен.", nameof(Build.Slug));

            if (slug.Contains(' ') || slug != slug.ToLowerInvariant())
                throw new DomainValidationException(
                    "Slug должен быть в нижнем регистре и без пробелов.",
                    nameof(Build.Slug));
        }

        /// <summary>Опубликовать можно только черновик.</summary>
        public static bool CanBePublished(BuildStatus current)
            => current == BuildStatus.Draft;

        public static void EnsureCanBePublished(BuildStatus current)
        {
            if (!CanBePublished(current))
                throw new BusinessRuleViolationException(
                    "BUILD_PUBLISH",
                    $"Опубликовать можно только черновик. Текущий статус: {current}.");
        }

        /// <summary>Снять с публикации можно только опубликованную сборку.</summary>
        public static bool CanBeSuspended(BuildStatus current)
            => current == BuildStatus.Published;

        public static void EnsureCanBeSuspended(BuildStatus current)
        {
            if (!CanBeSuspended(current))
                throw new BusinessRuleViolationException(
                    "BUILD_SUSPEND",
                    $"Снять с публикации можно только опубликованную сборку. Текущий статус: {current}.");
        }

        /// <summary>Бронировать можно только опубликованную и не удалённую сборку.</summary>
        public static bool IsAvailableForBooking(Build build)
            => build.Status == BuildStatus.Published && !build.IsDeleted;

        public static void EnsureAvailableForBooking(Build build)
        {
            if (!IsAvailableForBooking(build))
                throw new BusinessRuleViolationException(
                    "BUILD_NOT_AVAILABLE",
                    "Сборка недоступна для бронирования.");
        }
    }
}
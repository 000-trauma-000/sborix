namespace Entities.Rules.Report
{
    using Entities.DomainExceptions;
    using Entities.Supply;

    /// <summary>Бизнес-правила жалоб.</summary>
    public static class ReportRules
    {
        public const int MaxDescriptionLength = 1000;

        /// <summary>Жалоба заполнена корректно.</summary>
        public static void EnsureIsValid(string reason, string? description)
        {
            if (string.IsNullOrWhiteSpace(reason))
                throw new DomainValidationException("Причина жалобы обязательна.", nameof(Report.Reason));

            if (description is { Length: > MaxDescriptionLength })
                throw new DomainValidationException(
                    $"Описание не может быть длиннее {MaxDescriptionLength} символов.",
                    nameof(Report.Description));
        }

        /// <summary>Обработать можно только новую или рассматриваемую жалобу.</summary>
        public static bool CanBeResolved(ReportStatus status)
            => status is ReportStatus.New or ReportStatus.InReview;

        public static void EnsureCanBeResolved(ReportStatus status)
        {
            if (!CanBeResolved(status))
                throw new BusinessRuleViolationException(
                    "REPORT_RESOLVE",
                    $"Жалобу в статусе {status} нельзя обработать.");
        }
    }
}
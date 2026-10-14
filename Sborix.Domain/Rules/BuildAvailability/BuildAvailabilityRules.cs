namespace Entities.Rules.BuildAvailability
{
    using Entities.DomainExceptions;
    using Entities.Supply;

    /// <summary>Бизнес-правила календаря доступности сборки.</summary>
    public static class BuildAvailabilityRules
    {
        /// <summary>Период корректен (конец не раньше начала).</summary>
        public static void EnsurePeriodIsValid(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new InvalidDateRangeException(startDate, endDate);
        }

        /// <summary>Индивидуальная цена за день не отрицательная.</summary>
        public static void EnsurePriceIsValid(decimal? pricePerDay)
        {
            if (pricePerDay is < 0)
                throw new DomainValidationException(
                    "Цена за день не может быть отрицательной.",
                    nameof(BuildAvailability.PricePerDay));
        }

        /// <summary>Пересекается ли новый период с уже занятым.</summary>
        public static bool HasConflict(
            DateTime existingStart, DateTime existingEnd,
            DateTime newStart, DateTime newEnd)
            => newStart <= existingEnd && existingStart <= newEnd;
    }
}
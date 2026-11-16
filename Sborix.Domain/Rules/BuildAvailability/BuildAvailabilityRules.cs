namespace Entities.Rules.BuildAvailability
{
    using Entities.DomainExceptions;
    using Entities.Supply;

    
    public static class BuildAvailabilityRules
    {
        
        public static void EnsurePeriodIsValid(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new InvalidDateRangeException(startDate, endDate);
        }

        
        public static void EnsurePriceIsValid(decimal? pricePerDay)
        {
            if (pricePerDay is < 0)
                throw new DomainValidationException(
                    "Цена за день не может быть отрицательной.",
                    nameof(BuildAvailability.PricePerDay));
        }

        
        public static bool HasConflict(
            DateTime existingStart, DateTime existingEnd,
            DateTime newStart, DateTime newEnd)
            => newStart <= existingEnd && existingStart <= newEnd;
    }
}
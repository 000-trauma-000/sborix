namespace Entities.Rules.PricingPlan
{
    using Entities.DomainExceptions;
    using Entities.Supply;

    /// <summary>Бизнес-правила тарифных планов.</summary>
    public static class PricingPlanRules
    {
        public const int MaxDiscountPercent = 100;

        /// <summary>Тариф корректен: название, цена, срок и скидка.</summary>
        public static void EnsureIsValid(string name, decimal pricePerDay, int minDays, int discountPercent)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainValidationException("Название тарифа обязательно.", nameof(PricingPlan.Name));

            if (pricePerDay <= 0)
                throw new DomainValidationException(
                    "Цена за день должна быть больше нуля.",
                    nameof(PricingPlan.PricePerDay));

            if (minDays < 1)
                throw new DomainValidationException(
                    "Минимальный срок аренды — не меньше 1 дня.",
                    nameof(PricingPlan.MinDays));

            if (discountPercent is < 0 or > MaxDiscountPercent)
                throw new DomainValidationException(
                    $"Скидка должна быть от 0 до {MaxDiscountPercent}%.",
                    nameof(PricingPlan.DiscountPercent));
        }

        /// <summary>Итоговая цена за день с учётом скидки.</summary>
        public static decimal CalculatePricePerDay(decimal basePricePerDay, int discountPercent)
            => basePricePerDay * (1 - discountPercent / 100m);
    }
}
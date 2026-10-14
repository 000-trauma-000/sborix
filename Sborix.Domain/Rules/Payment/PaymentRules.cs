namespace Entities.Rules.Payment
{
    using Entities.Deal;
    using Entities.DomainExceptions;

    /// <summary>Бизнес-правила платежей.</summary>
    public static class PaymentRules
    {
        /// <summary>Сумма платежа положительная.</summary>
        public static void EnsureAmountIsValid(decimal amount)
        {
            if (amount <= 0)
                throw new DomainValidationException(
                    "Сумма платежа должна быть больше нуля.",
                    nameof(Payment.Amount));
        }

        /// <summary>Завершить можно только ожидающий или неудавшийся платёж.</summary>
        public static bool CanBeCompleted(PaymentStatus status)
            => status is PaymentStatus.Pending or PaymentStatus.Failed;

        public static void EnsureCanBeCompleted(PaymentStatus status)
        {
            if (!CanBeCompleted(status))
                throw new BusinessRuleViolationException(
                    "PAYMENT_COMPLETE",
                    $"Платёж в статусе {status} нельзя завершить.");
        }

        /// <summary>Возврат возможен только за завершённый платёж.</summary>
        public static bool CanBeRefunded(PaymentStatus status)
            => status == PaymentStatus.Completed;

        public static void EnsureCanBeRefunded(PaymentStatus status)
        {
            if (!CanBeRefunded(status))
                throw new BusinessRuleViolationException(
                    "PAYMENT_REFUND",
                    $"Возврат возможен только для платежа в статусе {PaymentStatus.Completed}. Текущий статус: {status}.");
        }

        /// <summary>Сумма платежа совпадает с суммой брони.</summary>
        public static void EnsureAmountMatchesBooking(Booking booking, decimal amount)
        {
            if (amount != booking.TotalPrice)
                throw new DomainValidationException(
                    $"Сумма платежа ({amount}) не совпадает с суммой брони ({booking.TotalPrice}).",
                    nameof(Payment.Amount));
        }
    }
}
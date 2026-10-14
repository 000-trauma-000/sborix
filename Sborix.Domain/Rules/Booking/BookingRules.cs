namespace Entities.Rules.Booking
{
    using Entities.Catalog;
    using Entities.Deal;
    using Entities.DomainExceptions;

    /// <summary>Бизнес-правила брони (аренды).</summary>
    public static class BookingRules
    {
        /// <summary>Максимальная длительность одной брони, дней.</summary>
        public const int MaxBookingDays = 30;

        // ---------- даты ----------

        /// <summary>Конец не раньше начала.</summary>
        public static void EnsureValidDates(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                throw new InvalidDateRangeException(startDate, endDate);
        }

        /// <summary>Бронировать можно только на будущее.</summary>
        public static void EnsureDatesInFuture(DateTime startDate, DateTime utcNow)
        {
            if (startDate < utcNow)
                throw new DomainValidationException(
                    "Дата начала брони не может быть в прошлом.",
                    nameof(Booking.StartDate));
        }

        /// <summary>Срок брони не превышает лимит.</summary>
        public static void EnsureDurationWithinLimit(DateTime startDate, DateTime endDate)
        {
            var days = (endDate.Date - startDate.Date).Days + 1;
            if (days > MaxBookingDays)
                throw new DomainValidationException(
                    $"Максимальный срок брони — {MaxBookingDays} дней, запрошено {days}.",
                    nameof(Booking.EndDate));
        }

        /// <summary>Периоды не пересекаются (нет двойного бронирования).</summary>
        public static void EnsureNoOverlap(
            string itemName,
            DateTime existingStart, DateTime existingEnd,
            DateTime newStart, DateTime newEnd)
        {
            if (newStart <= existingEnd && existingStart <= newEnd)
                throw new BookingConflictException(itemName, existingStart, existingEnd);
        }

        // ---------- статусы ----------

        /// <summary>Разрешён ли переход статуса брони.</summary>
        public static bool CanChangeStatus(BookingStatus current, BookingStatus target)
        {
            if (current is BookingStatus.Completed or BookingStatus.Cancelled)
                return false; // финальные статусы менять нельзя

            return target switch
            {
                BookingStatus.Pending => false,                                       // назад в «ожидание» нельзя
                BookingStatus.Confirmed => current == BookingStatus.Pending,
                BookingStatus.Active => current == BookingStatus.Confirmed,
                BookingStatus.Completed => current == BookingStatus.Active,
                BookingStatus.Cancelled => current is BookingStatus.Pending or BookingStatus.Confirmed,
                _ => false,
            };
        }

        public static void EnsureStatusCanBeChanged(BookingStatus current, BookingStatus target)
        {
            if (!CanChangeStatus(current, target))
                throw new BusinessRuleViolationException(
                    "BOOKING_STATUS_TRANSITION",
                    $"Недопустимый перевод статуса брони: {current} → {target}.");
        }

        /// <summary>Отменить можно только бронь, которая ещё не в аренде и не завершена.</summary>
        public static void EnsureCanBeCancelled(BookingStatus current)
        {
            if (current is BookingStatus.Active or BookingStatus.Completed)
                throw new BusinessRuleViolationException(
                    "BOOKING_CANCEL",
                    "Активную или завершённую бронь отменить нельзя.");
        }

        // ---------- наличие ----------

        /// <summary>Запрошенное количество есть в наличии.</summary>
        public static void EnsureStockAvailable(string itemName, int requestedQuantity, int availableQuantity)
        {
            if (requestedQuantity > availableQuantity)
                throw new InsufficientStockException(itemName, requestedQuantity, availableQuantity);
        }
    }
}

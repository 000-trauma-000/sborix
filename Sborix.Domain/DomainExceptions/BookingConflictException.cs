namespace Entities.DomainExceptions
{
    /// <summary>Выбранный период уже занят другой бронью.</summary>
    public class BookingConflictException : ConflictException
    {
        public BookingConflictException(string itemName, DateTime startDate, DateTime endDate)
            : base($"«{itemName}» уже занят(а) на период с {startDate:dd.MM.yyyy} по {endDate:dd.MM.yyyy}. Выберите другие даты.")
        {
            ItemName = itemName;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string ItemName { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
    }
}
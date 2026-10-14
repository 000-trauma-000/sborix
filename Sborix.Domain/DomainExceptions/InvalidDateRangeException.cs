namespace Entities.DomainExceptions
{
    /// <summary>Дата начала позже даты окончания.</summary>
    public class InvalidDateRangeException : DomainException
    {
        public InvalidDateRangeException(DateTime startDate, DateTime endDate)
            : base($"Дата начала ({startDate:dd.MM.yyyy}) должна быть не позже даты окончания ({endDate:dd.MM.yyyy}).")
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
    }
}
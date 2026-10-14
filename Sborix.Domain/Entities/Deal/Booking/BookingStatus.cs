namespace Entities.Deal
{
    /// <summary>Статус брони.</summary>
    public enum BookingStatus
    {
        Pending = 0,      // ожидает подтверждения
        Confirmed = 1,    // подтверждена
        Active = 2,       // в аренде
        Completed = 3,    // завершена
        Cancelled = 4     // отменена
    }
}
namespace Entities.Deal
{
    /// <summary>Способ оплаты.</summary>
    public enum PaymentMethod
    {
        Card = 0,
        Sbp = 1,        // СБП
        Cash = 2,
        Crypto = 3,
        Other = 4
    }
}
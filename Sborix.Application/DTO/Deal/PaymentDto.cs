using Entities.Deal;

namespace Sborix.Application.DTO.Deal
{
    public class PaymentDto
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public PaymentMethod Method { get; set; }
        public string? TransactionId { get; set; }
        public DateTime? PaidAt { get; set; }
        public string? FailureReason { get; set; }
    }

    public class CreatePaymentDto
    {
        public Guid BookingId { get; set; }
        public PaymentMethod Method { get; set; }
    }
}
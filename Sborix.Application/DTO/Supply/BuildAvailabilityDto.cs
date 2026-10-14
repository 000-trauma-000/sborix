namespace Sborix.Application.DTO.Supply
{
    public class BuildAvailabilityDto
    {
        public Guid Id { get; set; }
        public Guid BuildId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsAvailable { get; set; }
        public decimal? PricePerDay { get; set; }
        public string? Note { get; set; }
    }

    public class CreateBuildAvailabilityDto
    {
        public Guid BuildId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsAvailable { get; set; }
        public decimal? PricePerDay { get; set; }
        public string? Note { get; set; }
    }
}
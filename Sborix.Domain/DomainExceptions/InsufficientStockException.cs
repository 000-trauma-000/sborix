namespace Entities.DomainExceptions
{
    /// <summary>Запрошенного количества нет в наличии.</summary>
    public class InsufficientStockException : DomainException
    {
        public InsufficientStockException(string itemName, int requestedQuantity, int availableQuantity)
            : base($"Недостаточно «{itemName}» в наличии: запрошено {requestedQuantity}, доступно {availableQuantity}.")
        {
            ItemName = itemName;
            RequestedQuantity = requestedQuantity;
            AvailableQuantity = availableQuantity;
        }

        public string ItemName { get; }
        public int RequestedQuantity { get; }
        public int AvailableQuantity { get; }
    }
}
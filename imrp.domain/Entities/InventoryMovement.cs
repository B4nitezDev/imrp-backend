
namespace imrp.domain.Entities
{
    public class InventoryMovement
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public string MovementType { get; set; }
        public DateTime MovementDate { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}

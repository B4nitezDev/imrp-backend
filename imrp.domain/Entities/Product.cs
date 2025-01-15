
namespace imrp.domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Current_amount { get; set; }
        public int Minimum_amount { get; set; }
        public int AverageDailyConsumption { get; set; }
        public DateTime DaysLeft { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Status { get; set; }
        public List<InventoryMovement> InventoryMovement { get; set; }
    }
}

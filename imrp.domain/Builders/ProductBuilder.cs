
using imrp.domain.Enums;

namespace imrp.domain.Builders
{
    public class ProductBuilder
    {
        private int _id;
        private string _sku;
        private string _name;
        private string _description;
        private ProductCategory _category;
        private int _current_amount;
        private int _minimum_amount;
        private int _averageDailyConsumption;
        private DateTime _daysLeft;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private ProductStatus _status;
        private List<Entities.InventoryMovement> _inventoryMovement = [];

        public ProductBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public ProductBuilder WithSku(string sku)
        {
            _sku = sku;
            return this;
        }

        public ProductBuilder WithName(string name) {
            _name = name;
            return this;
        }

        public ProductBuilder WithDescription(string description) {
            _description = description;
            return this;
        }

        public ProductBuilder WithCategory(ProductCategory category) {
            _category = category;
            return this;
        }

        public ProductBuilder WithCurrentAmount(int current_amount)
        {
            _current_amount = current_amount;
            return this;
        }

        public ProductBuilder WithMinimumAmount(int minimum_amount)
        {
            _minimum_amount = minimum_amount;
            return this;
        }

        public ProductBuilder WithAverageDailyConsumption(int averageDailyConsumption)
        {
            _averageDailyConsumption = averageDailyConsumption;
            return this;
        }

        public ProductBuilder WithDaysLeft(DateTime daysLeft)
        {
            _daysLeft = daysLeft;
            return this;
        }

        public ProductBuilder WithCreatedAt(DateTime? createdAt)
        {
            _createdAt = createdAt ?? DateTime.Now;
            return this;
        }

        public ProductBuilder WithUpdatedAt(DateTime? updatedAt)
        {
            _updatedAt = updatedAt ?? DateTime.Now;
            return this;
        }

        public ProductBuilder WithStatus(ProductStatus status)
        {
            _status = status;
            return this;
        }

        public ProductBuilder AddInventoryMovement(Entities.InventoryMovement inventoryMovement)
        {
            _inventoryMovement.Add(inventoryMovement);
            return this;
        }

        public Entities.Product Build()
        {
            return new Entities.Product
            {
                Id = _id,
                Sku = _sku,
                Name = _name,
                Description = _description,
                Category = _category,
                Current_amount = _current_amount,
                Minimum_amount = _minimum_amount,
                AverageDailyConsumption = _averageDailyConsumption,
                DaysLeft = _daysLeft,
                CreatedAt = _createdAt,
                UpdatedAt = _updatedAt,
                Status = _status,
                InventoryMovement = _inventoryMovement
            };
        }
    }
}

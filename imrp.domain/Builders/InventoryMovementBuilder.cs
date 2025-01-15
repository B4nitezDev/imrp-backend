
using imrp.domain.Entities;

namespace imrp.domain.Builders
{
    public class InventoryMovementBuilder
    {
        private int _id;
        private string _sku;
        private string _productName;
        private int _productQuantity;
        private string _movementType;
        private DateTime _movementDate;
        private int _productId;
        private int _userId;

        public InventoryMovementBuilder WithId(int id)
        {
            _id = id;
            return this;
        }

        public InventoryMovementBuilder WithSku(string sku)
        {
            _sku = sku;
            return this;
        }

        public InventoryMovementBuilder WithProductName(string productName)
        {
            _productName = productName;
            return this;
        }

        public InventoryMovementBuilder WithProductQuantity(int productQuantity)
        {
            _productQuantity = productQuantity;
            return this;
        }

        public InventoryMovementBuilder WithMovementType(string movementType)
        {
            _movementType = movementType;
            return this;
        }

        public InventoryMovementBuilder WithMovementDate(DateTime movementDate)
        {
            _movementDate = movementDate;
            return this;
        }

        public InventoryMovementBuilder WithProductId(int productId)
        {
            _productId = productId;
            return this;
        }

        public InventoryMovementBuilder WithUserId(int userId)
        {
            _userId = userId;
            return this;
        }

        public InventoryMovement Build()
        {
            return new InventoryMovement
            {
                Id = _id,
                Sku = _sku,
                ProductName = _productName,
                ProductQuantity = _productQuantity,
                MovementType = _movementType,
                MovementDate = _movementDate,
                ProductId = _productId,
                UserId = _userId
            };
        }
    }
}

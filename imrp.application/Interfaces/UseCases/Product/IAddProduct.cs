
using imrp.application.Dto;

namespace imrp.application.Interfaces.UseCases.Product
{
    public interface IAddProduct
    {
        public Result.Result<AddProductDto> Execute(AddProductDto product);
    }
}

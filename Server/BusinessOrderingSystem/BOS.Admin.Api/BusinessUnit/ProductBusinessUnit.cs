using BOS.Admin.Api.DataAccess;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;

namespace BOS.Admin.Api.BusinessUnit
{
    public interface IProductBusinessUnit
    {
        ServiceResponse Add(Product product);
        ServiceResponse Update(Product product);
        ServiceResponse Delete(Product product);
        Task<ServiceResponse<Product>> GetByIdAsync(int id);
    }
    public class ProductBusinessUnit : IProductBusinessUnit
    {
        private readonly IProductDataAccess _productDataAccess;
        public ProductBusinessUnit(IProductDataAccess productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }

        public ServiceResponse Add(Product product)
        {
            var saveChangesValue = _productDataAccess.Add(product);

            if (saveChangesValue > 0)
            {
                return new ServiceResponse(ResponseCode.Success, "Product added successfuly");
            }
            return new ServiceResponse(ResponseCode.Fail, "Error. Failed to add product");

        }

        public ServiceResponse Update(Product product)
        {
            var oldProduct = _productDataAccess.GetByIdAsync(product.Id);
            if (oldProduct.Result == null)
            {
                return new ServiceResponse(ResponseCode.NotFound, "Not found Product object");
            }

            var saveChangesValue = _productDataAccess.Update(product);

            if (saveChangesValue == 0)
            {
                return new ServiceResponse(ResponseCode.Fail, "Error. Failed to updated product");
            }
            return new ServiceResponse(ResponseCode.Success, "Product updated successfuly");

        }

        public ServiceResponse Delete(Product product)
        {
            var oldProduct = _productDataAccess.GetByIdAsync(product.Id);
            if (oldProduct.Result == null)
            {
                return new ServiceResponse(ResponseCode.NotFound, "Not found Product object");
            }

            var saveChangesValue = _productDataAccess.Delete(product);

            if (saveChangesValue == 0)
            {
                return new ServiceResponse(ResponseCode.Fail, "Error. Failed to deleted product");
            }
            return new ServiceResponse(ResponseCode.Success, "Product deleted successfuly");

        }

        public async Task<ServiceResponse<Product>> GetByIdAsync(int id)
        {
            var product = await _productDataAccess.GetByIdAsync(id);
            if (product == null)
            {
                return new ServiceResponse<Product>(ResponseCode.NotFound, "Not found Product object");
            }
            return new ServiceResponse<Product>(ResponseCode.Success, product);
        }
    }
}

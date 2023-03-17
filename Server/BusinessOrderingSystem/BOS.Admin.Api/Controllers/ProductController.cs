using BOS.Admin.Api.BusinessUnit;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BOS.Admin.Api.Controllers
{
    [Route("adminapi/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusinessUnit _productBusinessUnit;
        public ProductController(IProductBusinessUnit productBusinessUnit)
        {
            _productBusinessUnit = productBusinessUnit;
        }

        [HttpPost]
        [Route("Add")]
        public ServiceResponse Add([FromBody] Product product)
        {
            return _productBusinessUnit.Add(product);
        }

        [HttpPost]
        [Route("Update")]
        public ServiceResponse Update([FromBody] Product product)
        {
            return _productBusinessUnit.Update(product);
        }

        [HttpPost]
        [Route("Delete")]
        public ServiceResponse Delete([FromBody] Product product)
        {
            return _productBusinessUnit.Delete(product);
        }

        [HttpGet]
        [Route("GetByIdAsync")]
        public async Task<ServiceResponse<Product>> GetByIdAsync([FromBody] int id)
        {
            return await _productBusinessUnit.GetByIdAsync(id);
        }

    }
}

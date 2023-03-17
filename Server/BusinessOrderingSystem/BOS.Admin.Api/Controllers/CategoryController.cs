using BOS.Admin.Api.BusinessUnit;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BOS.Admin.Api.Controllers
{
    [Route("adminapi/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBusinessUnit _categoryBusinessUnit;
        public CategoryController(ICategoryBusinessUnit categoryBusinessUnit)
        {
            _categoryBusinessUnit = categoryBusinessUnit;
        }

        [HttpPost]
        [Route("Add")]
        public ServiceResponse Add([FromBody] Category category)
        {
            return _categoryBusinessUnit.Add(category);
        }

        [HttpPost]
        [Route("Update")]
        public ServiceResponse Update([FromBody] Category category)
        {
            return _categoryBusinessUnit.Update(category);
        }

        [HttpPost]
        [Route("Delete")]
        public ServiceResponse Delete([FromBody] Category category)
        {
            return _categoryBusinessUnit.Delete(category);
        }

        [HttpGet]
        [Route("GetByIdAsync")]
        public async Task<ServiceResponse<Category>> GetByIdAsync([FromBody] int id)
        {
            return await _categoryBusinessUnit.GetByIdAsync(id);
        }
    }
}

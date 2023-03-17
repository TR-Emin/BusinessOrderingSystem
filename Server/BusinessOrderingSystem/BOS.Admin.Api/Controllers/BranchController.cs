using BOS.Admin.Api.BusinessUnit;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BOS.Admin.Api.Controllers
{
    [Route("adminapi/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchBusinessUnit _branchBusinessUnit;
        public BranchController(IBranchBusinessUnit branchBusinessUnit)
        {
            _branchBusinessUnit = branchBusinessUnit;
        }

        [HttpPost]
        [Route("Add")]
        public ServiceResponse Add([FromBody] Branch branch)
        {
            return _branchBusinessUnit.Add(branch);
        }

        [HttpPost]
        [Route("Update")]
        public ServiceResponse Update([FromBody] Branch branch)
        {
            return _branchBusinessUnit.Update(branch);
        }

        [HttpPost]
        [Route("Delete")]
        public ServiceResponse Delete([FromBody] Branch branch)
        {
            return _branchBusinessUnit.Delete(branch);
        }

        [HttpGet]
        [Route("GetByIdAsync")]
        public async Task<ServiceResponse<Branch>> GetByIdAsync([FromBody] int id)
        {
            return await _branchBusinessUnit.GetByIdAsync(id);
        }
    }
}

using BOS.Admin.Api.BusinessUnit;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BOS.Admin.Api.Controllers
{
    [Route("adminapi/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestBusinessUnit _testBusinessUnit;
        public TestController(ITestBusinessUnit testBusinessUnit)
        {
            _testBusinessUnit = testBusinessUnit;
        }

        [HttpPost]
        [Route("Add")]
        public ServiceResponse<Test> Add([FromBody] Test test)
        {
            return _testBusinessUnit.Add(test);
        }

        [HttpPut]
        [Route("Update")]
        public ServiceResponse<Test> Update([FromBody] Test test)
        {
            return _testBusinessUnit.Update(test);
        }

        [HttpDelete]
        [Route("Delete")]
        public ServiceResponse<Test> Delete([FromBody] Test test)
        {
            return _testBusinessUnit.Delete(test);
        }

        [HttpGet]
        [Route("GetById")]
        public ServiceResponse<Test> GetById([FromBody] int testId)
        {
            return _testBusinessUnit.GetById(testId);
        }

        [HttpGet]
        [Route("GetList")]
        public ServiceResponse<List<Test>> GetList()
        {
            return _testBusinessUnit.GetList();
        }


    }
}

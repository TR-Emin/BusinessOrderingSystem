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
        [Route("AddTest")]
        public ServiceResponse<Test> AddTest([FromBody] Test test)
        {
            return _testBusinessUnit.AddTest(test);
        }
    }
}

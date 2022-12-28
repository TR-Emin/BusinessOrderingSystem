using BOS.Admin.Api.DataAccess;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;

namespace BOS.Admin.Api.BusinessUnit
{
    public interface ITestBusinessUnit
    {
        ServiceResponse<Test> AddTest(Test test);
    }
    public class TestBusinessUnit : ITestBusinessUnit
    {
        private readonly ITestDataAccess _testDataAccess;
        public TestBusinessUnit(ITestDataAccess testDataAccess)
        {
            _testDataAccess = testDataAccess;
        }

        public ServiceResponse<Test> AddTest(Test test)
        {
            var saveChangesValue = _testDataAccess.AddTest(test);

            if (saveChangesValue > 0)
            {
                return new ServiceResponse<Test>(ResponseCode.Success, test,"Test added successfuly");
            }

            return new ServiceResponse<Test>(ResponseCode.Fail, "Error. Error.Could not add test");
        }
    }
}

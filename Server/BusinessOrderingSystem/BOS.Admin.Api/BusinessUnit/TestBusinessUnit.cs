using BOS.Admin.Api.DataAccess;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Infrastructure.Responses.ComplexTypes;
using BOS.Admin.Api.Infrastructure.Responses.Concrete;

namespace BOS.Admin.Api.BusinessUnit
{
    public interface ITestBusinessUnit
    {
        ServiceResponse<Test> Add(Test test);
        ServiceResponse<Test> Update(Test test);
        ServiceResponse<Test> Delete(Test test);
        ServiceResponse<Test> GetById(int testId);
        ServiceResponse<List<Test>> GetList();

    }
    public class TestBusinessUnit : ITestBusinessUnit
    {
        private readonly ITestDataAccess _testDataAccess;
        public TestBusinessUnit(ITestDataAccess testDataAccess)
        {
            _testDataAccess = testDataAccess;
        }

        public ServiceResponse<Test> Add(Test test)
        {
            var saveChangesValue = _testDataAccess.Add(test);

            if (saveChangesValue > 0)
            {
                return new ServiceResponse<Test>(ResponseCode.Success, test,"Test added successfuly");
            }

            return new ServiceResponse<Test>(ResponseCode.Fail, "Error. Error.Could not add test");
        }

        public ServiceResponse<Test> Update(Test test)
        {
            var testEntity = _testDataAccess.GetById(test.Id);
            if (testEntity == null)
            {
                return new ServiceResponse<Test>(ResponseCode.NotFound, "Error. Could not find test object with given id.");
            }

            var saveChangesValue = _testDataAccess.Update(test);
            if (saveChangesValue > 0)
            {
                return new ServiceResponse<Test>(ResponseCode.Success, test, "Test updated successfuly");
            }

            return new ServiceResponse<Test>(ResponseCode.Fail, "Error. Error.Could not update test");
        }

        public ServiceResponse<Test> Delete(Test test)
        {
            var testEntity = _testDataAccess.GetById(test.Id);
            if (testEntity == null)
            {
                return new ServiceResponse<Test>(ResponseCode.NotFound, "Error. Could not find test object with given id.");
            }

            var saveChangesValue = _testDataAccess.Delete(test);
            if (saveChangesValue > 0)
            {
                return new ServiceResponse<Test>(ResponseCode.Success, test, "Test deleted successfuly");
            }

            return new ServiceResponse<Test>(ResponseCode.Fail, "Error. Error.Could not delete test");
        }

        public ServiceResponse<Test> GetById(int testId)
        {
            var testEntity = _testDataAccess.GetById(testId);
            if (testEntity == null)
            {
                return new ServiceResponse<Test>(ResponseCode.NotFound, "Error. Could not find test object with given id.");
            }

            return new ServiceResponse<Test>(ResponseCode.Success, testEntity);

        }

        public ServiceResponse<List<Test>> GetList()
        {
            var testListEntity = _testDataAccess.GetList();

            return new ServiceResponse<List<Test>>(ResponseCode.Success, testListEntity);
            
        }
    }
}

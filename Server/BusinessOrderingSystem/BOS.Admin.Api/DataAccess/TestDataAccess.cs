using BOS.Admin.Api.Infrastructure;
using BOS.Admin.Api.Infrastructure.Model;

namespace BOS.Admin.Api.DataAccess
{
    public interface ITestDataAccess
    {
        int AddTest(Test test);
    }
    public class TestDataAccess : ITestDataAccess
    {
        private readonly BOSContext _bOSContext;
        public TestDataAccess(BOSContext bOSContext)
        {
            _bOSContext = bOSContext;
        }

        public int AddTest(Test test)
        {
            _bOSContext.Tests.Add(test);
            var saveChangesValue = _bOSContext.SaveChanges();
            return saveChangesValue;
        }
    }
}

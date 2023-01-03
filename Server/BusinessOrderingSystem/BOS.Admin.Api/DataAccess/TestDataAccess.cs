using BOS.Admin.Api.Infrastructure;
using BOS.Admin.Api.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace BOS.Admin.Api.DataAccess
{
    public interface ITestDataAccess
    {
        int Add(Test test);
        int Update(Test test);
        int Delete(Test test);
        Test GetById(int testId);
        List<Test> GetList();

    }
    public class TestDataAccess : ITestDataAccess
    {
        private readonly BOSContext _bOSContext;
        public TestDataAccess(BOSContext bOSContext)
        {
            _bOSContext = bOSContext;
        }

        public int Add(Test test)
        {
            _bOSContext.Tests.Add(test);
            var saveChangesValue = _bOSContext.SaveChanges();
            return saveChangesValue;
        }

        public int Update(Test test)
        {
            _bOSContext.Tests.Update(test);
            var saveChangesValue = _bOSContext.SaveChanges();
            return saveChangesValue;
        }

        public int Delete(Test test)
        {
            _bOSContext.Tests.Remove(test);
            var saveChangesValue = _bOSContext.SaveChanges();
            return saveChangesValue;
        }

        public Test GetById(int testId)
        {
            return _bOSContext.Tests.AsNoTracking().FirstOrDefault(x => x.Id == testId);
        }

        public List<Test> GetList()
        {
            return _bOSContext.Tests.AsNoTracking().ToList();
        }
    }
}

using BOS.Admin.Api.Infrastructure;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Repository;

namespace BOS.Admin.Api.DataAccess
{
    public interface IBranchDataAccess : IGenericRepository<Branch>
    {

    }
    public class BranchDataAccess : GenericRepository<Branch>, IBranchDataAccess
    {
        public BranchDataAccess(BOSContext bOSContext) : base(bOSContext)
        {

        }


        
    }
}

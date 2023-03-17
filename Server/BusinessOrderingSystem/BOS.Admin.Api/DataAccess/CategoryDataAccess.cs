using BOS.Admin.Api.Infrastructure;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Repository;

namespace BOS.Admin.Api.DataAccess
{
    public interface ICategoryDataAccess : IGenericRepository<Category>
    {
    }

    public class CategoryDataAccess : GenericRepository<Category>, ICategoryDataAccess
    {
        public CategoryDataAccess(BOSContext bOSContext) : base(bOSContext)
        {

        }
    }
}

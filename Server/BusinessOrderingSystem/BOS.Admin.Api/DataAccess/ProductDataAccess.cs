using BOS.Admin.Api.Infrastructure;
using BOS.Admin.Api.Infrastructure.Model;
using BOS.Admin.Api.Repository;

namespace BOS.Admin.Api.DataAccess
{
    public interface IProductDataAccess : IGenericRepository<Product>
    {
    }
    public class ProductDataAccess : GenericRepository<Product>, IProductDataAccess
    {
        public ProductDataAccess(BOSContext bOSContext) : base(bOSContext)
        {

        }
    }
}

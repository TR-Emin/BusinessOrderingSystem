namespace BOS.Admin.Api.Infrastructure.Model
{
    public class Product : BOSEntityBase
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsInStock { get; set; }
    }
}

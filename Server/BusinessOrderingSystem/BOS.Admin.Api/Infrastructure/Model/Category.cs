namespace BOS.Admin.Api.Infrastructure.Model
{
    public class Category : BOSEntityBase
    {
        public int ParentId { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public bool IsHasSubcategory { get; set; }
    }
}

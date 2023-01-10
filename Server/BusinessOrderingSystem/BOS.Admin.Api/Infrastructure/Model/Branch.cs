namespace BOS.Admin.Api.Infrastructure.Model
{
    public class Branch : BOSEntityBase
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

namespace BOS.Admin.Api.Infrastructure.Model
{
    public class Tenant : BOSEntityBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}

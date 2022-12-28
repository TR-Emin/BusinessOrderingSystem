using Npgsql;

namespace BOS.Admin.Api.Infrastructure
{
    public class ConnectionStringBuilder
    {
        private readonly IConfiguration _configuration;

        public ConnectionStringBuilder(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public string GetConnectionString()
        {
            var connStringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = _configuration["GoogleSql:Host"],
                Port = Convert.ToInt32(_configuration["GoogleSql:Port"]),
                Username = _configuration["GoogleSql:Username"],
                Password = _configuration["GoogleSql:Password"],
                Database = _configuration["GoogleSql:Database"],
                SearchPath = _configuration["GoogleSql:SearchPath"],
            };
            return connStringBuilder.ConnectionString;
        }
    }
}

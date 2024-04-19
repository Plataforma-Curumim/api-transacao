using api_cadastro.Adapters.Outbound.Database.Postgres;
using api_cadastro.Domain.Core.Ports.Outbound.DB;

namespace api_cadastro.Adapters.Outbound.Database.Configuration
{
    public static class ConfigurationDBService
    {
        public static IServiceCollection AddDBService(IServiceCollection _service)
        {
            _service.AddSingleton<IDBConnection, PostgresConnection>();
            _service.AddScoped<IDBRepository, PostgresRepository>();
            return _service;
        }
    }
}

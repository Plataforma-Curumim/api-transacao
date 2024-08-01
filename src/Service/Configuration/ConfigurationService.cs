using api_transacao.Adapters.Outbound.Database.Configuration;
using api_transacao.Domain.Core.Ports.Inbound.UseCases;
using api_transacao.Domain.Core.Ports.Inbound.UseCases.Configuration;
using api_transacao.Domain.UseCases;

namespace api_transacao.Service.Configuration
{
    public class ConfigurationService
    {
        private readonly IConfiguration _configuration;
        private readonly IServiceCollection _service;

        public ConfigurationService(IServiceCollection services, IConfiguration configuration)
        {
            _configuration = configuration;
            _service = services;

        }
        public void AddServices()
        {

            UseCaseConfigurationService.AddUseCase(_service);
            ConfigurationDBService.AddDBService(_service);


            #region AppSetings
            //_service.Configure<AppSettings>(_configuration);
            //_service.Configure<SQLServerSettings>(_configuration.GetSection("SQLServerSettings"));
            #endregion
        }
    }
}

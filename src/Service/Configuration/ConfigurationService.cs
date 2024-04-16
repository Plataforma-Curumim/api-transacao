using api_cadastro.Domain.Core.Ports.Inbound.UseCases;
using api_cadastro.Domain.UseCases;

namespace api_cadastro.Service.Configuration
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

            #region AppSetings
            //_service.Configure<AppSettings>(_configuration);
            //_service.Configure<SQLServerSettings>(_configuration.GetSection("SQLServerSettings"));
            #endregion

            #region UseCases

           _service.AddScoped<IUseCaseCadastrarUsuario, UseCaseCadastrarUsuario>();

            #endregion

            #region Repositorys

            //_service.AddScoped<ISQLServer, SQLServerService>();

            #endregion
        }
    }
}

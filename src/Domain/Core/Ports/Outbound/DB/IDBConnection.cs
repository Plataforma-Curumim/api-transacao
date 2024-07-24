using api_cadastro.Domain.Core.DTO.Base;

namespace api_cadastro.Domain.Core.Ports.Outbound.DB
{
    public interface IDBConnection
    {
        public Task<BaseReturn> GetConnection();
    }
}

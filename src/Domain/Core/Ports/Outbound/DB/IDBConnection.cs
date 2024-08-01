using api_transacao.Domain.Core.DTO.Base;

namespace api_transacao.Domain.Core.Ports.Outbound.DB
{
    public interface IDBConnection
    {
        public Task<BaseReturn> GetConnection();
    }
}

using api_cadastro.Adapters.Inbound.HTTP.VM;
using api_cadastro.Domain.Core.Ports.Inbound.UseCases;
using api_cadastro.Adapters.Inbound.HTTP.Mapping;
using api_cadastro.Domain.Core.Base;

namespace api_cadastro.Adapters.Inbound.HTTP
{
    public static class HTTPService
    {
        public static void AddRotasHttp(this WebApplication app)
    {
        app.MapPost("/cadastrar-usuario", CadastrarUsuario);
    }
    private static async Task<IResult> CadastrarUsuario(IUseCaseCadastrarUsuario useCase, HttpContext context, RequestUsuario request)
    {
        try
        {
            var response = await useCase.Execute(MappingToTransacao.ToTransacao(request));
            return response.GetResponse();
        }
        catch (Exception ex)
        {
            return new BaseReturn().ErroSistema(ex).GetResponse();
        }
    }
}
}

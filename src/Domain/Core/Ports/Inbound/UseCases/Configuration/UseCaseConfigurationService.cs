﻿using api_cadastro.Adapters.Outbound.Database.Postgres;
using api_cadastro.Domain.Core.Ports.Inbound.UseCases;
using api_cadastro.Domain.Core.Ports.Outbound.DB;
using api_transacao.Domain.UseCases;

namespace api_cadastro.Domain.Core.Ports.Inbound.UseCases.Configuration
{
    public static class UseCaseConfigurationService
    {
        public static IServiceCollection AddUseCase(IServiceCollection _service)
        {
            _service.AddScoped<IUseCaseEmprestimoLivro, UseCaseEmprestimoLivro>();

            return _service;
        }
    }
}
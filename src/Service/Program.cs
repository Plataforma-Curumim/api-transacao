
using api_transacao.Adapters.Inbound.HTTP;
using api_transacao.Service.Configuration;

var builder = WebApplication.CreateBuilder(args);
ConfigurationService configurationService = 
    new ConfigurationService(builder.Services, builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
configurationService.AddServices();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.AddRotasHttp();
app.Run();

﻿using api_cadastro.Domain.Core.DTO.Base;
using api_cadastro.Domain.Core.Ports.Outbound.DB;
using Npgsql;

namespace api_cadastro.Adapters.Outbound.Database.Postgres
{
    public class PostgresConnection : IDBConnection
    {
        private readonly string _connectionString;
        private readonly NpgsqlConnection _connection;
        private readonly bool _isConnect;
        public PostgresConnection(IServiceProvider _provider)
        {
            _isConnect = false;
            //_connectionString = "Host=my_host;Port=port_number;Database=database_name;User Id = username;Password=password;";
            _connectionString = Environment.GetEnvironmentVariable("DATABASE_URL")!;
            _connection = new NpgsqlConnection(_connectionString);
        }

        public async Task<BaseReturn> GetConnection()
        {
            try{
                if (!_isConnect)
                {
                    _connection.Open();
                }
                return new BaseReturn().Sucesso(_connection);
            } catch (Exception ex)
            {
                return new BaseReturn().ErroSistema(ex);
            }
            
        }
    
    }
}

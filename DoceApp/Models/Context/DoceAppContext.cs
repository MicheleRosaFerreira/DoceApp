using Dapper;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace DoceApp.Context
{
	//Faz o processo de conexão com o banco de dados
	public class DoceAppContext 
	{
		private readonly string _connectionString;

		public DoceAppContext()
		{
			SqlMapper.AddTypeMap(typeof(string), System.Data.DbType.AnsiString);
		}
		public SqlConnection GetDoceAppCOnnection()
		{
			var connection = new SqlConnection(_connectionString);
			connection.Open();
			return connection;
		}

		public string GetString()
		{
			return _connectionString;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}

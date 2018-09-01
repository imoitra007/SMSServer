using System;
using System.Data;
using System.Data.SqlClient;
using SMS.DataAccessLayer.Interfaces;
using Dapper;

namespace SMS.DataAccessLayer.Implementation
{
    public class DapperRepository : IDapperRepository, IDisposable
    {
        private readonly string _connectionString =
           @"Data Source=MAHUA-PC\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=true;";

        private readonly IDbConnection _conn;
        public DapperRepository()
        {
            _conn = Connection;
        }

        private string GetConnectionString()
        {
            return _connectionString;
        }
        public IDbConnection Connection
        {
            get
            {
               var connection =  new SqlConnection(GetConnectionString());
               return connection;
            }
        }
        public void Dispose()
        {
            _conn.Close();
        }

        public int Exec(string spName, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public SqlMapper.GridReader Querymultiple(string spName, DynamicParameters param = null)
        {
            return _conn.QueryMultiple(spName, param, commandType: CommandType.StoredProcedure);
        }
    }
}

using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace BOSLib
{
    public class BysSqlDatabase : SqlDatabase
    {
        private IDbConnection _connection = null;

        public IDbConnection Connection
        {
            get => GetCurrentConnection();
            set
            {
                _connection = value;
            }
        }

        public BysSqlDatabase(string connectionString)
            : base(connectionString)
        {

        }

        public IDbConnection GetCurrentConnection()
        {
            return GetOpenConnection().Connection;
        }

        public override DbConnection CreateConnection()
        {
            if (_connection == null)
                _connection = base.CreateConnection();

            if (_connection.State == ConnectionState.Open)
                _connection.Close();

            _connection.ConnectionString = ConnectionString;
            return (DbConnection)_connection;
        }
    }
}

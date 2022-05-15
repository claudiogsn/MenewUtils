using FirebirdSql.Data.FirebirdClient;
using System;

namespace MenewUtils.Domain.DAO
{
    internal class DaoConnection : IDisposable
    {
        public static string PathDb { get; set; }
        public FbConnection Connection { get; set; }
        public DaoConnection()
        {
            var sbConnection = new FbConnectionStringBuilder()
            {
                DataSource = "localhost",
                Database = @"C:\MvarandasTecnologia\Database\NETUNO.FDB",
                Password = "masterkey",
                UserID = "SYSDBA"
            };

            try
            {
                Connection = new FbConnection(sbConnection.ToString());
                Connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar no banco de dados: " + ex.Message);
            }
        }

        public void Dispose()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
            GC.SuppressFinalize(this);
        }
    }
}

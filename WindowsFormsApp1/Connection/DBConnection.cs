using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1.Connection
{
    internal class DBConnection
    {
        public static OracleConnection GetConnection(string username, string password)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            return DBOracleUtils.GetConnection(host, port, sid, username, password);
        }
    }
}

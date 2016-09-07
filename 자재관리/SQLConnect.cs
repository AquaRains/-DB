using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace 자재관리
{
    class SQLConnect
    {
        string connectionStr = "";
        string _sql;
        SqlConnection Connection;
        SqlCommand Command = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public SQLConnect(string _server, string _database , string _user, string _password)
        {
            connectionStr = string.Format("server={0};database={1};user={2};password={3}", _server, _database, _user, _password);
            Connection = new SqlConnection(connectionStr);
            Command.Connection = Connection;
        }

        public bool runsql(string sql,ref DataSet dataset)
        {
            _sql = sql;
            Command.CommandText = _sql;

            try
            {
                adapter.SelectCommand = Command;
                adapter.Fill(ds);
                dataset = ds;
                return true;
            }
            catch(Exception e)
            {
                return false;
                throw;      
            }
            finally
            {
                Connection.Close();
            }

        }
    }
}

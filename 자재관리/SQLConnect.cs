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
        string ConnectionStr = "";
        SqlConnection Connection;
        SqlCommand Command = new SqlCommand();
        SqlDataAdapter adapter;
        SqlCommandBuilder builder = new SqlCommandBuilder();
        public DataTable mydatatable = new DataTable();


        public SQLConnect(string _server, string _database , string _user, string _password)
        {
            ConnectionStr = string.Format("server={0} ; uid = {1} ; pwd = {2} ; database = {3}", _server, _user, _password, _database);
            Connection = new SqlConnection(ConnectionStr);

            Command = Connection.CreateCommand();
            Command.Connection = Connection;

            
        }
        public void SelectandFill(string sql)
        {
            Command.CommandText = sql;
            adapter = new SqlDataAdapter(Command);
            adapter.Fill(mydatatable);
        }

        public void applychange(string sql)
        {
 
            SqlCommand cmd = new SqlCommand(sql);
            cmd = Connection.CreateCommand();
            cmd.CommandText = sql;

            Connection.Open();
            mydatatable.Clear();
            cmd.ExecuteNonQuery();

            adapter.Fill(mydatatable);
            Connection.Close();

            
        }


    }
}

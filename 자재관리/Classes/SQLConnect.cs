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
        const string _server = "127.0.0.1";
        const string _uid = "mytest01";
        const string _pwd = "123!@#";
        const string _dbname = "자재관리DB";
        



        string ConnectionStr = "";
        SqlConnection Connection;
        SqlCommand Command = new SqlCommand();
        SqlDataAdapter adapter;
        SqlCommandBuilder builder = new SqlCommandBuilder();
        public DataTable mydatatable = new DataTable();

        public bool connectcheck()
        {
            bool state = false;
            try
            {
                Connection.Open();
                state = true;

            }
            catch (Exception ex)
            {
                state = false;
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();

            }

            return state;
        }


        public SQLConnect()
        {
            ConnectionStr = string.Format("server={0} ; uid = {1} ; pwd = {2} ; database = {3}", _server, _uid, _pwd, _dbname);
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

        public void transactRun(string sql)
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

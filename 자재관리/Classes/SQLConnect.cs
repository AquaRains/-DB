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
        //접속에 관련된 기본 값 세팅
#if DEBUG
        const string _server = "suwoo1.database.windows.net";
        const string _uid = "suwoo"; //현재 최고관리자 계정으로 세팅해놓았으니 조심해주세요...
        const string _pwd = "LastArea7564";
        const string _dbname = "db1"; 
#else
        const string _server = "suwoo1.database.windows.net";
        const string _uid = "suwoo";
        const string _pwd = "LastArea7564";
        const string _dbname = "db1"; 
#endif


        string ConnectionStr = "";
        SqlConnection Connection;
        public SqlCommand Command = new SqlCommand();
        public SqlDataAdapter adapter;
        public DataTable datatable;
        


        /// <summary>
        /// 이 클래스의 생성자입니다. conenction을 초기화 합니다
        /// </summary>
        public SQLConnect()
        {
            ConnectionStr = string.Format("server={0} ; uid = {1} ; pwd = {2} ; database = {3}", _server, _uid, _pwd, _dbname);
            Connection = new SqlConnection(ConnectionStr);

            Command = Connection.CreateCommand();
            Command.Connection = Connection;
  
        }

        /// <summary>
        /// DB와 접속이 가능한지 체크합니다 : Debug에서만 사용...
        /// </summary>
        /// <returns></returns>
        public static bool ConnectionCheck()
        {
            string ConnectionStr = string.Format("server={0} ; uid = {1} ; pwd = {2} ; database = {3}", _server, _uid, _pwd, _dbname);
            SqlConnection Connection = new SqlConnection(ConnectionStr);

            SqlCommand Command = Connection.CreateCommand();
            Command.Connection = Connection;
  
            bool state = false;
            try
            {
                Connection.Open();
                state = true;
                System.Windows.Forms.MessageBox.Show("접속 가능");
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

        /// <summary>
        /// SQL구문을 이용해서 adapter에 fill합니다. (보통 Table단위로 Select하게 됨)
        /// </summary>
        /// <param name="sql">SQL 구문 입력</param>
        public void SelectandFill(string sql)
        {
            datatable = new DataTable();
            Command.CommandType = CommandType.Text;
            Command.CommandText = sql;
            
            adapter = new SqlDataAdapter(Command);
            datatable.Clear();
            adapter.Fill(datatable);
  

        }


        /// <summary>
        /// stored procedure 호출합니다.
        /// </summary>
        /// <param name="sql">sql 구문</param>
        public void transactRun(string sql, SqlParameter[] parameters)
        {
            Command = new SqlCommand(sql,Connection);
            Command.CommandType = CommandType.StoredProcedure;
            if (parameters.Length > 0)
            Command.Parameters.AddRange(parameters);
            Connection.Open();
            Command.ExecuteNonQuery(); 
            Connection.Close();
            datatable.Clear();
            adapter.Fill(datatable);
            
        }


        public void transactRun(string sql)
        {
            
            
            Command = Connection.CreateCommand();
            
            Command.CommandText = sql;
            Command.CommandType = CommandType.Text;
            Connection.Open();
            datatable.Clear();
            Command.ExecuteNonQuery();  // 단일문 실행용 메서드

            adapter.Fill(datatable);
            Connection.Close();
            
        }


    }
}

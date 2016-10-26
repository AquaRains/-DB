using System;
using System.Data;
using System.Windows.Forms;

namespace 자재관리.Forms
{
    public partial class 고객추가 : Form
    {
        SQLConnect dbconnect;
        DataTable dt = new DataTable("customers");

        #region 생성자및 선언부
        static 고객추가 Thisform = null;
        static object _Thisform = new object();
        private 고객추가()
        {
            InitializeComponent();
            dbconnect = new SQLConnect();
        }
        public static 고객추가 instance //doublecheck lock singleton
        {
            get
            {
                if (Thisform == null || Thisform.IsDisposed)
                {
                    lock (_Thisform)
                    {
                        if (Thisform == null || Thisform.IsDisposed)
                        {
                            Thisform = new 고객추가();
                            return Thisform;
                        }
                    }

                }

                return Thisform;


            }
        } 
        #endregion
        private void 고객추가_Load(object sender, EventArgs e)
        {
            dtfill();
            dataGridView1.DataSource = dt;
            
            txt이름.DataBindings.Add("Text", dt,dt.Columns[1].ColumnName);
            txt대표자.DataBindings.Add("Text", dt, dt.Columns[2].ColumnName);
            txt전화번호.DataBindings.Add("Text", dt, dt.Columns[3].ColumnName);
            txt메모.DataBindings.Add("Text", dt, dt.Columns[4].ColumnName);


        }
        private void dtfill()
        {

            this.dt = SQLConnect.SelectandFill("SELECT * FROM dbo.customers");
        }
        private void button1_Click(object sender, EventArgs e)//닫기버튼
        {
            this.Close();
        } 
        private void button2_Click(object sender, EventArgs e) //추가 버튼
        {
            System.Data.SqlClient.SqlParameterCollection parameters = dbconnect.Command.Parameters;
            parameters.Add(new System.Data.SqlClient.SqlParameter("customer_name", txt대표자.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("customer_company", txt이름.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("customer_phonenum", txt전화번호.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("memo", txt메모.Text));

            dbconnect.transactRun("customers_insert");
        }
        private void button3_Click(object sender, EventArgs e)// 삭제 버튼
        {

            System.Data.SqlClient.SqlParameterCollection parameters = dbconnect.Command.Parameters;
            parameters.Add(new System.Data.SqlClient.SqlParameter("customer_name", txt대표자.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("customer_company", txt이름.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("customer_phonenum", txt전화번호.Text));

            dbconnect.transactRun("customers_delete");
        }
    }
}

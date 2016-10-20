using System;
using System.Data;
using System.Windows.Forms;

namespace 자재관리.Forms
{
    public partial class 고객추가 : Form
    {
        SQLConnect dbconnect;
        DataTable dt = new DataTable("customers");

        static 고객추가 Thisform = null;
        static object _Thisform = new object();
        private 고객추가()
        {
            InitializeComponent();
            dbconnect = new SQLConnect();
        }
        public static 고객추가 instance //doublecheck lock
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


        private void 고객추가_Load(object sender, EventArgs e)
        {
            this.dt = dbconnect.SelectandFill("SELECT * FROM dbo.customers");
            dataGridView1.DataSource = dt;
            

            txt이름.DataBindings.Add("Text", dt,dt.Columns[1].ColumnName);
            txt대표자.DataBindings.Add("Text", dt, dt.Columns[2].ColumnName);
            txt전화번호.DataBindings.Add("Text", dt, dt.Columns[3].ColumnName);
            txt메모.DataBindings.Add("Text", dt, dt.Columns[4].ColumnName);


        }
        /// <summary>
        /// 닫기 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 추가 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlParameter[] parameters = {new System.Data.SqlClient.SqlParameter("@customer_compnay", txt이름.Text),
                                                                    new System.Data.SqlClient.SqlParameter("@customer_name", txt대표자.Text),
                                                                    new System.Data.SqlClient.SqlParameter("@customer_phonenum", txt전화번호.Text),
                                                                    new System.Data.SqlClient.SqlParameter("@memo", txt메모.Text)};


            dbconnect.transactRun("exec customers_insert", parameters);
            // dbconnect.Command.Parameters.AddWithValue();
        }


        /// <summary>
        /// 삭제 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}

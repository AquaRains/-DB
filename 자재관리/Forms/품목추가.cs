using System;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace 자재관리.Forms
{
    public partial class 품목추가 : Form
    {
        static 품목추가 Thisform = null;
        static object _Thisform = new object();
        SQLConnect connect;
        System.Data.DataTable dt;
        private 품목추가()
        {
            InitializeComponent();
        }
        static 품목추가() { }
        public static 품목추가 instance //doublecheck lock
        {
            get
            {
                if (Thisform == null || Thisform.IsDisposed)
                {
                    lock (_Thisform)
                    {
                        if (Thisform == null || Thisform.IsDisposed)
                        {
                            Thisform = new 품목추가();
                            return Thisform;
                        }
                    }

                }

                return Thisform;


            }
        }


        private void 품목추가_Load(object sender, EventArgs e)
        {
           
            connect = new SQLConnect();
           dt = SQLConnect.SelectandFill("SELECT * FROM products");
           
            dataGridView1.DataSource = dt;

            txt품목명.DataBindings.Add("text",dt,"product_name");
            txt제조회사.DataBindings.Add("text", dt, "product_company");
            txt규격.DataBindings.Add("Text", dt, "product_scale");
            txt가격.DataBindings.Add("text", dt, "product_price");
            chk취급주의.DataBindings.Add("Checked", dt, "product_isdanger" );
         
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameterCollection parameters = connect.Command.Parameters;
                parameters.Add(new SqlParameter("product_name",txt품목명.Text));
                parameters.Add(new SqlParameter("product_company", txt제조회사.Text));
                parameters.Add(new SqlParameter("product_type", txt종류.Text));
                parameters.Add(new SqlParameter("product_scale", txt규격.Text));
                parameters.Add(new SqlParameter("product_price", txt가격.Text));
                parameters.Add(new SqlParameter("product_isdanger", chk취급주의.Checked ? 1 : 0));
                connect.transactRun("products_insert");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? index = dataGridView1.SelectedColumns[0].DisplayIndex;

            SqlParameterCollection parameters = connect.Command.Parameters;
            parameters.Add(new SqlParameter("product_id", index));
            connect.transactRun("products_delete");
        }
    }
}

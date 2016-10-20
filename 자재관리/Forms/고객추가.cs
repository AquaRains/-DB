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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

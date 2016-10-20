using System;

using System.Windows.Forms;

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
            /*
            connect = new SQLConnect();
            dt = connect.SelectandFill("SELECT * FROM 품목");
            dataGridView1.DataSource = dt;

            txt품목명.DataBindings.Add("text",dt,dt.Columns[1].ColumnName);
            txt제조회사.DataBindings.Add("text", dt, dt.Columns[2].ColumnName);
            txt가격.DataBindings.Add("text", dt, dt.Columns[3].ColumnName);
            chk취급주의.DataBindings.Add("Checked", dt, dt.Columns[4].ColumnName);
             * */
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.transactRun(string.Format("INSERT INTO 품목 ({0},{1},{2},{3}) VALUES ('{4}','{5}','{6}',{7})",
                                                dt.Columns[1].ColumnName,
                                                dt.Columns[2].ColumnName,
                                                dt.Columns[3].ColumnName,
                                                dt.Columns[4].ColumnName,
                                                txt품목명.Text, txt제조회사.Text, txt가격.Text, chk취급주의.Checked?1:0
                                                 ));

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 자재관리.Forms
{
    public partial class 지역 : Form
    {
        static 지역 Thisform = null;
        static object _Thisform = new object();
        SQLConnect connect;
        private 지역()
        {
            InitializeComponent();
        }
        static 지역() { }
        public static 지역 instance //doublecheck lock
        {
            get
            {
                if (Thisform == null || Thisform.IsDisposed)
                {
                    lock (_Thisform)
                    {
                        if (Thisform == null || Thisform.IsDisposed)
                        {
                            Thisform = new 지역();
                            return Thisform;
                        }
                    }
                    
                }

                return Thisform;
            

            }
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 지역_Load(object sender, EventArgs e)
        {
            connect = new SQLConnect("127.0.0.1", "자재관리DB", "sa", "sapass");
            connect.SelectandFill("SELECT * FROM 지역");
            dataGridView1.DataSource = connect.mydatatable;

            txt지역코드.DataBindings.Add("text", connect.mydatatable,connect.mydatatable.Columns[0].ColumnName);
            txt지역명.DataBindings.Add("text", connect.mydatatable, connect.mydatatable.Columns[1].ColumnName);
        }

        private void btn추가_Click(object sender, EventArgs e)
        {

            connect.applychange(string.Format("INSERT INTO 지역 ({0}) VALUES ('{1}')",
                                                   connect.mydatatable.Columns[1].ColumnName,
                                                   txt지역명.Text));
        }

        private void btn지역제거_Click(object sender, EventArgs e)
        {
            string sql = string.Format("DELETE FROM 지역 WHERE [{0}] = '{1}'",connect.mydatatable.Columns[0].ColumnName,txt지역코드.Text);
            connect.applychange(sql);
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE 지역 SET {0} = '{1}' WHERE {2} = {3}",connect.mydatatable.Columns[1],
                                                                                    txt지역명.Text,
                                                                                    connect.mydatatable.Columns[0],
                                                                                    txt지역코드.Text);
            connect.applychange(sql);
        }

    }
}

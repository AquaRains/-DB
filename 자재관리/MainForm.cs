using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 자재관리
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void 직원ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void 닫기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 물품ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.품목추가 form = Forms.품목추가.instance;
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            btnConCheck.Visible = true;
#endif
        }

        private void btnConCheck_Click(object sender, EventArgs e)
        {
            SQLConnect.ConnectionCheck();
        }

        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.고객추가 form = Forms.고객추가.instance;
            form.MdiParent = this;
            form.Show();

        }

        private void 장부작성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.입출고등록 form = Forms.입출고등록.instance;
            form.MdiParent = this;
            form.Show();
        }


    }
}

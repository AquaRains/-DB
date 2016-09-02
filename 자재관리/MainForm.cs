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

        private void 지역추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.지역 지역form = Forms.지역.instance;
            지역form.MdiParent = this;
            지역form.Show();
        }

        private void 직원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.직원추가 form = Forms.직원추가.instance;
            form.MdiParent = this;
            form.Show();
        }

        private void 닫기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 장부작성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.거래장부작성 form = Forms.거래장부작성.Instance;
            form.MdiParent = this;
            form.Show();
        }
    }
}

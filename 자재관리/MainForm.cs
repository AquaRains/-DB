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
            Forms.지역 지역form = Forms.지역.Getinstance;
            지역form.MdiParent = this;
            지역form.Show();
        }
    }
}

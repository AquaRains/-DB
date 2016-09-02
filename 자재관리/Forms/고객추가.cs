using System;

using System.Windows.Forms;

namespace 자재관리.Forms
{
    public partial class 고객추가 : Form
    {
        public 고객추가()
        {
            InitializeComponent();
        }

        private void 고객추가_Load(object sender, EventArgs e)
        {
          

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
      

        }
    }
}

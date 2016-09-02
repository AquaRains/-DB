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
    public partial class 거래장부작성 : Form
    {
        public 거래장부작성()
        {
            InitializeComponent();
        }

        private void 거래장부작성_Load(object sender, EventArgs e)
        {



        }

   

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt지역.Text = listBox2.Text;
        }

        private void btn추가_Click(object sender, EventArgs e)
        {
  
        }

        private void btn지역추가_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn거래처창열기_Click(object sender, EventArgs e)
        {
            
        }

        private void btn제거_Click(object sender, EventArgs e)
        {
           
        }
    }
}

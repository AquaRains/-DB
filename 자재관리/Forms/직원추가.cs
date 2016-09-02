
using System.Windows.Forms;


using System.Drawing;
using System.IO;

namespace 자재관리
{
    public partial class 직원추가 : Form
    {
        public 직원추가()
        {
            InitializeComponent();
        }

        private void 직원추가_Load(object sender, System.EventArgs e)
        {

            // TODO: 이 코드는 데이터를 'GASDataSet.직원' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.

            listBox1.Refresh();
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
         
            
            
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

 
            
        }

        private void 직원BindingSource_CurrentChanged(object sender, System.EventArgs e)
        {

        }

        private void 직원추가_FormClosed(object sender,System.EventArgs e)
        {

        }

        private void datachange(object sender, System.EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}

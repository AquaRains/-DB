using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace 자재관리.Forms
{
    public partial class 직원추가 : Form
    {
        static 직원추가 thisform = new 직원추가();
        static object _thisform = new object();
        DataSet dataset = new DataSet();

        private 직원추가()
        {
            InitializeComponent();
            selfInit();
        }

        void selfInit()
        {
            openFileDialog1.FileOk += (o, v) =>
            {
                try
                {
                    string s = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(s);
                    s = "";

                }
                catch (System.Exception ex)
                {

                    throw ex;
                }
            }; //그림 불러오기 이벤트 추가
            SQLConnect 직원connect = new SQLConnect("localhost:1455", "자재관리DB", "sa", "sapass");
            직원connect.runsql("SELECT * FROM 직원", ref dataset);
            listBox1.DataSource = dataset;

            
        }
        public static 직원추가 instance
            {
            get
            {
                if(thisform == null || thisform.IsDisposed)
                {
                    lock(_thisform)
                    {
                        if(thisform == null || thisform.IsDisposed)
                        {
                            thisform = new 직원추가();
                            return thisform;
                        }
                        return thisform;
                    }
                }
                return thisform;
            }
             }

        private void 직원추가_Load(object sender, System.EventArgs e)
        {




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
            openFileDialog1.ShowDialog(this.MdiParent);
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            
            openFileDialog1.ShowDialog(this.MdiParent);
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
        직원목록 목록 = 직원목록.instance;
            목록.MdiParent = MdiParent;
        목록.Show();
        }


    }
}

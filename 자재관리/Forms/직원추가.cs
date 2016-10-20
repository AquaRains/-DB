using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace 자재관리.Forms
{
    public partial class 직원추가 : Form
    {
        static 직원추가 thisform = null;
        static object _thisform = new object();
        DataRow curruntrow;

        SQLConnect connect = new SQLConnect();
        DataTable dt = new DataTable();
        

        private 직원추가()
        {
            InitializeComponent();
            Init();
        }

        void Init()
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

            //this.dt = connect.SelectandFill("SELECT * FROM dbo.직원");

            /*
            listBox1.DataBindings.Add("DataSource", dt, dt.TableName);
            listBox1.DataBindings.Add("DisplayMember",dt,"성명");
            txtID.DataBindings.Add("Text", dt, "ID");
            txt이름.DataBindings.Add("Text", dt, "성명");
            txt전번.DataBindings.Add("Text", dt, "전화번호");
            txt주민.DataBindings.Add("Text", dt, "생년월일");
            txt면허.DataBindings.Add("Text", dt, "면허번호");
            txt경력.DataBindings.Add("Text", dt, "경력");
            txt현주소.DataBindings.Add("Text", dt, "주소");
            txt비고.DataBindings.Add("Text", dt, "비고");
            pictureBox1.DataBindings.Add("Image", dt, "image");                                                                                                                                                                                                                       

           listBox1.Refresh();
            
            */
            
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

        }


    }
}

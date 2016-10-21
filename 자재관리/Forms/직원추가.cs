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
            /*
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
            }; //그림 불러오기 이벤트 추가*/
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

            connect.SelectandFill("SELECT * FROM dbo.empolyee");
            this.dt = connect.datatable;

            listBox1.DataBindings.Add("DataSource", dt, dt.TableName);
            listBox1.DataBindings.Add("DisplayMember",dt,"empolyee_Name");
            txtID.DataBindings.Add("Text", dt, "empolyee_ID");
            txt이름.DataBindings.Add("Text", dt, "empolyee_Name");
            txt전번.DataBindings.Add("Text", dt, "empolyee_Phone");
            txt현주소.DataBindings.Add("Text", dt, "empolyee_address");
            txt비고.DataBindings.Add("Text", dt, "empolyee_extr");
            //pictureBox1.DataBindings.Add("Image", dt, "image");                                                                                                                                                                                                                       

           listBox1.Refresh();
        }



        private void btnclose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn삭제_Click(object sender, System.EventArgs e)
        {
            System.Data.SqlClient.SqlParameterCollection parameters = new System.Data.SqlClient.SqlParameterCollection();
            parameters.Add(new System.Data.SqlClient.SqlParameter("empolyee_ID", listBox1.SelectedIndex));
            connect.transactRun("empolyee_delete", parameters);
        }

        private void btn신규_Click(object sender, System.EventArgs e)
        {
            System.Data.SqlClient.SqlParameterCollection parameters = new System.Data.SqlClient.SqlParameterCollection(); 
            parameters.Add(new System.Data.SqlClient.SqlParameter("empolyee_Name",txt이름.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("empolyee_Phone",txt전번.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("empolyee_address",txt현주소.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("empolyee_extr", txt비고.Text));
           
            connect.transactRun("empolyee_insert",parameters);
        }




    }
}

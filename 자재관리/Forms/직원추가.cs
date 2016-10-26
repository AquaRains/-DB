using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace 자재관리.Forms
{
    public partial class 직원추가 : Form
    {
        static 직원추가 thisform = null;
        static object _thisform = new object();


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


            this.dt = SQLConnect.SelectandFill("SELECT * FROM employee");
            dt.TableName = "employee";

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "employee_Name";
          //  listBox1.DataBindings.Add("DataSource", dt, dt.TableName);
           // listBox1.DataBindings.Add("DisplayMember",dt,"employee_Name");
            txtID.DataBindings.Add("Text", dt, "employee_ID");
            txt이름.DataBindings.Add("Text", dt, "employee_Name");
            txt전번.DataBindings.Add("Text", dt, "employee_Phone");
            txt현주소.DataBindings.Add("Text", dt, "employee_address");
            txt비고.DataBindings.Add("Text", dt, "employee_extr");
            //pictureBox1.DataBindings.Add("Image", dt, "image");                                                                                                                                                                                                                       

           listBox1.Refresh();
        }



        private void btnclose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn삭제_Click(object sender, System.EventArgs e)
        {
            System.Data.SqlClient.SqlParameterCollection parameters = connect.Command.Parameters;
            parameters.Add(new System.Data.SqlClient.SqlParameter("employee_ID", txtID.Text));
            connect.transactRun("employee_delete");
        }

        private void btn신규_Click(object sender, System.EventArgs e)
        {
            System.Data.SqlClient.SqlParameterCollection parameters = connect.Command.Parameters; 
            parameters.Add(new System.Data.SqlClient.SqlParameter("employee_Name",txt이름.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("employee_Phone",txt전번.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("employee_address",txt현주소.Text));
            parameters.Add(new System.Data.SqlClient.SqlParameter("employee_extr", txt비고.Text));
           
            connect.transactRun("employee_insert");
        }




    }
}

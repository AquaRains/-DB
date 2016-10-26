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
    public partial class 입출고등록 : Form
    {
        static 입출고등록 thisform = null;
        static object _thisform = new object();
        SQLConnect connect = new SQLConnect();
        DataTable dt = new DataTable();
        DataTable dt_product = new DataTable();
        DataTable dt_employee = new DataTable();
        private 입출고등록()
        {
            InitializeComponent();
        }
        public static 입출고등록 instance
        {
            get
            {
                if (thisform == null || thisform.IsDisposed)
                {
                    lock (_thisform)
                    {
                        if (thisform == null || thisform.IsDisposed)
                        {
                            thisform = new 입출고등록();
                            return thisform;
                        }
                        return thisform;
                    }
                }
                return thisform;
            }
        }


        SQLConnect connect_inout = new SQLConnect();

        private void 입출고등록_Load(object sender, EventArgs e)
        {

            dt = SQLConnect.SelectandFill("inout_select");
            datagridview.DataSource = dt;
            refreshcmblist();
            cmb_employee.DataSource = dt_employee;
            cmb_employee.DisplayMember = dt_employee.Columns["employee_Name"].ColumnName;
            cmb_employee.ValueMember = dt_employee.Columns["employee_ID"].ColumnName;
            cmb_product.DataSource = dt_product;
            cmb_product.DisplayMember = "product_name";
            cmb_product.ValueMember = "product_id";
        }

        private void refreshcmblist()
        {



            dt_product = SQLConnect.SelectandFill(@"SELECT product_id, product_name from [dbo].products");
            dt_employee = SQLConnect.SelectandFill(@"SELECT employee_ID, employee_Name from [dbo].employee");
        }


    }
}

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



    }
}

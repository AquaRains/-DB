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
    public partial class 직원목록 : Form
    {
        static 직원목록 thisform = new 직원목록();
        static object _thisform = new object();
        private 직원목록()
        {
            InitializeComponent();
        }

        public static 직원목록 instance
        {
            get
            {
                if (thisform == null || thisform.IsDisposed)
                {
                    lock(_thisform)
                    {
                        if (thisform == null || thisform.IsDisposed)
                        {
                            thisform = new 직원목록();
                            return thisform;
                        }
                        return thisform;
                    }
                }
                return thisform;
            }
        }
    }
}

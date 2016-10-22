using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace 자재관리
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn물품_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.품목추가 form = Forms.품목추가.instance;
            form.MdiParent = this;
            form.Show();
        }

        private void btn지역_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.지역 지역form = Forms.지역.instance;
            지역form.MdiParent = this;
            지역form.Show();
        }
    }
}
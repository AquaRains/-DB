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
    public partial class 지역 : Form
    {
        static 지역 Thisform = null;
        static object _Thisform = new object();
        private 지역()
        {
            InitializeComponent();
        }
        static 지역() { }
        public static 지역 Getinstance
        {
            get
            {
                if (Thisform == null || Thisform.IsDisposed)
                {
                    lock (_Thisform)
                    {
                        if (Thisform == null || Thisform.IsDisposed)
                        {
                            Thisform = new 지역();
                            return Thisform;
                        }
                    }
                    
                }

                return Thisform;
            

            }
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 지역_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 '자재관리DBDataSet.지역' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.지역TableAdapter.Fill(this.자재관리DBDataSet.지역);

        }

        private void btn추가_Click(object sender, EventArgs e)
        {
            this.자재관리DBDataSet.지역.Add지역Row(txt지역명.Text);
            지역AcceptAndUpdate();
        }

        private void btn지역제거_Click(object sender, EventArgs e)
        {
            this.자재관리DBDataSet.지역.Remove지역Row(자재관리DBDataSet.지역[int.Parse(txt지역코드.Text)-1]);
            지역AcceptAndUpdate();
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            this.자재관리DBDataSet.지역[int.Parse(txt지역코드.Text)-1].지역명 = txt지역명.Text;
            지역AcceptAndUpdate();
        }
        private void 지역AcceptAndUpdate()
        {
            지역TableAdapter.Update(자재관리DBDataSet.지역);
            자재관리DBDataSet.지역.AcceptChanges();
            
          
            //지역TableAdapter.Fill(this.자재관리DBDataSet.지역);
        }
    }
}

namespace 자재관리.Forms
{
    partial class 직원추가
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt전번 = new System.Windows.Forms.TextBox();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.lb비고 = new System.Windows.Forms.Label();
            this.btn신규 = new System.Windows.Forms.Button();
            this.txt비고 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt이름 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl현주소 = new System.Windows.Forms.Label();
            this.txt현주소 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 340);
            this.listBox1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "목록";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "이미지 파일|*.jpg;*.jpeg;*.bmp;*.png";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt전번);
            this.groupBox1.Controls.Add(this.btn닫기);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn삭제);
            this.groupBox1.Controls.Add(this.lb비고);
            this.groupBox1.Controls.Add(this.btn신규);
            this.groupBox1.Controls.Add(this.txt비고);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txt이름);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl현주소);
            this.groupBox1.Controls.Add(this.txt현주소);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(90, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 362);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 57;
            this.label3.Text = "전화번호";
            // 
            // txt전번
            // 
            this.txt전번.Location = new System.Drawing.Point(76, 76);
            this.txt전번.Name = "txt전번";
            this.txt전번.Size = new System.Drawing.Size(124, 21);
            this.txt전번.TabIndex = 3;
            // 
            // btn닫기
            // 
            this.btn닫기.Location = new System.Drawing.Point(480, 18);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(79, 44);
            this.btn닫기.TabIndex = 55;
            this.btn닫기.Text = "닫기";
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "사진";
            this.label8.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "일련번호";
            // 
            // btn삭제
            // 
            this.btn삭제.Location = new System.Drawing.Point(355, 18);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(79, 44);
            this.btn삭제.TabIndex = 51;
            this.btn삭제.Text = "삭제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // lb비고
            // 
            this.lb비고.AutoSize = true;
            this.lb비고.Location = new System.Drawing.Point(41, 144);
            this.lb비고.Name = "lb비고";
            this.lb비고.Size = new System.Drawing.Size(29, 12);
            this.lb비고.TabIndex = 50;
            this.lb비고.Text = "비고";
            // 
            // btn신규
            // 
            this.btn신규.Location = new System.Drawing.Point(261, 18);
            this.btn신규.Name = "btn신규";
            this.btn신규.Size = new System.Drawing.Size(79, 44);
            this.btn신규.TabIndex = 6;
            this.btn신규.Text = "신규";
            this.btn신규.UseVisualStyleBackColor = true;
            this.btn신규.Click += new System.EventHandler(this.btn신규_Click);
            // 
            // txt비고
            // 
            this.txt비고.Location = new System.Drawing.Point(76, 141);
            this.txt비고.Multiline = true;
            this.txt비고.Name = "txt비고";
            this.txt비고.Size = new System.Drawing.Size(483, 209);
            this.txt비고.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(76, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 21);
            this.txtID.TabIndex = 30;
            // 
            // txt이름
            // 
            this.txt이름.Location = new System.Drawing.Point(76, 47);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(100, 21);
            this.txt이름.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "성명";
            // 
            // lbl현주소
            // 
            this.lbl현주소.AutoSize = true;
            this.lbl현주소.Location = new System.Drawing.Point(29, 106);
            this.lbl현주소.Name = "lbl현주소";
            this.lbl현주소.Size = new System.Drawing.Size(41, 12);
            this.lbl현주소.TabIndex = 44;
            this.lbl현주소.Text = "현주소";
            // 
            // txt현주소
            // 
            this.txt현주소.Location = new System.Drawing.Point(76, 103);
            this.txt현주소.Name = "txt현주소";
            this.txt현주소.Size = new System.Drawing.Size(483, 21);
            this.txt현주소.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 362);
            this.panel1.TabIndex = 27;
            // 
            // 직원추가
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "직원추가";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "직원등록/수정";
            this.Load += new System.EventHandler(this.직원추가_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Label lb비고;
        private System.Windows.Forms.Button btn신규;
        private System.Windows.Forms.TextBox txt비고;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txt이름;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl현주소;
        private System.Windows.Forms.TextBox txt현주소;
        private System.Windows.Forms.Button btn닫기;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt전번;
    }
}
namespace GAS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt이름 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt주민 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt면허 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt전번 = new System.Windows.Forms.TextBox();
            this.txt경력 = new System.Windows.Forms.TextBox();
            this.txt본적 = new System.Windows.Forms.TextBox();
            this.txt현주소 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl현주소 = new System.Windows.Forms.Label();
            this.label전근무지 = new System.Windows.Forms.Label();
            this.txt전근무지 = new System.Windows.Forms.TextBox();
            this.txt전근무지2 = new System.Windows.Forms.TextBox();
            this.lbl전근무지2 = new System.Windows.Forms.Label();
            this.txt비고 = new System.Windows.Forms.TextBox();
            this.lb비고 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn저장 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.btn신규 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "일련번호";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(188, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 21);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.datachange);
            // 
            // txt이름
            // 
            this.txt이름.Location = new System.Drawing.Point(188, 42);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(100, 21);
            this.txt이름.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "성명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "생년월일";
            // 
            // txt주민
            // 
            this.txt주민.Location = new System.Drawing.Point(188, 83);
            this.txt주민.Name = "txt주민";
            this.txt주민.Size = new System.Drawing.Size(120, 21);
            this.txt주민.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "면허번호";
            // 
            // txt면허
            // 
            this.txt면허.Location = new System.Drawing.Point(495, 123);
            this.txt면허.Name = "txt면허";
            this.txt면허.Size = new System.Drawing.Size(176, 21);
            this.txt면허.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(87, 412);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "전화번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "경력";
            // 
            // txt전번
            // 
            this.txt전번.Location = new System.Drawing.Point(188, 110);
            this.txt전번.Name = "txt전번";
            this.txt전번.Size = new System.Drawing.Size(120, 21);
            this.txt전번.TabIndex = 11;
            // 
            // txt경력
            // 
            this.txt경력.Location = new System.Drawing.Point(495, 150);
            this.txt경력.Name = "txt경력";
            this.txt경력.Size = new System.Drawing.Size(108, 21);
            this.txt경력.TabIndex = 12;
            // 
            // txt본적
            // 
            this.txt본적.Location = new System.Drawing.Point(188, 156);
            this.txt본적.Name = "txt본적";
            this.txt본적.Size = new System.Drawing.Size(100, 21);
            this.txt본적.TabIndex = 13;
            // 
            // txt현주소
            // 
            this.txt현주소.Location = new System.Drawing.Point(188, 183);
            this.txt현주소.Name = "txt현주소";
            this.txt현주소.Size = new System.Drawing.Size(483, 21);
            this.txt현주소.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "본적";
            // 
            // lbl현주소
            // 
            this.lbl현주소.AutoSize = true;
            this.lbl현주소.Location = new System.Drawing.Point(141, 186);
            this.lbl현주소.Name = "lbl현주소";
            this.lbl현주소.Size = new System.Drawing.Size(41, 12);
            this.lbl현주소.TabIndex = 16;
            this.lbl현주소.Text = "현주소";
            // 
            // label전근무지
            // 
            this.label전근무지.AutoSize = true;
            this.label전근무지.Location = new System.Drawing.Point(125, 228);
            this.label전근무지.Name = "label전근무지";
            this.label전근무지.Size = new System.Drawing.Size(57, 12);
            this.label전근무지.TabIndex = 17;
            this.label전근무지.Text = "전 근무지";
            // 
            // txt전근무지
            // 
            this.txt전근무지.Location = new System.Drawing.Point(188, 225);
            this.txt전근무지.Name = "txt전근무지";
            this.txt전근무지.Size = new System.Drawing.Size(120, 21);
            this.txt전근무지.TabIndex = 18;
            // 
            // txt전근무지2
            // 
            this.txt전근무지2.Location = new System.Drawing.Point(405, 225);
            this.txt전근무지2.Name = "txt전근무지2";
            this.txt전근무지2.Size = new System.Drawing.Size(100, 21);
            this.txt전근무지2.TabIndex = 19;
            // 
            // lbl전근무지2
            // 
            this.lbl전근무지2.AutoSize = true;
            this.lbl전근무지2.Location = new System.Drawing.Point(314, 228);
            this.lbl전근무지2.Name = "lbl전근무지2";
            this.lbl전근무지2.Size = new System.Drawing.Size(85, 12);
            this.lbl전근무지2.TabIndex = 20;
            this.lbl전근무지2.Text = "전 근무지 전화";
            // 
            // txt비고
            // 
            this.txt비고.Location = new System.Drawing.Point(188, 283);
            this.txt비고.Multiline = true;
            this.txt비고.Name = "txt비고";
            this.txt비고.Size = new System.Drawing.Size(483, 168);
            this.txt비고.TabIndex = 21;
            // 
            // lb비고
            // 
            this.lb비고.AutoSize = true;
            this.lb비고.Location = new System.Drawing.Point(153, 283);
            this.lb비고.Name = "lb비고";
            this.lb비고.Size = new System.Drawing.Size(29, 12);
            this.lb비고.TabIndex = 22;
            this.lb비고.Text = "비고";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "목록";
            // 
            // btn저장
            // 
            this.btn저장.Location = new System.Drawing.Point(498, 60);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(79, 44);
            this.btn저장.TabIndex = 24;
            this.btn저장.Text = "저장";
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.Location = new System.Drawing.Point(584, 13);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(87, 44);
            this.btn닫기.TabIndex = 25;
            this.btn닫기.Text = "닫기";
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn신규
            // 
            this.btn신규.Location = new System.Drawing.Point(497, 13);
            this.btn신규.Name = "btn신규";
            this.btn신규.Size = new System.Drawing.Size(79, 44);
            this.btn신규.TabIndex = 26;
            this.btn신규.Text = "신규";
            this.btn신규.UseVisualStyleBackColor = true;
            this.btn신규.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(330, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 123);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "사진";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 직원추가
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn닫기);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb비고);
            this.Controls.Add(this.txt비고);
            this.Controls.Add(this.lbl전근무지2);
            this.Controls.Add(this.txt전근무지2);
            this.Controls.Add(this.txt전근무지);
            this.Controls.Add(this.label전근무지);
            this.Controls.Add(this.lbl현주소);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt현주소);
            this.Controls.Add(this.txt본적);
            this.Controls.Add(this.txt경력);
            this.Controls.Add(this.txt전번);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt면허);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt주민);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt이름);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn신규);
            this.Controls.Add(this.btn저장);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "직원추가";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "직원등록/수정";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.직원추가_FormClosed);
            this.Load += new System.EventHandler(this.직원추가_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txt이름;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt주민;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt면허;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt전번;
        private System.Windows.Forms.TextBox txt경력;
        private System.Windows.Forms.TextBox txt본적;
        private System.Windows.Forms.TextBox txt현주소;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl현주소;
        private System.Windows.Forms.Label label전근무지;
        private System.Windows.Forms.TextBox txt전근무지;
        private System.Windows.Forms.TextBox txt전근무지2;
        private System.Windows.Forms.Label lbl전근무지2;
        private System.Windows.Forms.TextBox txt비고;
        private System.Windows.Forms.Label lb비고;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Button btn닫기;
        private System.Windows.Forms.Button btn신규;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
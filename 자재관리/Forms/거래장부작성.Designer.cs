namespace 자재관리.Forms
{
    partial class 거래장부작성
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn추가 = new System.Windows.Forms.Button();
            this.btn제거 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chk미수금 = new System.Windows.Forms.CheckBox();
            this.txt지역 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn거래처창열기 = new System.Windows.Forms.Button();
            this.cmb거래처 = new System.Windows.Forms.ComboBox();
            this.txt물품명 = new System.Windows.Forms.ComboBox();
            this.txt수량 = new System.Windows.Forms.NumericUpDown();
            this.txt담당자 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn지역추가 = new System.Windows.Forms.Button();
            this.txt지역2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt수량)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "물품명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "수량";
            // 
            // btn추가
            // 
            this.btn추가.Location = new System.Drawing.Point(736, 17);
            this.btn추가.Name = "btn추가";
            this.btn추가.Size = new System.Drawing.Size(102, 39);
            this.btn추가.TabIndex = 7;
            this.btn추가.Text = "추가";
            this.btn추가.UseVisualStyleBackColor = true;
            this.btn추가.Click += new System.EventHandler(this.btn추가_Click);
            // 
            // btn제거
            // 
            this.btn제거.Enabled = false;
            this.btn제거.Location = new System.Drawing.Point(844, 17);
            this.btn제거.Name = "btn제거";
            this.btn제거.Size = new System.Drawing.Size(102, 39);
            this.btn제거.TabIndex = 8;
            this.btn제거.Text = "제거";
            this.btn제거.UseVisualStyleBackColor = true;
            this.btn제거.Click += new System.EventHandler(this.btn제거_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.Location = new System.Drawing.Point(990, 22);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(187, 52);
            this.btn닫기.TabIndex = 9;
            this.btn닫기.Text = "닫기";
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "담당자";
            // 
            // chk미수금
            // 
            this.chk미수금.AutoSize = true;
            this.chk미수금.Location = new System.Drawing.Point(354, 35);
            this.chk미수금.Name = "chk미수금";
            this.chk미수금.Size = new System.Drawing.Size(60, 16);
            this.chk미수금.TabIndex = 14;
            this.chk미수금.Text = "미수금";
            this.chk미수금.UseVisualStyleBackColor = true;
            // 
            // txt지역
            // 
            this.txt지역.Location = new System.Drawing.Point(425, 33);
            this.txt지역.Name = "txt지역";
            this.txt지역.Size = new System.Drawing.Size(100, 21);
            this.txt지역.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "지역";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "거래처";
            // 
            // btn거래처창열기
            // 
            this.btn거래처창열기.Location = new System.Drawing.Point(635, 32);
            this.btn거래처창열기.Name = "btn거래처창열기";
            this.btn거래처창열기.Size = new System.Drawing.Size(24, 23);
            this.btn거래처창열기.TabIndex = 27;
            this.btn거래처창열기.Text = "+";
            this.btn거래처창열기.UseVisualStyleBackColor = true;
            this.btn거래처창열기.Click += new System.EventHandler(this.btn거래처창열기_Click);
            // 
            // cmb거래처
            // 
            this.cmb거래처.FormattingEnabled = true;
            this.cmb거래처.Location = new System.Drawing.Point(531, 33);
            this.cmb거래처.Name = "cmb거래처";
            this.cmb거래처.Size = new System.Drawing.Size(98, 20);
            this.cmb거래처.TabIndex = 28;
            // 
            // txt물품명
            // 
            this.txt물품명.DisplayMember = "품목명";
            this.txt물품명.FormattingEnabled = true;
            this.txt물품명.Location = new System.Drawing.Point(23, 34);
            this.txt물품명.Name = "txt물품명";
            this.txt물품명.Size = new System.Drawing.Size(131, 20);
            this.txt물품명.TabIndex = 29;
            this.txt물품명.ValueMember = "품목명";
            // 
            // txt수량
            // 
            this.txt수량.Location = new System.Drawing.Point(188, 34);
            this.txt수량.Name = "txt수량";
            this.txt수량.Size = new System.Drawing.Size(62, 21);
            this.txt수량.TabIndex = 30;
            // 
            // txt담당자
            // 
            this.txt담당자.FormattingEnabled = true;
            this.txt담당자.Location = new System.Drawing.Point(268, 33);
            this.txt담당자.Name = "txt담당자";
            this.txt담당자.Size = new System.Drawing.Size(77, 20);
            this.txt담당자.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt담당자);
            this.groupBox1.Controls.Add(this.txt물품명);
            this.groupBox1.Controls.Add(this.txt수량);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb거래처);
            this.groupBox1.Controls.Add(this.btn제거);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn추가);
            this.groupBox1.Controls.Add(this.btn거래처창열기);
            this.groupBox1.Controls.Add(this.chk미수금);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt지역);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(962, 555);
            this.dataGridView1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn지역추가);
            this.groupBox2.Controls.Add(this.txt지역2);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(984, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 555);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "지역 목록";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "지우기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn지역추가
            // 
            this.btn지역추가.Location = new System.Drawing.Point(122, 15);
            this.btn지역추가.Name = "btn지역추가";
            this.btn지역추가.Size = new System.Drawing.Size(75, 23);
            this.btn지역추가.TabIndex = 23;
            this.btn지역추가.Text = "지역추가";
            this.btn지역추가.UseVisualStyleBackColor = true;
            // 
            // txt지역2
            // 
            this.txt지역2.Location = new System.Drawing.Point(6, 17);
            this.txt지역2.Name = "txt지역2";
            this.txt지역2.Size = new System.Drawing.Size(110, 21);
            this.txt지역2.TabIndex = 22;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(6, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(110, 508);
            this.listBox2.TabIndex = 20;
            // 
            // 거래장부작성
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn닫기);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "거래장부작성";
            this.Text = "거래내역작성";
            this.Load += new System.EventHandler(this.거래장부작성_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt수량)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button btn추가;
        private System.Windows.Forms.Button btn제거;
        private System.Windows.Forms.Button btn닫기;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk미수금;
        private System.Windows.Forms.TextBox txt지역;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn거래처창열기;
        private System.Windows.Forms.ComboBox cmb거래처;
        private System.Windows.Forms.ComboBox txt물품명;
        private System.Windows.Forms.NumericUpDown txt수량;
        private System.Windows.Forms.ComboBox txt담당자;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn지역추가;
        private System.Windows.Forms.TextBox txt지역2;
        private System.Windows.Forms.ListBox listBox2;
    }
}
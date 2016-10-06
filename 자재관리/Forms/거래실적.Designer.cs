namespace 자재관리
{
    partial class 배달실적
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r전체 = new System.Windows.Forms.RadioButton();
            this.r지역 = new System.Windows.Forms.RadioButton();
            this.r고객 = new System.Windows.Forms.RadioButton();
            this.r기사 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r전체);
            this.groupBox1.Controls.Add(this.r지역);
            this.groupBox1.Controls.Add(this.r고객);
            this.groupBox1.Controls.Add(this.r기사);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 37);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 방법";
            // 
            // r전체
            // 
            this.r전체.AutoSize = true;
            this.r전체.Location = new System.Drawing.Point(200, 15);
            this.r전체.Name = "r전체";
            this.r전체.Size = new System.Drawing.Size(47, 16);
            this.r전체.TabIndex = 4;
            this.r전체.TabStop = true;
            this.r전체.Text = "전체";
            this.r전체.UseVisualStyleBackColor = true;
            this.r전체.CheckedChanged += new System.EventHandler(this.radiobtncheck);
            // 
            // r지역
            // 
            this.r지역.AutoSize = true;
            this.r지역.Location = new System.Drawing.Point(135, 16);
            this.r지역.Name = "r지역";
            this.r지역.Size = new System.Drawing.Size(59, 16);
            this.r지역.TabIndex = 2;
            this.r지역.TabStop = true;
            this.r지역.Text = "지역명";
            this.r지역.UseVisualStyleBackColor = true;
            this.r지역.CheckedChanged += new System.EventHandler(this.radiobtncheck);
            // 
            // r고객
            // 
            this.r고객.AutoSize = true;
            this.r고객.Location = new System.Drawing.Point(73, 16);
            this.r고객.Name = "r고객";
            this.r고객.Size = new System.Drawing.Size(59, 16);
            this.r고객.TabIndex = 1;
            this.r고객.TabStop = true;
            this.r고객.Text = "거래처";
            this.r고객.UseVisualStyleBackColor = true;
            this.r고객.CheckedChanged += new System.EventHandler(this.radiobtncheck);
            // 
            // r기사
            // 
            this.r기사.AutoSize = true;
            this.r기사.Location = new System.Drawing.Point(11, 16);
            this.r기사.Name = "r기사";
            this.r기사.Size = new System.Drawing.Size(47, 16);
            this.r기사.TabIndex = 0;
            this.r기사.TabStop = true;
            this.r기사.Text = "기사";
            this.r기사.UseVisualStyleBackColor = true;
            this.r기사.CheckedChanged += new System.EventHandler(this.radiobtncheck);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.radiobtncheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(757, 536);
            this.dataGridView1.TabIndex = 6;
            // 
            // 배달실적
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "배달실적";
            this.Text = "거래실적";
            this.Load += new System.EventHandler(this.배달실적_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r기사;
        private System.Windows.Forms.RadioButton r고객;
        private System.Windows.Forms.RadioButton r지역;
        private System.Windows.Forms.RadioButton r전체;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.DataGridView dataGridView1;

    }
}
namespace 자재관리.Forms
{
    partial class 지역
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn수정 = new System.Windows.Forms.Button();
            this.btn지역제거 = new System.Windows.Forms.Button();
            this.btn지역추가 = new System.Windows.Forms.Button();
            this.txt지역명 = new System.Windows.Forms.TextBox();
            this.txt지역코드 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(270, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn닫기
            // 
            this.btn닫기.Location = new System.Drawing.Point(12, 12);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(270, 39);
            this.btn닫기.TabIndex = 1;
            this.btn닫기.Text = "닫기";
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn수정);
            this.groupBox1.Controls.Add(this.btn지역제거);
            this.groupBox1.Controls.Add(this.btn지역추가);
            this.groupBox1.Controls.Add(this.txt지역명);
            this.groupBox1.Controls.Add(this.txt지역코드);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn수정
            // 
            this.btn수정.Location = new System.Drawing.Point(220, 38);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(40, 23);
            this.btn수정.TabIndex = 6;
            this.btn수정.Text = "수정";
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // btn지역제거
            // 
            this.btn지역제거.Location = new System.Drawing.Point(220, 63);
            this.btn지역제거.Name = "btn지역제거";
            this.btn지역제거.Size = new System.Drawing.Size(40, 23);
            this.btn지역제거.TabIndex = 5;
            this.btn지역제거.Text = "제거";
            this.btn지역제거.UseVisualStyleBackColor = true;
            this.btn지역제거.Click += new System.EventHandler(this.btn지역제거_Click);
            // 
            // btn지역추가
            // 
            this.btn지역추가.Location = new System.Drawing.Point(220, 13);
            this.btn지역추가.Name = "btn지역추가";
            this.btn지역추가.Size = new System.Drawing.Size(40, 23);
            this.btn지역추가.TabIndex = 4;
            this.btn지역추가.Text = "추가";
            this.btn지역추가.UseVisualStyleBackColor = true;
            this.btn지역추가.Click += new System.EventHandler(this.btn추가_Click);
            // 
            // txt지역명
            // 
            this.txt지역명.Location = new System.Drawing.Point(70, 55);
            this.txt지역명.Name = "txt지역명";
            this.txt지역명.Size = new System.Drawing.Size(100, 21);
            this.txt지역명.TabIndex = 3;
            // 
            // txt지역코드
            // 
            this.txt지역코드.Enabled = false;
            this.txt지역코드.Location = new System.Drawing.Point(70, 24);
            this.txt지역코드.Name = "txt지역코드";
            this.txt지역코드.Size = new System.Drawing.Size(41, 21);
            this.txt지역코드.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "지역명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "지역코드";
            // 
            // 지역
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 613);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn닫기);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "지역";
            this.Text = "지역";
            this.Load += new System.EventHandler(this.지역_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn닫기;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn지역제거;
        private System.Windows.Forms.Button btn지역추가;
        private System.Windows.Forms.TextBox txt지역명;
        private System.Windows.Forms.TextBox txt지역코드;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn수정;
    }
}
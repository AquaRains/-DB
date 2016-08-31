namespace GAS.내부form
{
    partial class 고객추가
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt이름 = new System.Windows.Forms.TextBox();
            this.txt전화번호 = new System.Windows.Forms.TextBox();
            this.txt주소 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt대표자 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(564, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt이름
            // 
            this.txt이름.Location = new System.Drawing.Point(12, 95);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(90, 21);
            this.txt이름.TabIndex = 2;
            // 
            // txt전화번호
            // 
            this.txt전화번호.Location = new System.Drawing.Point(146, 95);
            this.txt전화번호.Name = "txt전화번호";
            this.txt전화번호.Size = new System.Drawing.Size(100, 21);
            this.txt전화번호.TabIndex = 3;
            // 
            // txt주소
            // 
            this.txt주소.Location = new System.Drawing.Point(12, 136);
            this.txt주소.Name = "txt주소";
            this.txt주소.Size = new System.Drawing.Size(564, 21);
            this.txt주소.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "상호/대표명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "전화번호(-없이)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "주소";
            // 
            // txt대표자
            // 
            this.txt대표자.Location = new System.Drawing.Point(346, 95);
            this.txt대표자.Name = "txt대표자";
            this.txt대표자.Size = new System.Drawing.Size(100, 21);
            this.txt대표자.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "대표자성명";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "※삭제 시 상호/대표명 정확히 입력";
            // 
            // 고객추가
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt대표자);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt주소);
            this.Controls.Add(this.txt전화번호);
            this.Controls.Add(this.txt이름);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "고객추가";
            this.Text = "고객추가";
            this.Load += new System.EventHandler(this.고객추가_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고객코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이름DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전화번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대표자DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt이름;
        private System.Windows.Forms.TextBox txt전화번호;
        private System.Windows.Forms.TextBox txt주소;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt대표자;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label5;
    }
}
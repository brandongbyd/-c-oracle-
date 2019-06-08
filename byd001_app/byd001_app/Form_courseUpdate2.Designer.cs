namespace byd001_app
{
    partial class Form_courseUpdate2
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
            this.tbtno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbccredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "更新课程";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtno
            // 
            this.tbtno.Location = new System.Drawing.Point(136, 117);
            this.tbtno.Name = "tbtno";
            this.tbtno.Size = new System.Drawing.Size(159, 21);
            this.tbtno.TabIndex = 18;
            this.tbtno.TextChanged += new System.EventHandler(this.tbtno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "任课老师工号";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbccredit
            // 
            this.tbccredit.Location = new System.Drawing.Point(136, 90);
            this.tbccredit.Name = "tbccredit";
            this.tbccredit.Size = new System.Drawing.Size(159, 21);
            this.tbccredit.TabIndex = 19;
            this.tbccredit.TextChanged += new System.EventHandler(this.tbccredit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "学分";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbcname
            // 
            this.tbcname.Location = new System.Drawing.Point(136, 63);
            this.tbcname.Name = "tbcname";
            this.tbcname.Size = new System.Drawing.Size(159, 21);
            this.tbcname.TabIndex = 20;
            this.tbcname.TextChanged += new System.EventHandler(this.tbcname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "课程名称";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(136, 36);
            this.tbcno.Name = "tbcno";
            this.tbcno.ReadOnly = true;
            this.tbcno.Size = new System.Drawing.Size(159, 21);
            this.tbcno.TabIndex = 21;
            this.tbcno.TextChanged += new System.EventHandler(this.tbcno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "课程编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_courseUpdate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbtno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbccredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcno);
            this.Controls.Add(this.label1);
            this.Name = "Form_courseUpdate2";
            this.Text = "更新课程信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbtno;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbccredit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbcname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbcno;
        private System.Windows.Forms.Label label1;
    }
}
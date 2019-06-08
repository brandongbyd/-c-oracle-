namespace byd001_app
{
    partial class Form_teacherInsert
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
            this.tbtno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtposition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师工号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbtno
            // 
            this.tbtno.Location = new System.Drawing.Point(118, 29);
            this.tbtno.Name = "tbtno";
            this.tbtno.Size = new System.Drawing.Size(159, 21);
            this.tbtno.TabIndex = 1;
            this.tbtno.TextChanged += new System.EventHandler(this.tbtno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbtname
            // 
            this.tbtname.Location = new System.Drawing.Point(118, 56);
            this.tbtname.Name = "tbtname";
            this.tbtname.Size = new System.Drawing.Size(159, 21);
            this.tbtname.TabIndex = 1;
            this.tbtname.TextChanged += new System.EventHandler(this.tbtname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "职位";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbtposition
            // 
            this.tbtposition.Location = new System.Drawing.Point(118, 83);
            this.tbtposition.Name = "tbtposition";
            this.tbtposition.Size = new System.Drawing.Size(159, 21);
            this.tbtposition.TabIndex = 1;
            this.tbtposition.TextChanged += new System.EventHandler(this.tbtposition_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "工资";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbtsalary
            // 
            this.tbtsalary.Location = new System.Drawing.Point(118, 110);
            this.tbtsalary.Name = "tbtsalary";
            this.tbtsalary.Size = new System.Drawing.Size(159, 21);
            this.tbtsalary.TabIndex = 1;
            this.tbtsalary.TextChanged += new System.EventHandler(this.tbtsalary_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密码";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(118, 137);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(159, 21);
            this.tbpwd.TabIndex = 1;
            this.tbpwd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加教师";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_teacherInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbtsalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtposition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtno);
            this.Controls.Add(this.label1);
            this.Name = "Form_teacherInsert";
            this.Text = "添加教师信息";
            this.Load += new System.EventHandler(this.Form_teacherInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtposition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbtsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.Button button1;
    }
}
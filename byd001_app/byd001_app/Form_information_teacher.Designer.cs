namespace byd001_app
{
    partial class Form_information_teacher
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
            this.tbtsalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtposition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtsalary
            // 
            this.tbtsalary.Location = new System.Drawing.Point(148, 112);
            this.tbtsalary.Name = "tbtsalary";
            this.tbtsalary.Size = new System.Drawing.Size(159, 21);
            this.tbtsalary.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "工资";
            // 
            // tbtposition
            // 
            this.tbtposition.Location = new System.Drawing.Point(148, 85);
            this.tbtposition.Name = "tbtposition";
            this.tbtposition.Size = new System.Drawing.Size(159, 21);
            this.tbtposition.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "职位";
            // 
            // tbtname
            // 
            this.tbtname.Location = new System.Drawing.Point(148, 58);
            this.tbtname.Name = "tbtname";
            this.tbtname.Size = new System.Drawing.Size(159, 21);
            this.tbtname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名";
            // 
            // tbtno
            // 
            this.tbtno.Location = new System.Drawing.Point(148, 31);
            this.tbtno.Name = "tbtno";
            this.tbtno.ReadOnly = true;
            this.tbtno.Size = new System.Drawing.Size(159, 21);
            this.tbtno.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "教师工号";
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(148, 137);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(159, 21);
            this.tbpwd.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "密码";
            // 
            // Form_information_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 224);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbtsalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtposition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtno);
            this.Controls.Add(this.label1);
            this.Name = "Form_information_teacher";
            this.Text = "教师个人信息";
            this.Load += new System.EventHandler(this.Form_information_teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbtsalary;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbtposition;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbtname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbtno;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.Label label5;
    }
}
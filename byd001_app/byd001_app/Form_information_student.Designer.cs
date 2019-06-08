namespace byd001_app
{
    partial class Form_information_student
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
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbssex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "确认信息修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(113, 138);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(159, 21);
            this.tbpwd.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "密码";
            // 
            // tbsage
            // 
            this.tbsage.Location = new System.Drawing.Point(113, 111);
            this.tbsage.Name = "tbsage";
            this.tbsage.Size = new System.Drawing.Size(159, 21);
            this.tbsage.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "年龄";
            // 
            // tbssex
            // 
            this.tbssex.Location = new System.Drawing.Point(113, 84);
            this.tbssex.Name = "tbssex";
            this.tbssex.Size = new System.Drawing.Size(159, 21);
            this.tbssex.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "性别";
            // 
            // tbsname
            // 
            this.tbsname.Location = new System.Drawing.Point(113, 57);
            this.tbsname.Name = "tbsname";
            this.tbsname.Size = new System.Drawing.Size(159, 21);
            this.tbsname.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "姓名";
            // 
            // tbsno
            // 
            this.tbsno.Location = new System.Drawing.Point(113, 30);
            this.tbsno.Name = "tbsno";
            this.tbsno.ReadOnly = true;
            this.tbsno.Size = new System.Drawing.Size(159, 21);
            this.tbsno.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "学号";
            // 
            // Form_information_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbsage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbssex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbsname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbsno);
            this.Controls.Add(this.label1);
            this.Name = "Form_information_student";
            this.Text = "学生个人信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbsage;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbssex;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbsname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbsno;
        private System.Windows.Forms.Label label1;
    }
}
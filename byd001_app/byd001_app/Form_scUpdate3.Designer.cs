namespace byd001_app
{
    partial class Form_scUpdate3
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
            this.tbgrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "添加选修信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbgrade
            // 
            this.tbgrade.Location = new System.Drawing.Point(98, 82);
            this.tbgrade.Name = "tbgrade";
            this.tbgrade.Size = new System.Drawing.Size(159, 21);
            this.tbgrade.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "成绩";
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(98, 55);
            this.tbcno.Name = "tbcno";
            this.tbcno.Size = new System.Drawing.Size(159, 21);
            this.tbcno.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "课程编号";
            // 
            // tbsno
            // 
            this.tbsno.Location = new System.Drawing.Point(98, 28);
            this.tbsno.Name = "tbsno";
            this.tbsno.Size = new System.Drawing.Size(159, 21);
            this.tbsno.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "学号";
            // 
            // Form_scUpdate3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbgrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbsno);
            this.Controls.Add(this.label1);
            this.Name = "Form_scUpdate3";
            this.Text = "添加学生选修信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbgrade;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbcno;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbsno;
        private System.Windows.Forms.Label label1;
    }
}
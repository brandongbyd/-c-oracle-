namespace byd001_app
{
    partial class Form_scUpdate2
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
            this.button1.Location = new System.Drawing.Point(103, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "更新选修信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbgrade
            // 
            this.tbgrade.Location = new System.Drawing.Point(103, 80);
            this.tbgrade.Name = "tbgrade";
            this.tbgrade.Size = new System.Drawing.Size(159, 21);
            this.tbgrade.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "成绩";
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(103, 53);
            this.tbcno.Name = "tbcno";
            this.tbcno.ReadOnly = true;
            this.tbcno.Size = new System.Drawing.Size(159, 21);
            this.tbcno.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "课程编号";
            // 
            // tbsno
            // 
            this.tbsno.Location = new System.Drawing.Point(103, 26);
            this.tbsno.Name = "tbsno";
            this.tbsno.ReadOnly = true;
            this.tbsno.Size = new System.Drawing.Size(159, 21);
            this.tbsno.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "学号";
            // 
            // Form_scUpdate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbgrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbsno);
            this.Controls.Add(this.label1);
            this.Name = "Form_scUpdate2";
            this.Text = "更新选课信息";
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
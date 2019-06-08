namespace byd001_app
{
    partial class Form_Statistics
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcno = new System.Windows.Forms.TextBox();
            this.课程编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任课老师DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程学分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.选修人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.平均分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最高分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最低分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbcno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 60);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "课程信息查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 263);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程编号DataGridViewTextBoxColumn,
            this.课程名称DataGridViewTextBoxColumn,
            this.任课老师DataGridViewTextBoxColumn,
            this.课程学分DataGridViewTextBoxColumn,
            this.选修人数DataGridViewTextBoxColumn,
            this.平均分DataGridViewTextBoxColumn,
            this.最高分DataGridViewTextBoxColumn,
            this.最低分DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseinfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(841, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入课程编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(231, 26);
            this.tbcno.Name = "tbcno";
            this.tbcno.Size = new System.Drawing.Size(241, 21);
            this.tbcno.TabIndex = 3;
            // 
            // 课程编号DataGridViewTextBoxColumn
            // 
            this.课程编号DataGridViewTextBoxColumn.DataPropertyName = "课程编号";
            this.课程编号DataGridViewTextBoxColumn.HeaderText = "课程编号";
            this.课程编号DataGridViewTextBoxColumn.Name = "课程编号DataGridViewTextBoxColumn";
            // 
            // 课程名称DataGridViewTextBoxColumn
            // 
            this.课程名称DataGridViewTextBoxColumn.DataPropertyName = "课程名称";
            this.课程名称DataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.课程名称DataGridViewTextBoxColumn.Name = "课程名称DataGridViewTextBoxColumn";
            // 
            // 任课老师DataGridViewTextBoxColumn
            // 
            this.任课老师DataGridViewTextBoxColumn.DataPropertyName = "任课老师";
            this.任课老师DataGridViewTextBoxColumn.HeaderText = "任课老师";
            this.任课老师DataGridViewTextBoxColumn.Name = "任课老师DataGridViewTextBoxColumn";
            // 
            // 课程学分DataGridViewTextBoxColumn
            // 
            this.课程学分DataGridViewTextBoxColumn.DataPropertyName = "课程学分";
            this.课程学分DataGridViewTextBoxColumn.HeaderText = "课程学分";
            this.课程学分DataGridViewTextBoxColumn.Name = "课程学分DataGridViewTextBoxColumn";
            // 
            // 选修人数DataGridViewTextBoxColumn
            // 
            this.选修人数DataGridViewTextBoxColumn.DataPropertyName = "选修人数";
            this.选修人数DataGridViewTextBoxColumn.HeaderText = "选修人数";
            this.选修人数DataGridViewTextBoxColumn.Name = "选修人数DataGridViewTextBoxColumn";
            // 
            // 平均分DataGridViewTextBoxColumn
            // 
            this.平均分DataGridViewTextBoxColumn.DataPropertyName = "平均分";
            this.平均分DataGridViewTextBoxColumn.HeaderText = "平均分";
            this.平均分DataGridViewTextBoxColumn.Name = "平均分DataGridViewTextBoxColumn";
            // 
            // 最高分DataGridViewTextBoxColumn
            // 
            this.最高分DataGridViewTextBoxColumn.DataPropertyName = "最高分";
            this.最高分DataGridViewTextBoxColumn.HeaderText = "最高分";
            this.最高分DataGridViewTextBoxColumn.Name = "最高分DataGridViewTextBoxColumn";
            // 
            // 最低分DataGridViewTextBoxColumn
            // 
            this.最低分DataGridViewTextBoxColumn.DataPropertyName = "最低分";
            this.最低分DataGridViewTextBoxColumn.HeaderText = "最低分";
            this.最低分DataGridViewTextBoxColumn.Name = "最低分DataGridViewTextBoxColumn";
            // 
            // courseinfoBindingSource
            // 
            this.courseinfoBindingSource.DataSource = typeof(byd001_app.courseinfo);
            // 
            // Form_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 323);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Statistics";
            this.Text = "学校信息统计";
            this.Load += new System.EventHandler(this.Form_Statistics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任课老师DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程学分DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 选修人数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 平均分DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最高分DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最低分DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseinfoBindingSource;
        private System.Windows.Forms.TextBox tbcno;
        private System.Windows.Forms.Label label1;
    }
}
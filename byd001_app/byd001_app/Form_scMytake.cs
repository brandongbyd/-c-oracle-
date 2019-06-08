using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byd001_app
{
    public partial class Form_scMytake : Form
    {
        public Form_scMytake()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = course.Selectcourse(this.textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (e.RowIndex < 0) return;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 4)
                {
                    //表示用户点击了修改按钮
                    course c = (course)row.DataBoundItem;
                    sc s_c = new sc();
                    //s_c.sno = common.Name;
                    s_c.sno = common.Name;
                    s_c.cno = c.cno;
                    s_c.grade = 0;
                    if (sc.Insertsc(s_c) == 1)
                    {
                        MessageBox.Show("insert success");
                    }
                }
        }

        private void Form_scMytake_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = course.Selectcourse(this.textBox1.Text);
        }
    }
}

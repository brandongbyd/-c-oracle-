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
    public partial class Form_courseUpdate : Form
    {
        public Form_courseUpdate()
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
                //表示用户点击了删除按钮
                string cno = row.Cells[0].Value.ToString();
                if (course.Deletecourse(cno) == 1)
                {
                    MessageBox.Show("delete success");
                    //this.dataGridView1.Rows.Remove(row);//出问题
                }
                else
                    MessageBox.Show("没有找到数据");
            }
            else
                if (e.ColumnIndex == 5)
                {
                    //表示用户点击了修改按钮
                    course c = (course)row.DataBoundItem;
                    Form_courseUpdate2 frm = new Form_courseUpdate2();
                    frm.tbcno.Text = c.cno;
                    frm.tbcname.Text = c.cname;
                    frm.tbccredit.Text = c.ccredit.ToString();
                    frm.tbtno.Text = c.tno;
                    frm.ShowDialog();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_courseUpdate_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = course.Selectcourse(this.textBox1.Text);
        }
    }
}

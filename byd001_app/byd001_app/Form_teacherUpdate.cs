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
    public partial class Form_teacherUpdate : Form
    {
        public Form_teacherUpdate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = teacher.Selectteacher(this.textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (e.RowIndex < 0) return;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                //表示用户点击了删除按钮
                string tno = row.Cells[0].Value.ToString();
                if (teacher.Deleteteacher(tno) == 1)
                {
                    MessageBox.Show("delete success");
                    //this.dataGridView1.Rows.Remove(row);//出问题
                }
                else
                    MessageBox.Show("没有找到数据");
            }
            else
                if (e.ColumnIndex == 6)
                {
                    //表示用户点击了修改按钮
                    teacher t = (teacher)row.DataBoundItem;
                    Form_teacherUpdate2 frm = new Form_teacherUpdate2();
                    frm.tbtno.Text = t.tno;
                    frm.tbtname.Text = t.tname;
                    frm.tbtposition.Text = t.tposition;
                    frm.tbtsalary.Text = t.tsalary.ToString();
                    frm.tbpwd.Text = t.pwd;
                    frm.ShowDialog();
                }
        }

        private void Form_teacherUpdate_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = teacher.Selectteacher(this.textBox1.Text);
        }
    }
}

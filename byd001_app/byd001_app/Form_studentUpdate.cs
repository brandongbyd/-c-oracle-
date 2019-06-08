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
    public partial class Form_studentUpdate : Form
    {
        public Form_studentUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = student.Selectstudent(this.textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (e.RowIndex < 0) return;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                //表示用户点击了删除按钮
                string sno = row.Cells[0].Value.ToString();
                if (student.Deletestudent(sno) == 1)
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
                    student s = (student)row.DataBoundItem;
                    Form_studentUpdate2 frm = new Form_studentUpdate2();
                    frm.tbsno.Text = s.sno;
                    frm.tbsname.Text = s.sname;
                    frm.tbssex.Text = s.ssex;
                    frm.tbsage.Text = s.sage.ToString();
                    frm.tbpwd.Text = s.pwd;
                    frm.ShowDialog();
                }
        }

        private void Form_studentUpdate_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = student.Selectstudent(this.textBox1.Text);
        }
    }
}

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
    public partial class Form_scUpdate : Form
    {
        public Form_scUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = sc.Selectsc(this.textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (e.RowIndex < 0) return;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == 3)
            {
                //表示用户点击了删除按钮
                string sno = row.Cells[0].Value.ToString();
                string cno = row.Cells[1].Value.ToString();
                if (sc.Deletesc(sno,cno) == 1)
                {
                    MessageBox.Show("delete success");
                    //this.dataGridView1.Rows.Remove(row);//出问题
                }
                else
                    MessageBox.Show("没有找到数据");
            }
            else
                if (e.ColumnIndex == 4)
                {
                    //表示用户点击了修改按钮
                    sc s_c = (sc)row.DataBoundItem;
                    Form_scUpdate2 frm = new Form_scUpdate2();
                    frm.tbsno.Text = s_c.sno;
                    frm.tbcno.Text = s_c.cno;
                    frm.tbgrade.Text = s_c.grade.ToString();
                    frm.ShowDialog();
                }
        }

        private void Form_scUpdate_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = sc.Selectsc(this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_scUpdate3 frm = new Form_scUpdate3();
            //frm.MdiParent = this;
            frm.Show();

        }
    }
}

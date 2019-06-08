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
    public partial class Form_courseUpdate2 : Form
    {
        public Form_courseUpdate2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course c = new course();
            c.cno = tbcno.Text;//保持不变的
            c.cname = tbcname.Text;
            c.ccredit = Convert.ToInt32(tbccredit.Text);
            c.tno = tbtno.Text;
            if (course.Updatecourse(c) == 1)
                MessageBox.Show("update success");
            else
                MessageBox.Show("可能没有找到记录");
        }

        private void tbtno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbccredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbcname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form_courseInsert : Form
    {
        public Form_courseInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course c = new course();
            c.cno = tbcno.Text;
            c.cname = tbcname.Text;
            c.ccredit = Convert.ToInt32(tbccredit.Text);
            c.tno = tbtno.Text;
            //把课程c放入数据库
            if (course.Insertcourse(c) == 1)
            {
                MessageBox.Show("insert success");
            }
        }
    }
}

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
    public partial class Form_studentInsert : Form
    {
        public Form_studentInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.sno = tbsno.Text;
            s.sname = tbsname.Text;
            s.ssex = tbssex.Text;
            s.sage= Convert.ToInt32(tbsage.Text);
            s.pwd = tbpwd.Text;
            //把课程c放入数据库
            if (student.Insertstudent(s) == 1)
            {
                MessageBox.Show("insert success");
            }
        }
    }
}

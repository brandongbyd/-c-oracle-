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
    public partial class Form_scUpdate3 : Form
    {
        public Form_scUpdate3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc s_c = new sc();
            s_c.sno = tbsno.Text;
            s_c.cno = tbcno.Text;
            s_c.grade = Convert.ToInt32(tbgrade.Text);
            //把课程c放入数据库
            if (sc.Insertsc(s_c) == 1)
            {
                MessageBox.Show("insert success");
            }
        }
    }
}

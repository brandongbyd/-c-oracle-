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
    public partial class Form_scUpdate2 : Form
    {
        public Form_scUpdate2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc s_c = new sc();
            s_c.sno = tbsno.Text;//保持不变的
            s_c.cno = tbcno.Text;
            s_c.grade = Convert.ToInt32(tbgrade.Text);
            if (sc.Updatesc(s_c) == 1)
                MessageBox.Show("update success");
            else
                MessageBox.Show("可能没有找到记录");
        }
    }
}

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
    public partial class Form_studentUpdate2 : Form
    {
        public Form_studentUpdate2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.sno = tbsno.Text;//保持不变的
            s.sname = tbsname.Text;
            s.ssex = tbssex.Text;
            s.sage = Convert.ToInt32(tbsage.Text);
            s.pwd = tbpwd.Text;
            if (student.Updatestudent(s) == 1)
                MessageBox.Show("update success");
            else
                MessageBox.Show("可能没有找到记录");
        }
    }
}

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
    public partial class Form_information_teacher : Form
    {
        public Form_information_teacher()
        {
            InitializeComponent();
        }

        private void Form_information_teacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher t = new teacher();
            t.tno = tbtno.Text;//保持不变的
            t.tname = tbtname.Text;
            t.tposition = tbtposition.Text;
            t.tsalary = Convert.ToInt32(tbtsalary.Text);
            t.pwd = tbpwd.Text;
            if (teacher.Updateteacher(t) == 1)
                MessageBox.Show("update success");
            else
                MessageBox.Show("可能没有找到记录");
        }
    }
}

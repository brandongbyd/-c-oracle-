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
    public partial class Form_teacherInsert : Form
    {
        public Form_teacherInsert()
        {
            InitializeComponent();
        }

        private void Form_teacherInsert_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher t = new teacher();
            t.tno = tbtno.Text;
            t.tname = tbtname.Text;
            t.tposition = tbtposition.Text;
            t.tsalary = Convert.ToInt32(tbtsalary.Text);
            t.pwd = tbpwd.Text;
            //把课程c放入数据库
            if (teacher.Insertteacher(t) == 1)
            {
                MessageBox.Show("insert success");
            }
        }

        private void tbtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbtposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbtno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

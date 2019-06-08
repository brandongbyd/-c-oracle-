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
    public partial class Form_scMyQuery : Form
    {
        public Form_scMyQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = sc.Selectsc(this.textBox1.Text);
        }

        private void Form_scMyQuery_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = sc.Selectsc(this.textBox1.Text);
        }
    }
}

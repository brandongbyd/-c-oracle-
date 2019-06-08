using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byd001_app
{
    public partial class Form_teacherQuery : Form
    {
        public Form_teacherQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string sql = string.Format("select * from teacher");
            OracleConnection con = new OracleConnection("data source=localhost:1521/orcl;User id=byd003;password=byd123");
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);

                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    MessageBox.Show("1");
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    this.dataGridView1.DataSource = bs;
                }
                else
                {
                    MessageBox.Show("%");
                    this.dataGridView1.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }*/
            this.dataGridView1.DataSource = teacher.Selectteacher(this.textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_teacherQuery_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = teacher.Selectteacher(this.textBox1.Text);
        }
    }
}

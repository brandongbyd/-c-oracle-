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
    public partial class Form_MyStatistics : Form
    {
        public Form_MyStatistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string str = this.textBox1.Text;
            //this.dataGridView1.DataSource = course.Selectcourse(this.textBox1.Text);
            string sql = "select * from studentinfo where 姓名 like :sname";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cname", OracleDbType.Char, 40) };
            para[0].Value = "%"+str+"%";
            //List<course> list = new List<course>();
            //创建链接，打开连接，创建命令对象，执行命令，关闭连接
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    this.dataGridView1.DataSource = bs;
                }
                else
                    this.dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            
             }
              */
            this.dataGridView1.DataSource = studentinfo.Selectstudentinfo(this.textBox1.Text);
        }

        private void Form_MyStatistics_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}

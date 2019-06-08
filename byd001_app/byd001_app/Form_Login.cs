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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.tbno.Text == "admin" && this.tbpwd.Text == "123")
            {
                MessageBox.Show("登录成功");  // 可以记录用户的登录信息
                this.DialogResult = DialogResult.OK;
                common.Name = "admin";
                common.ID = "0";
                this.Close();
                return;
            }
            if (radioButton1.Checked == true)
            {


                string sql = "select *from student where sno=:sno and pwd=:pwd";
                OracleParameter[] para = new OracleParameter[]{new OracleParameter(":sno",OracleDbType.Varchar2,10),
                                                           new OracleParameter(":pwd",OracleDbType.Varchar2,20)};
                para[0].Value = this.tbno.Text;
                para[1].Value = this.tbpwd.Text;
                //this.Close();
                OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    OracleDataReader odr = cmd.ExecuteReader();
                    if (odr.HasRows)
                    {
                        MessageBox.Show("登录成功");  // 可以记录用户的登录信息
                        this.DialogResult = DialogResult.OK;
                        common.Name = this.tbno.Text;
                        common.ID = "2";
                        this.Close();
                    }
                    else
                        MessageBox.Show("用户名或者密码错误");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {


                // 教师
                string sql = "select *from teacher where tno=:tno and pwd=:pwd";
                OracleParameter[] para = new OracleParameter[]{new OracleParameter(":tno",OracleDbType.Varchar2,7),
                                                           new OracleParameter(":pwd",OracleDbType.Varchar2,20)};
                para[0].Value = this.tbno.Text;
                para[1].Value = this.tbpwd.Text;
                //this.Close();
                OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    OracleDataReader odr = cmd.ExecuteReader();
                    if (odr.HasRows)
                    {
                        MessageBox.Show("登录成功");  // 可以记录用户的登录信息
                        this.DialogResult = DialogResult.OK;
                        common.Name = this.tbno.Text;
                        common.ID = "1";
                        this.Close();
                    }
                    else
                        MessageBox.Show("用户名或者密码错误");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}

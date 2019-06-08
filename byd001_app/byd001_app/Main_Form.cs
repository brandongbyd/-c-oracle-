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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form_Login frm = new Form_Login();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                //表示登录成功
                //记录是什么角色，根据角色设置菜单 
                //Main_For = "学生新消息管理系统" + "           欢迎你," + common.Name;
                this.Text = "学生新消息管理系统" + "           欢迎你," + common.Name;
                if (common.ID == "0")
                {
                    学生管理ToolStripMenuItem.Visible = true;
                    教师管理ToolStripMenuItem.Visible = true;
                    课程管理ToolStripMenuItem.Visible = true;
                    选修管理ToolStripMenuItem.Visible = true;
                    个人信息ToolStripMenuItem.Visible = true;
                    统计报表ToolStripMenuItem.Visible = true;
                    选修课程ToolStripMenuItem.Visible = false;
                }
                else
                {
                    if (common.ID == "1")
                    {
                        学生管理ToolStripMenuItem.Visible = true;
                        教师管理ToolStripMenuItem.Visible = true;
                        课程管理ToolStripMenuItem.Visible = true;
                        选修管理ToolStripMenuItem.Visible = true;
                        个人信息ToolStripMenuItem.Visible = true;
                        统计报表ToolStripMenuItem.Visible = true;
                        添加学生ToolStripMenuItem1.Visible = false;
                        更新学生ToolStripMenuItem.Visible = false;
                        添加教师ToolStripMenuItem.Visible = false;
                        更新教师ToolStripMenuItem.Visible = false;
                        添加课程ToolStripMenuItem.Visible = false;
                        更新课程ToolStripMenuItem.Visible = false;
                        选修课程ToolStripMenuItem.Visible = false;
                        更新选修ToolStripMenuItem.Visible = false;
                    }
                    else
                    {
                        学生管理ToolStripMenuItem.Visible = true;
                        教师管理ToolStripMenuItem.Visible = true;
                        课程管理ToolStripMenuItem.Visible = true;
                        选修管理ToolStripMenuItem.Visible = true;
                        个人信息ToolStripMenuItem.Visible = true;
                        统计报表ToolStripMenuItem.Visible = true;
                        添加学生ToolStripMenuItem1.Visible = false;
                        更新学生ToolStripMenuItem.Visible = false;
                        添加教师ToolStripMenuItem.Visible = false;
                        更新教师ToolStripMenuItem.Visible = false;
                        添加课程ToolStripMenuItem.Visible = false;
                        更新课程ToolStripMenuItem.Visible = false;
                        选修课程ToolStripMenuItem.Visible = true;
                        更新选修ToolStripMenuItem.Visible = false;

                    }
                }
                
            }
            else
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 教师管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_courseQuery frm = new Form_courseQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_teacherQuery frm = new Form_teacherQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询学生ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_studentQuery frm = new Form_studentQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_teacherInsert frm = new Form_teacherInsert();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("你没有相应的权限");
        }

        private void 修改教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_teacherUpdate frm = new Form_teacherUpdate();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("你没有相应的权限");
            
        }

        private void 添加学生ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_studentInsert frm = new Form_studentInsert();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("你没有相应的权限");
            }
        }

        private void 修改学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_studentUpdate frm = new Form_studentUpdate();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("你没有相应的权限");
            }
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_courseInsert frm = new Form_courseInsert();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("你没有相应的权限");
            }
            
        }

        private void 更新课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_courseUpdate frm = new Form_courseUpdate();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("你没有相应的权限");
            }
        }

        private void 退选课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_scMytake frm = new Form_scMytake();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 退选课程ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 查询选修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_scMyQuery frm = new Form_scMyQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 选修课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "2")
            {
                Form_scMytake frm = new Form_scMytake();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("你无需进行选课操作");
        }

        private void 更新选修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_scUpdate frm = new Form_scUpdate();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                MessageBox.Show("你没有相应的权限");
        }
        private void 学校成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Statistics frm = new Form_Statistics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 个人成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MyStatistics frm = new Form_MyStatistics();
            frm.MdiParent = this;
            frm.Show();

        }

        private void 个人信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.ID == "0")
            {
                Form_information_admin frm = new Form_information_admin();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                if (common.ID == "1")
                {
                    Form_information_teacher frm = new Form_information_teacher();
                    string sql = "select tno,tname,tposition,tsalary,pwd from teacher where tno like :tno";
                    OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cname", OracleDbType.Char, 40) };
                    para[0].Value = common.Name;
                    //创建链接，打开连接，创建命令对象，执行命令，关闭连接
                    OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
                    try
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand(sql, con);
                        cmd.Parameters.AddRange(para);
                        OracleDataReader odr = cmd.ExecuteReader();
                        while (odr.Read())
                        {
                            teacher t = new teacher();
                            //c.Cno = odr.GetString(0); //ord["cno'].
                            t.tno = odr["tno"].ToString();
                            t.tname = odr.GetString(1);
                            //c.Cpno = odr.GetString(2);
                            t.tposition = odr.GetString(2);
                            t.tsalary = odr.GetInt32(3);
                            t.pwd = odr.GetString(4);
                            //
                            frm.tbtno.Text = t.tno;
                            frm.tbtname.Text = t.tname;
                            frm.tbtposition.Text = t.tposition;
                            frm.tbtsalary.Text = t.tsalary.ToString();
                            frm.tbpwd.Text = t.pwd;
                            frm.ShowDialog();
                        }
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
                    //MessageBox.Show("123");
                    Form_information_student frm = new Form_information_student();
                    string sql = "select sno,sname,ssex,sage,pwd from student where sno like :sno";
                    OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cname", OracleDbType.Char, 40) };
                    para[0].Value = common.Name;
                    //创建链接，打开连接，创建命令对象，执行命令，关闭连接
                    OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
                    try
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand(sql, con);
                        cmd.Parameters.AddRange(para);
                        OracleDataReader odr = cmd.ExecuteReader();
                        while (odr.Read())
                        {
                            student s = new student();
                            //c.Cno = odr.GetString(0); //ord["cno'].
                            s.sno = odr["sno"].ToString();
                            s.sname = odr.GetString(1);
                            //c.Cpno = odr.GetString(2);
                            s.ssex = odr.GetString(2);
                            s.sage = odr.GetInt32(3);
                            s.pwd = odr.GetString(4);
                            //
                            frm.tbsno.Text = s.sno;
                            frm.tbsname.Text = s.sname;
                            frm.tbssex.Text = s.ssex;
                            frm.tbsage.Text = s.sage.ToString();
                            frm.tbpwd.Text = s.pwd;
                            frm.ShowDialog();
                        }
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

        private void 重新登录ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            /*Form_Login frm = new Form_Login();
            frm.MdiParent = this;
            frm.Show();*/
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

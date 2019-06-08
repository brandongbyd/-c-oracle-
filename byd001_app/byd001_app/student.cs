using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byd001_app
{
    class student
    {
        public string sno { get; set; }
        public string sname { get; set; }
        public string ssex { get; set; }
        public int sage { get; set; }
        public string pwd { get; set; }
        public static List<student> Selectstudent(string sname)
        {
            string sql = "select sno,sname,ssex,sage,pwd from student where sname like :sname";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":sname", OracleDbType.Char, 20) };
            para[0].Value = sname + "%";
            //MessageBox.Show(tname+"%");
            List<student> list = new List<student>();
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
                    //t.tno = odr.GetString(0);
                    s.sname = odr.GetString(1);
                    s.ssex= odr.GetString(2);
                    s.sage = odr.GetInt32(3);
                    if (common.ID == "0")
                        s.pwd = odr.GetString(4);
                    else
                        s.pwd = "******";
                    list.Add(s);

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
            return list;
        }
        public static int Deletestudent(string sno)
        {
            int result = 0;
            string sql = "delete from student where sno=:sno";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":sno", OracleDbType.Char, 10) };
            para[0].Value = sno;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int Insertstudent(student s)
        {
            int result = 0;
            string sql = "insert into student(sno,sname,ssex,sage,pwd) values(:sno,:sname,:ssex,:sage,:pwd)";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":sno",OracleDbType.Char,10),
                                                          new OracleParameter(":sname",OracleDbType.Char,20),
                                                          new OracleParameter(":ssex",OracleDbType.Char,3),
                                                          new OracleParameter(":sage",OracleDbType.Int32),
                                                          new OracleParameter(":pwd",OracleDbType.Char,20)};
            para[0].Value = s.sno;
            para[1].Value = s.sname;
            para[2].Value = s.ssex;
            para[3].Value = s.sage;
            para[4].Value = s.pwd;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int Updatestudent(student s)
        {
            int result = 0;
            string sql = "update student set sname=:sname,ssex=:ssex,sage=:sage,pwd=:pwd where sno=:sno";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":sname",OracleDbType.Char,20),
                                                            new OracleParameter(":ssex",OracleDbType.Char,20),
                                                            new OracleParameter(":sage",OracleDbType.Int32),
                                                            new OracleParameter(":pwd",OracleDbType.Char,20),
                                                            new OracleParameter(":sno",OracleDbType.Char,10)};
            para[0].Value = s.sname;
            para[1].Value = s.ssex;
            para[2].Value = s.sage;
            para[3].Value = s.pwd;
            para[4].Value = s.sno;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}

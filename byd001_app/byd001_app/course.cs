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
    class course
    {
        public string cno { get; set; }
        public string cname { get; set; }
   
        public int ccredit { get; set; }
        public string tno { get; set; }
        public static List<course> Selectcourse(string cname)
        {
            string sql = "select cno,cname,ccredit,tno from course where cname like :cname";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cname", OracleDbType.Char, 40) };
            para[0].Value = cname + "%";
            List<course> list = new List<course>();
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
                    course c = new course();
                    //c.Cno = odr.GetString(0); //ord["cno'].
                    c.cno = odr["cno"].ToString();
                    c.cname = odr.GetString(1);
                    //c.Cpno = odr.GetString(2);
                    c.ccredit = odr.GetInt32(2);
                    c.tno = odr.GetString(3);
                    list.Add(c);

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
        public static int Deletecourse(string cno)
        {
            int result = 0;
            string sql = "delete from course where cno=:cno";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cno", OracleDbType.Char, 4) };
            para[0].Value = cno;
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
        public static int Insertcourse(course c)
        {
            int result = 0;
            string sql = "insert into course(cno,cname,ccredit,tno) values(:cno,:cname,:ccredit,:tno)";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":cno",OracleDbType.Char,4),
                                                          new OracleParameter(":cname",OracleDbType.Char,40),
                                                          new OracleParameter(":ccredit",OracleDbType.Int32),
                                                          new OracleParameter(":tno",OracleDbType.Char,7)};
            para[0].Value = c.cno;
            para[1].Value = c.cname;
            para[2].Value = c.ccredit;
            para[3].Value = c.tno;
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
        public static int Updatecourse(course c)
        {
            int result = 0;
            string sql = "update course set cname=:cname,ccredit=:ccredit,tno=:tno where cno=:cno";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":cname",OracleDbType.Char,40),
                                                            new OracleParameter(":ccredit",OracleDbType.Int32),
                                                            new OracleParameter(":tno",OracleDbType.Char,7),
                                                            new OracleParameter(":cno",OracleDbType.Char,4)};
            para[0].Value = c.cname;
            para[1].Value = c.ccredit;
            para[2].Value = c.tno;
            para[3].Value = c.cno;
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

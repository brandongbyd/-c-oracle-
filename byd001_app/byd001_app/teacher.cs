using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace byd001_app
{
    class teacher
    {
        public string tno { get; set; }
        public string tname { get; set; }
        public string tposition { get; set; }
        public int tsalary { get; set; }
        public string pwd { get; set; }
        public static List<teacher> Selectteacher(string tname)
        {
            string sql = "select tno,tname,tposition,tsalary,pwd from teacher where tname like :tname";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":tname",OracleDbType.Char, 20) };
            para[0].Value = tname + "%";
            //MessageBox.Show(tname+"%");
            List<teacher> list = new List<teacher>();
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
                    //t.tno = odr.GetString(0);
                    t.tname = odr.GetString(1);
                    t.tposition = odr.GetString(2);
                    t.tsalary = odr.GetInt32(3);
                    if (common.ID == "0")
                        t.pwd = odr.GetString(4);
                    else
                        t.pwd = "******";
                    list.Add(t);

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
        public static int Deleteteacher(string tno)
        {
            int result = 0;
            string sql = "delete from teacher where tno=:tno";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":tno", OracleDbType.Char, 7) };
            para[0].Value = tno;
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
        public static int Insertteacher(teacher t)
        {
            int result = 0;
            string sql = "insert into teacher(tno,tname,tposition,tsalary,pwd) values(:tno,:tname,:tposition,:tsalary,:pwd)";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":tno",OracleDbType.Char,7),
                                                          new OracleParameter(":tname",OracleDbType.Char,20),
                                                          new OracleParameter(":tposiition",OracleDbType.Char,20),
                                                          new OracleParameter(":tsalary",OracleDbType.Int32),
                                                          new OracleParameter(":pwd",OracleDbType.Char,20)};
            para[0].Value = t.tno;
            para[1].Value = t.tname;
            para[2].Value = t.tposition;
            para[3].Value = t.tsalary;
            para[4].Value = t.pwd;
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
        public static int Updateteacher(teacher t)
        {
            int result = 0;
            string sql = "update teacher set tname=:tname,tposition=:tposition,tsalary=:tsalary,pwd=:pwd where tno=:tno";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":tname",OracleDbType.Char,20),
                                                            new OracleParameter(":tposition",OracleDbType.Char,20),
                                                            new OracleParameter(":tsalary",OracleDbType.Int32),
                                                            new OracleParameter(":pwd",OracleDbType.Char,20),
                                                            new OracleParameter(":tno",OracleDbType.Char,7)};
            para[0].Value = t.tname;
            para[1].Value = t.tposition;
            para[2].Value = t.tsalary;
            para[3].Value = t.pwd;
            para[4].Value = t.tno;
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

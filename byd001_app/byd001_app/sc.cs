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
    class sc
    {
        public string sno { get; set; }
        public string cno { get; set; }
        public int grade { get; set; }
        public static List<sc> Selectsc(string sno)
        {
            string sql = "select sc.sno,cno,grade from sc,student where student.sno=sc.sno and student.sno like :sno";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":sno", OracleDbType.Char, 10)};
            para[0].Value = sno + "%";
            List<sc> list = new List<sc>();
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
                    sc s_c = new sc();
                    //c.Cno = odr.GetString(0); //ord["cno'].
                    s_c.sno = odr["sno"].ToString();
                    s_c.cno = odr.GetString(1);
                    //c.Cpno = odr.GetString(2);
                    s_c.grade = odr.GetInt32(2);
                    list.Add(s_c);

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
        public static int Deletesc(string sno, string cno)
        {
            int result = 0;
            string sql = "delete from sc where sno=:sno and cno=:cno";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":sno", OracleDbType.Char, 10),
                                                             new OracleParameter(":cno", OracleDbType.Char, 4)};
            para[0].Value = sno;
            para[1].Value = cno;
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
        public static int Insertsc(sc s_c)
        {
            int result = 0;
            string sql = "insert into sc(sno,cno,grade) values(:sno,:cno,:grade)";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":sno", OracleDbType.Char, 10),
                                                             new OracleParameter(":cno", OracleDbType.Char, 4),
                                                             new OracleParameter(":grade", OracleDbType.Int32)};
            para[0].Value = s_c.sno;
            para[1].Value = s_c.cno;
            para[2].Value = s_c.grade;
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
        public static int Updatesc(sc s_c)
        {
            int result = 0;
            string sql = "update sc set grade=:grade where sno like :sno and cno like :cno";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":grade",OracleDbType.Int32),
                                                            new OracleParameter(":sno",OracleDbType.Char,10),
                                                            new OracleParameter(":cno",OracleDbType.Char,4) };
            para[0].Value = s_c.grade;
            para[1].Value = s_c.sno;
            para[2].Value = s_c.cno;
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

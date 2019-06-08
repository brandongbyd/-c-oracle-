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
    class courseinfo
    {
        public string 课程编号 { get; set; }
        public string 课程名称 { get; set; }
        public string 任课老师 { get; set; }
        public int 课程学分 { get; set; }
        public int 选修人数 { get; set; }
        public int 平均分 { get; set; }
        public int 最高分 { get; set; }
        public int 最低分 { get; set; }
        public static List<courseinfo> Selectcourseinfo(string cno)
        {
            string sql = "select *from courseinfo where 课程编号 like :课程编号";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":课程编号", OracleDbType.Char, 4) };
            para[0].Value = cno + "%";
            //MessageBox.Show(tname+"%");
            List<courseinfo> list = new List<courseinfo>();
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
                    courseinfo c_infon = new courseinfo();
                    //c.Cno = odr.GetString(0); //ord["cno'].
                    c_infon.课程编号 = odr["课程编号"].ToString();
                    //t.tno = odr.GetString(0);
                    c_infon.课程名称 = odr.GetString(1);
                    c_infon.任课老师 = odr.GetString(2);
                    c_infon.课程学分 = odr.GetInt32(3);
                    if (odr.IsDBNull(4))
                        c_infon.选修人数 = 0;
                    else
                        c_infon.选修人数 = odr.GetInt32(4);
                    if (odr.IsDBNull(5))
                        c_infon.平均分 = 0;
                    else
                        c_infon.平均分 = odr.GetInt32(5);
                    if (odr.IsDBNull(6))
                        c_infon.最高分 = 0;
                    else
                        c_infon.最高分 = odr.GetInt32(6);
                    if (odr.IsDBNull(7))
                        c_infon.最低分 = 0;
                    else
                        c_infon.最低分 = odr.GetInt32(7);
                    /*c_infon.选修人数 = odr.GetInt32(4);
                    c_infon.平均分 = odr.GetInt32(5);
                    c_infon.最高分 = odr.GetInt32(6);
                    c_infon.最低分 = odr.GetInt32(7);*/
                    list.Add(c_infon);


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
    }
}

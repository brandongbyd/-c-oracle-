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
    class studentinfo
    {
        public string 学号 { get; set; }
        public string 姓名 { get; set; }
        public int 总学分 { get; set; }
        public int 总分 { get; set; }
        public int 最高分 { get; set; }
        public int 最低分 { get; set; }
        public static List<studentinfo> Selectstudentinfo(string sno)
        {
            string sql = "select *from studentinfo where 学号 like :学号";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":学号", OracleDbType.Char, 10) };
            para[0].Value = sno + "%";
            //MessageBox.Show(tname+"%");
            List<studentinfo> list = new List<studentinfo>();
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
                    studentinfo s_infon = new studentinfo();
                    //c.Cno = odr.GetString(0); //ord["cno'].
                    s_infon.学号 = odr["学号"].ToString();
                    //t.tno = odr.GetString(0);
                    s_infon.姓名 = odr.GetString(1);
                    if (odr.IsDBNull(2))
                        s_infon.总学分 = 0;
                    else
                        s_infon.总学分 = odr.GetInt32(2);
                    if (odr.IsDBNull(3))
                        s_infon.总分 = 0;
                    else
                        s_infon.总分 = odr.GetInt32(3);
                    if (odr.IsDBNull(4))
                        s_infon.最高分 = 0;
                    else
                        s_infon.最高分 = odr.GetInt32(4);
                    if (odr.IsDBNull(5))
                        s_infon.最低分 = 0;
                    else
                        s_infon.最低分 = odr.GetInt32(5);
                    /*c_infon.选修人数 = odr.GetInt32(4);
                    c_infon.平均分 = odr.GetInt32(5);
                    c_infon.最高分 = odr.GetInt32(6);
                    c_infon.最低分 = odr.GetInt32(7);*/
                    list.Add(s_infon);


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

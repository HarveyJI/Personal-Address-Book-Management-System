using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    //数据库连接
    class Dao
    {
        SqlConnection sc;
        //数据库连接
        public SqlConnection connet()
        {
            string str = "server=HARVEYPC;database=AddressBook;Trusted_Connection=SSPI";      //数据库连接字符串
            sc = new SqlConnection(str);      //创建数据库连接对象
            sc.Open();              //打开连接
            return sc;              //返回数据库连接对象
        }


        //对数据库进行操作
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connet());
            return cmd;
        }

        //更新操作
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //读取操作
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        //关闭数据库连接
        public void DaoClose()
        {
            sc.Close();
        }
    }
}

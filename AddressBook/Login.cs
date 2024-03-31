using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    
    public partial class Login : Form
    {
        public static string account;
        public Login()
        {
            InitializeComponent();
        }
        public static string myName;
     
        

       

        /*------登录验证--------*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            account = txtName.Text;     //用户名
            string password = txtPwd.Text;      //密码
            

            //判断用户名或密码是否为空
            if (account.Equals(""))
            {
                MessageBox.Show("用户名不能为空!");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("密码不能为空!");
            }
            else
            {

                Dao dao = new Dao();        //实例化数据库连接对象
                string sqlstr = "select * from LoginUser where account = '"+ account + "' and Password = '"+ password + "'";     //SQL查询语句
                IDataReader dc = dao.read(sqlstr);      //调用读取数据库方法
                
                if (dc.Read())      //查询是否有数据  返回的是bool类型 为true时说明读取到数据
                {
                    myName = account;
                    //MessageBox.Show("登录成功");
                    //登录成功后打开登录窗口的同时关闭当前注册窗口
                    Thread th = new Thread(delegate ()
                    {
                        new LinkForm(account).ShowDialog();
                    });
                    th.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!");
                }
                dc.Close();         //关闭数据读取
                dao.DaoClose();     //关闭数据库连接
            }
            
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread th = new Thread(delegate ()
            {
                new RegisterForm().ShowDialog();
            });
            th.Start();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }



 

    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
       


        //用户注册
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取用户注册输入的信息
            string account = Register_Name.Text;
            string password = Register_Pwd1.Text;
            string registerConfirPassword = Register_Pwd2.Text;


            //判断输入的信息是否为空
            if (account.Equals(""))
            {
                MessageBox.Show("用户名不能为空，请重新输入！");
            }
            else if (password.Equals("") || registerConfirPassword.Equals(""))
            {
                MessageBox.Show("密码不能为空，请重新输入！");
            }
            else
            {

                Dao dao = new Dao();        //实例化数据库连接对象
                string sql = "select * from LoginUser where account = '"+ account + "'";
                IDataReader dc = dao.read(sql);      //调用读取数据库方法

                if (dc.Read())      //查询是否有数据  返回的是bool类型 为true时说明读取到数据
                {
                    MessageBox.Show("用户名已存在，请重新输入用户名！");
                }
                else
                {
                    //判断两次输入的密码是否一致，不一致时抛出提示框提醒
                    if (password == registerConfirPassword)
                    {

                        //判断输入的手机号是否为11位号码
                       
                            //注册
                            string sqlstr = "insert into LoginUser(account,password) values ('"+ account + "','"+ password + "')";     //注册SQL语句
                            int ec = dao.Execute(sqlstr);       //写入数据  返回一个整型  大于0说明写入(注册)成功
                            if (ec >= 0)
                            {
                                MessageBox.Show("注册成功！即将跳转至登录界面");

                                //注册成功后打开登录窗口的同时关闭当前注册窗口
                                Thread th = new Thread(delegate()
                                {
                                    new Login().ShowDialog();
                                });
                                th.Start();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("注册失败，请重新检查个人信息!");
                            }

                            dc.Close();         //关闭数据读取
                            dao.DaoClose();     //关闭数据库连接
                       
                    }
                    else
                    {
                        MessageBox.Show("两次输入的密码不同，请重新输入！");
                    }
                }
                
            }
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(delegate()
            {
                new Login().ShowDialog();
            });
            th.Start();
            this.Close();
        }
    }
}

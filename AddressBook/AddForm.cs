using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取输入联系人的信息
            string name = textName.Text;
            string company=textcompany.Text ;
            string linePhone = textlinePhone.Text; 
            string mobilePhone =textmobilePhone.Text ;
            string email= textemail.Text ;
            string qq= textqq.Text ;
            string classification  =textclassification.Text ;

            if (name.Equals(""))
            {
                MessageBox.Show("姓名不能为空,请重新输入!");
            }
            else if (mobilePhone.Equals(""))
            {
                MessageBox.Show("移动手机号不能为空,请重新输入!");
            }
            else
            {
                Dao dao = new Dao();            //实例化数据库连接对象
                string sql = "select * from AddressInfo where mobilePhone = '" + mobilePhone + "'";
                IDataReader dc = dao.read(sql);      //调用读取数据库方法

                //查询添加的联系人是否已经存在通讯录中
                if (dc.Read())      //查询是否有数据  返回的是bool类型 为true时说明读取到数据
                {
                    MessageBox.Show("用户名已存在，请重新输入用户名！");
                }
                else
                {
                    //判断添加的联系人手机号是否为11位
                    if (mobilePhone.Length == 11)
                    {
                        
                        //添加通讯录联系人SQL语句
                        string sqlstr = "insert into AddressInfo values('"+ name + "','"+ company + "','"+ linePhone + "','"+ mobilePhone + "','"+ classification + "','"+email+"','"+qq+"')";

                        int n = dao.Execute(sqlstr);       //写入数据成功后返回一个整型
                        if (n > 0)
                        {
                            MessageBox.Show("添加成功！");
                            LinkForm.linkForm.Table();          //数据刷新

                            //遍历清空所有文本框
                            foreach (Control control in Controls)        //遍历控件
                            {
                                if(control is TextBox)          //找到TextBox控件
                                {
                                    ((TextBox)control).Text = string.Empty;     //清空TextBox控件的文本内容
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("添加失败！");
                        }

                        dc.Close();
                        dao.DaoClose();

                    }
                    else
                    {
                        MessageBox.Show("手机号只能是11位号码，请重新输入！");
                    }
                    
                }
                
            }


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

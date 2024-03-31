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
    public partial class UpdateForm : Form
    {
        public static string MOBILEPHONE;

        public UpdateForm()
        {
            InitializeComponent();
        }

        //修改联系人textbox框显示当前联系人的个人信息
        public UpdateForm(string name,string company,string linePhone,string  mobilePhone,string classification,string email,string qq)
        {
            
            InitializeComponent();
            textName.Text = name;
            textcompany.Text = company;
            textlinePhone.Text = linePhone;
            MOBILEPHONE= mobilePhone;
            textmobilePhone.Text =mobilePhone;
            textemail.Text = email;
            textqq.Text = qq;
            textclassification.Text = classification;
            
            
            
        }

        //确认修改联系人
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SQL更新语句
            string sql = "update AddressInfo set Name = '" + textName.Text + "',company ='" + textcompany.Text + "',linePhone = '" + textlinePhone.Text + "',classification='" + textclassification.Text + "',email='" + textemail.Text + "',qq ='" + textqq.Text + "'" + "where mobilePhone = '" + MOBILEPHONE + "'";
            Dao dao = new Dao();

            if(dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        
        }



       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}

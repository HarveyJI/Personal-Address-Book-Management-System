using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    
    public partial class LinkForm : Form
    {
        public static LinkForm linkForm;
   
      

        public LinkForm(string user)
        {
            InitializeComponent();
            linkForm = this;
            textuser.Text += user;
        }
    
        //状态条显示当前时间
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            StatusLabelTimesDis.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");        //以年月日 时分秒的形式显示时间
        }

        private void LinkForm_Load(object sender, EventArgs e)
        {
            Table();        //刷新表格数据
            StatusLabelUsername.Text = Login.myName;            //登录成功后 状态条左下角显示当前登录用户
            //多选框添加信息
            ComboBoxQuery.Items.Add("姓名");
            ComboBoxQuery.Items.Add("移动手机号");
            ComboBoxQuery.Items.Add("单位");
            ComboBoxQuery.Items.Add("模糊查询");
            ComboBoxQuery.SelectedIndex = 0;        //默认显示姓名查询

            


        }

        //从数据库读取数据显示在表格中
        public void Table()
        {
            dataGridView1.Rows.Clear();     //清空旧数据 
            Dao dao = new Dao();
            string sql = "select * from AddressInfo";
            IDataReader dc = dao.read(sql);
            while (dc.Read())       //读取数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }

            SetRowsCount( dataGridView1,10);//最大显示10行

            //翻页
            BindingSource bs = new BindingSource();
            bs.DataSource = dao.read(sql);
            bindingNavigator1.BindingSource = bs;
         
            dc.Close();
            dao.DaoClose();

                
        }

        //最大显示行数
        public  void SetRowsCount(DataGridView dgv, int listCount)
        {
            int dgvRowsCount = dgv.Rows.Count;//目前dgv的行数

            if (listCount > dgvRowsCount)//数据列表行数大于dgv行数，dgv增加行数
            {
                dgv.Rows.Add(listCount - dgvRowsCount);
            }
            else if (listCount < dgvRowsCount)//数据列表行数小于dgv行数，dgv减少行数
            {
                while (listCount < dgvRowsCount)//移除多出的行
                {
                    dgv.Rows.RemoveAt(dgvRowsCount - 1);
                    dgvRowsCount--;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//添加联系人
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string mobilePhone = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();        //获取姓名

                //弹出对话框是否确认删除
                DialogResult dialogResult = MessageBox.Show("确认删除?", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)     //确认删除
                {
                    string sqlstr = "delete from AddressInfo where mobilePhone = '" + mobilePhone + "'";       //SQL删除语句
                    Dao dao = new Dao();
                    if (dao.Execute(sqlstr) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        Table();                        //刷新表格数据
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    dao.DaoClose();
                }
            }

            catch
            {
                MessageBox.Show("请先在表格中选中要删除的联系人!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //修改联系人
        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
                //获取联系人信息
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string company = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string linePhone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string mobilePhone = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string classification = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string qq = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                UpdateForm updateForm = new UpdateForm(name, company, linePhone, mobilePhone, classification, email, qq);
                updateForm.ShowDialog();
                Table();
            
         
        }

   


        //查询联系人
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string queryTerm = ComboBoxQuery.SelectedItem.ToString();       //获取查询条件

            //按姓名查询
            if (queryTerm == "姓名")
            {
                FindName();
            }
            //按手机号查询
            else if (queryTerm == "移动手机号")
            {
                FindPhone();
            }
            //模糊查询
            else if (queryTerm == "模糊查询")
            {
                FuzzyQuery();
            }
            else {
                FindCompany();             
            }
        }

        //姓名查询
        public void FindName()
        {
            dataGridView1.Rows.Clear();     //清空旧数据 
            Dao dao = new Dao();
            string sql = "select * from AddressInfo where Name = '"+ txtFind .Text+ "'";        //姓名查询SQL语句
            IDataReader dc = dao.read(sql);
            
            //先判断文本框是否为空
            if (txtFind.Text.Equals(""))
            {
                MessageBox.Show("查询不能为空,请重新输入！");
                Table();
            }
            //查询到数据
            else if (dc.Read())       //读取数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            else
            {
                MessageBox.Show("没有找到!");
            }

            dc.Close();
            dao.DaoClose();
        }

        //按移动手机号查询
        public void FindPhone()
        {
            dataGridView1.Rows.Clear();     //清空旧数据 
            Dao dao = new Dao();
            string sql = "select * from AddressInfo where mobilePhone = '" + txtFind.Text + "'";        //姓名查询SQL语句
            IDataReader dc = dao.read(sql);

            //先判断文本框是否为空
            if (txtFind.Text.Equals(""))
            {
                MessageBox.Show("查询不能为空,请重新输入！");
                Table();
            }
            //查询到数据
            else if (dc.Read())       //读取数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            else
            {
                MessageBox.Show("没有找到!");
            }

            dc.Close();
            dao.DaoClose();
        }
        
        //按单位查询
        public void FindCompany()
        {
            dataGridView1.Rows.Clear();     //清空旧数据 
            Dao dao = new Dao();
            string sql = "select * from AddressInfo where company = '" + txtFind.Text + "'";        //姓名查询SQL语句
            IDataReader dc = dao.read(sql);

            //先判断文本框是否为空
            if (txtFind.Text.Equals(""))
            {
                MessageBox.Show("查询不能为空,请重新输入！");
                Table();
            }
            //查询到数据
            else if (dc.Read())       //读取数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            else
            {
                MessageBox.Show("没有找到!");
            }

            dc.Close();
            dao.DaoClose();
        }

        //模糊查询
        public void FuzzyQuery()
        {
            Boolean flag = true;
            dataGridView1.Rows.Clear();     //清空旧数据 
            Dao dao = new Dao();
            string sql = "select * from AddressInfo where [Name] like '%"+txtFind.Text+"%' or company like '%"+txtFind.Text+"%'or mobilePhone like '%"+txtFind.Text+"%'";        //姓名查询SQL语句
            IDataReader dc = dao.read(sql);

            while (dc.Read())       //读取数据
            {
                flag = false;
                //先判断文本框是否为空
                if (txtFind.Text.Equals(""))
                {
                    MessageBox.Show("查询不能为空,请重新输入！");
                    Table();
                    break;
                }
                //查询到数据     
                else
                {
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
                }
            }
            if(flag)
            {
                MessageBox.Show("没有找到!");
            }



            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)//退出登入
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

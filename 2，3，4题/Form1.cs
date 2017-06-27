using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2_3_4题
{
    public partial class Form1 : Form
    {
      //数据库连接对象
        SqlConnection sqlcon = null;
        //数据库连接字符串
        string strcon = "Data Source=HP201-1;Initial Catalog=Spend;Integrated Security=True";
        //数据集
        DataSet ds = null;
        //适配器
        SqlDataAdapter da = null;
        public Form1()
        {
            InitializeComponent();
            getShow();
        }

        public void getShow() {
            //创建数据集
            ds = new DataSet();
            try
            {
                //实例化连接对象
                sqlcon = new SqlConnection(strcon);
                //创建sql语句
                string str = "SELECT conname, conmoney FROM dbo.consume";
                //创建适配器
                da = new SqlDataAdapter(str, sqlcon);
                //填充
                da.Fill(ds, "consume");
                //绑定数据源
                dgvshow.DataSource = ds.Tables["consume"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally {
                sqlcon.Close();
            }
         
        }

        private void lblzje_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }
     
        /// <summary>
        /// 计算花费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnjs_Click(object sender, EventArgs e)
        {

            //实例化连接对象
            sqlcon = new SqlConnection(strcon);
            //创建sql语句
            string str = "SELECT SUM(conmoney) FROM dbo.consume ";
            //创建命令对象
            SqlCommand cmd = new SqlCommand(str, sqlcon);
            sqlcon.Open();
            txtqian.Text = cmd.ExecuteScalar().ToString();
        }

        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            try{
                //自动生成用户更新的命令
                SqlCommandBuilder bu = new SqlCommandBuilder(da);
                //调用适配器update方法更新数据库
                da.Update(ds, "consume");
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

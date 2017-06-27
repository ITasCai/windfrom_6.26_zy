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

namespace 第五题
{
    public partial class txtname : Form
    {

        //连接对象
        SqlConnection con = null;
        //连接字符串
        string strcon = "Data Source=HP201-1;Initial Catalog=goods;Integrated Security=True";
        
        //数据集
        DataSet ds = null;
        //适配器
        SqlDataAdapter da = null;

        public txtname()
        {
            InitializeComponent();
            getShow();
        }

        private void txtname_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 在页面显示数据
        /// </summary>
        private void getShow() {

            con = new SqlConnection(strcon);

            try
            {
                //定义一个sql语句
                string strsql = "SELECT conname, conlx, concount, conqian FROM dbo.commodity";
                //创建数据集
                ds = new DataSet();
                //创建适配器
                da = new SqlDataAdapter(strsql, con);
                //填充数据
                da.Fill(ds, "commodity");
                //在界面显示数据
                dgvshow.DataSource = ds.Tables["commodity"];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
              
            
        }

        /// <summary>
        /// 商品名称查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncx_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            try
            {
                //sql语句
                StringBuilder sdsql = new StringBuilder("SELECT*FROM dbo.commodity");
                sdsql.AppendFormat(" where conname like '%{0}%'", txtconname.Text.Trim());
                ds = new DataSet();
                da = new SqlDataAdapter(sdsql.ToString(), con);
                da.Fill(ds, "commodity");
                dgvshow.DataSource = ds.Tables["commodity"];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                con.Close();
            }
                
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            try
            {
                //自动生成用户更新的命令
                SqlCommandBuilder bu = new SqlCommandBuilder(da);
                //调用适配器update方法更新数据库
                da.Update(ds, "commodity");
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}

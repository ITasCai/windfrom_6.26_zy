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

namespace 第一题
{
    public partial class Form1 : Form
    {
        //定义连接对象
        SqlConnection sqlcont = null;
        //定义连接字符串
        string strcon = "Data Source=HP201-1;Initial Catalog=game;Integrated Security=True";
        //定义一个数据集
        DataSet ds = null;
        //定义一个适配器
        SqlDataAdapter da = null;

        public Form1()
        {
            InitializeComponent();
            //调用游戏类别绑定
            getGameLx();
            getShowAll();
            getGeLx();
        }


        /// <summary>
        /// 游戏类别绑定
        /// </summary>
        private void getGameLx() {
            //创建一个数据集
            ds = new DataSet();
            //实例化连接对象
            sqlcont = new SqlConnection(strcon);
            //创建查询sql语句
            string sql = "SELECT * FROM gamelx";
            sqlcont.Open();
            //创建DataAdapter对象
            da = new SqlDataAdapter(sql,sqlcont);
            //填充数据集
            da.Fill(ds, "gamelx");
            //向用户类别第一行添加数据“全部”
            DataRow row = ds.Tables["gamelx"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["gamelx"].Rows.InsertAt(row, 0);
            //绑定游戏类别，指定数据源
            cmblx.DataSource = ds.Tables["gamelx"];
            //实际值
            cmblx.ValueMember = "gid";
            cmblx.DisplayMember = "gname";

        }

        private void getGeLx()
        {
            //创建一个数据集
            ds = new DataSet();
            //实例化连接对象
            sqlcont = new SqlConnection(strcon);
            //创建查询sql语句
            string sql = "SELECT * FROM gamelx";
            sqlcont.Open();
            //创建DataAdapter对象
            da = new SqlDataAdapter(sql, sqlcont);
            //填充数据集
            da.Fill(ds, "gamelx");
            //向用户类别第一行添加数据“全部”
            DataRow row = ds.Tables["gamelx"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["gamelx"].Rows.InsertAt(row, 0);
            //绑定游戏类别，指定数据源
            cmbyxlx.DataSource = ds.Tables["gamelx"];
            //实际值
            cmbyxlx.ValueMember = "gid";
            cmbyxlx.DisplayMember = "gname";

        }

        private DataSet getShowAll() {
            //定义数据集
            ds = new DataSet();
            //实例化连接对象
            sqlcont = new SqlConnection(strcon);
            //定义连接字符串
            StringBuilder strsql = new StringBuilder("SELECT pid,pname,gname,pgs,pje FROM dbo.Play, dbo.gamelx WHERE dbo.Play.gid=dbo.gamelx.gid");
            if (Convert.ToInt32(cmblx.SelectedValue) != -1)
            {
                //根据所选的游戏类别的值查询用户游戏表相关内容
                strsql.AppendFormat(" and gamelx.gid='{0}'", Convert.ToInt32(this.cmblx.SelectedValue));
            }
         
            try
            {
                //打开连接
                sqlcont.Open();
                //定义适配器
                da = new SqlDataAdapter(strsql.ToString(), sqlcont);

                //填充表
                da.Fill(ds, "gamelx");
                //绑定数据源
                dgvshow.DataSource = ds.Tables["gamelx"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭连接
                sqlcont.Close();
            }
            return ds;
        }


        private void lbllx_Click(object sender, EventArgs e)
        {

        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlx_Click(object sender, EventArgs e)
        {
            getShowAll();
        }

        /// <summary>
        /// 模糊查询，查询出游戏表内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnyx_Click(object sender, EventArgs e)
        {
            //定义数据集
            ds = new DataSet();
            //实例化连接对象
            sqlcont = new SqlConnection(strcon);
            //定义连接字符串
            StringBuilder strsql = new StringBuilder("SELECT pid,pname,gname,pgs,pje FROM dbo.Play, dbo.gamelx WHERE dbo.Play.gid=dbo.gamelx.gid");
       
                //根据所选的游戏名称的值查询游戏表相关内容
                strsql.AppendFormat(" and pname like '%{0}%'",txtyx.Text.Trim());
          
            try
            {
                //打开连接
                sqlcont.Open();
                //定义适配器
                da = new SqlDataAdapter(strsql.ToString(), sqlcont);

                //填充表
                da.Fill(ds, "gamelx");
                //绑定数据源
                dgvshow.DataSource = ds.Tables["gamelx"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭连接
                sqlcont.Close();
            }
         
        }
        /// <summary>
        /// 增删改数据库操作
        /// </summary>
        /// <param name="strsql"></param>
        /// <returns></returns>
        private bool ExecuteNonQuery(string strsql)
        {
            //实例化
            sqlcont = new SqlConnection(strcon);
            //返回影响的行数
            int res = 0;
            try
            {
                //打开连接
                sqlcont.Open();
                //定义连接
                SqlCommand com = new SqlCommand(strsql, sqlcont);
                res = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭连接
                sqlcont.Close();
            }
            //返回数据集
            return res > 0;
        }


        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("INSERT INTO dbo.Play(  pname, pgs, pje, gid )VALUES  ( '{0}','{1}','{2}','{3}')",txtpname.Text.Trim(),txtgs.Text.Trim(),txtqian.Text.Trim(), Convert.ToInt32(cmbyxlx.SelectedValue));

            if (ExecuteNonQuery(strsql))
            {
                MessageBox.Show("添加成功");

                getShowAll();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnxg_Click(object sender, EventArgs e)
        {
            if (txtpid.Text.Trim().Length > 0)
            {

                string strsql = string.Format("UPDATE dbo.Play SET  pname='{0}', pgs='{1}', pje={2}, gid={3} where pid={4}", txtpname.Text.Trim(), txtgs.Text.Trim(), txtqian.Text.Trim(), Convert.ToInt32(cmbyxlx.SelectedValue),txtpid.Text.Trim());

                if (ExecuteNonQuery(strsql))
                {
                    MessageBox.Show("修改成功");

                    getShowAll();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("请选择一名用户在修改");
            }
        }

        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //取出行的下标
            int index = dgvshow.CurrentCell.RowIndex;
            //取出卡号
            txtpid.Text = dgvshow.Rows[index].Cells[0].Value.ToString();
            //游戏名称
            txtpname.Text = dgvshow.Rows[index].Cells[1].Value.ToString();
            //游戏类别
            cmbyxlx.Text = dgvshow.Rows[index].Cells[2].Value.ToString();
            //游戏公司
            txtgs.Text = dgvshow.Rows[index].Cells[3].Value.ToString();
            //充值金额
            txtqian.Text = dgvshow.Rows[index].Cells[4].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtpid.Text.Trim().Length > 0)
            {

                string strsql = string.Format("DELETE dbo.Play  where pid={0}", txtpid.Text.Trim());

                if (ExecuteNonQuery(strsql))
                {
                    MessageBox.Show("删除成功");

                    getShowAll();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("请选择一名用户在删除");
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnsx_Click(object sender, EventArgs e)
        {
            //移除数据
            getShowAll().Clear();
            //添加数据
            getShowAll();
            MessageBox.Show("刷新成功！");

        }
    }
}

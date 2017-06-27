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

namespace 第六题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("commodity");
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("type", typeof(string));
            dt.Columns.Add("number",typeof(int));
            dt.Columns.Add("price", typeof(double));

            DataRow dr;
            dr = dt.NewRow();
            dr["id"] = 1;
            dr["name"] = "营养快线";
            dr["type"] = "饮料";
            dr["number"] = 10000;
            dr["price"] = 6;
            dt.Rows.Add(dr);
            dgvshow.DataSource = dt;

        }
    }
}

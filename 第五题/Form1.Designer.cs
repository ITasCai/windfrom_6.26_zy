namespace 第五题
{
    partial class txtname
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblname = new System.Windows.Forms.Label();
            this.txtconname = new System.Windows.Forms.TextBox();
            this.btncx = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.btnxg = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.conname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conlx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conqian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(23, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 12);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "商品名称：";
            // 
            // txtconname
            // 
            this.txtconname.Location = new System.Drawing.Point(95, 17);
            this.txtconname.Name = "txtconname";
            this.txtconname.Size = new System.Drawing.Size(100, 21);
            this.txtconname.TabIndex = 1;
            // 
            // btncx
            // 
            this.btncx.Location = new System.Drawing.Point(232, 12);
            this.btncx.Name = "btncx";
            this.btncx.Size = new System.Drawing.Size(75, 23);
            this.btncx.TabIndex = 2;
            this.btncx.Text = "查询";
            this.btncx.UseVisualStyleBackColor = true;
            this.btncx.Click += new System.EventHandler(this.btncx_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conname,
            this.conlx,
            this.concount,
            this.conqian});
            this.dgvshow.Location = new System.Drawing.Point(8, 55);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowTemplate.Height = 23;
            this.dgvshow.Size = new System.Drawing.Size(424, 150);
            this.dgvshow.TabIndex = 3;
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(119, 223);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 4;
            this.btnxg.Text = "保存修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(277, 223);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 5;
            this.btnno.Text = "关闭";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // conname
            // 
            this.conname.DataPropertyName = "conname";
            this.conname.HeaderText = "商品名称";
            this.conname.Name = "conname";
            // 
            // conlx
            // 
            this.conlx.DataPropertyName = "conlx";
            this.conlx.HeaderText = "商品类型";
            this.conlx.Name = "conlx";
            // 
            // concount
            // 
            this.concount.DataPropertyName = "concount";
            this.concount.HeaderText = "商品数量";
            this.concount.Name = "concount";
            // 
            // conqian
            // 
            this.conqian.DataPropertyName = "conqian";
            this.conqian.HeaderText = "单价(元)";
            this.conqian.Name = "conqian";
            // 
            // txtname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 262);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.btncx);
            this.Controls.Add(this.txtconname);
            this.Controls.Add(this.lblname);
            this.Name = "txtname";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtname_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtconname;
        private System.Windows.Forms.Button btncx;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn conname;
        private System.Windows.Forms.DataGridViewTextBoxColumn conlx;
        private System.Windows.Forms.DataGridViewTextBoxColumn concount;
        private System.Windows.Forms.DataGridViewTextBoxColumn conqian;
    }
}


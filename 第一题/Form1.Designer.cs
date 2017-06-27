namespace 第一题
{
    partial class Form1
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
            this.lbllx = new System.Windows.Forms.Label();
            this.cmblx = new System.Windows.Forms.ComboBox();
            this.btnlx = new System.Windows.Forms.Button();
            this.lblyx = new System.Windows.Forms.Label();
            this.txtyx = new System.Windows.Forms.TextBox();
            this.btnyx = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpid = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblgname = new System.Windows.Forms.Label();
            this.cmbyxlx = new System.Windows.Forms.ComboBox();
            this.lblgs = new System.Windows.Forms.Label();
            this.txtgs = new System.Windows.Forms.TextBox();
            this.lblqian = new System.Windows.Forms.Label();
            this.txtqian = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.brnsx = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllx
            // 
            this.lbllx.AutoSize = true;
            this.lbllx.Location = new System.Drawing.Point(12, 21);
            this.lbllx.Name = "lbllx";
            this.lbllx.Size = new System.Drawing.Size(53, 12);
            this.lbllx.TabIndex = 0;
            this.lbllx.Text = "游戏类型";
            this.lbllx.Click += new System.EventHandler(this.lbllx_Click);
            // 
            // cmblx
            // 
            this.cmblx.FormattingEnabled = true;
            this.cmblx.Items.AddRange(new object[] {
            "网页游戏",
            "客户端游戏",
            "手机游戏"});
            this.cmblx.Location = new System.Drawing.Point(89, 13);
            this.cmblx.Name = "cmblx";
            this.cmblx.Size = new System.Drawing.Size(121, 20);
            this.cmblx.TabIndex = 1;
            // 
            // btnlx
            // 
            this.btnlx.Location = new System.Drawing.Point(216, 12);
            this.btnlx.Name = "btnlx";
            this.btnlx.Size = new System.Drawing.Size(75, 23);
            this.btnlx.TabIndex = 2;
            this.btnlx.Text = "查询";
            this.btnlx.UseVisualStyleBackColor = true;
            this.btnlx.Click += new System.EventHandler(this.btnlx_Click);
            // 
            // lblyx
            // 
            this.lblyx.AutoSize = true;
            this.lblyx.Location = new System.Drawing.Point(321, 21);
            this.lblyx.Name = "lblyx";
            this.lblyx.Size = new System.Drawing.Size(53, 12);
            this.lblyx.TabIndex = 3;
            this.lblyx.Text = "游戏名称";
            // 
            // txtyx
            // 
            this.txtyx.Location = new System.Drawing.Point(380, 14);
            this.txtyx.Name = "txtyx";
            this.txtyx.Size = new System.Drawing.Size(100, 21);
            this.txtyx.TabIndex = 4;
            // 
            // btnyx
            // 
            this.btnyx.Location = new System.Drawing.Point(497, 16);
            this.btnyx.Name = "btnyx";
            this.btnyx.Size = new System.Drawing.Size(75, 23);
            this.btnyx.TabIndex = 5;
            this.btnyx.Text = "查询";
            this.btnyx.UseVisualStyleBackColor = true;
            this.btnyx.Click += new System.EventHandler(this.btnyx_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.gname,
            this.pgs,
            this.pje});
            this.dgvshow.Location = new System.Drawing.Point(0, 59);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowTemplate.Height = 23;
            this.dgvshow.Size = new System.Drawing.Size(595, 178);
            this.dgvshow.TabIndex = 6;
            this.dgvshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshow_CellContentClick);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "卡号";
            this.pid.Name = "pid";
            // 
            // pname
            // 
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = "游戏名称";
            this.pname.Name = "pname";
            // 
            // gname
            // 
            this.gname.DataPropertyName = "gname";
            this.gname.HeaderText = "游戏类型";
            this.gname.Name = "gname";
            // 
            // pgs
            // 
            this.pgs.DataPropertyName = "pgs";
            this.pgs.HeaderText = "游戏公司";
            this.pgs.Name = "pgs";
            // 
            // pje
            // 
            this.pje.DataPropertyName = "pje";
            this.pje.HeaderText = "充值金额";
            this.pje.Name = "pje";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(14, 262);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(35, 12);
            this.lblpid.TabIndex = 7;
            this.lblpid.Text = "卡号:";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(89, 259);
            this.txtpid.Name = "txtpid";
            this.txtpid.ReadOnly = true;
            this.txtpid.Size = new System.Drawing.Size(100, 21);
            this.txtpid.TabIndex = 8;
            this.txtpid.TextChanged += new System.EventHandler(this.txtpid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "游戏名称:";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(323, 262);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(100, 21);
            this.txtpname.TabIndex = 10;
            // 
            // lblgname
            // 
            this.lblgname.AutoSize = true;
            this.lblgname.Location = new System.Drawing.Point(16, 309);
            this.lblgname.Name = "lblgname";
            this.lblgname.Size = new System.Drawing.Size(59, 12);
            this.lblgname.TabIndex = 11;
            this.lblgname.Text = "游戏类型:";
            // 
            // cmbyxlx
            // 
            this.cmbyxlx.FormattingEnabled = true;
            this.cmbyxlx.Items.AddRange(new object[] {
            "网页游戏",
            "客户端游戏",
            "手机游戏"});
            this.cmbyxlx.Location = new System.Drawing.Point(89, 300);
            this.cmbyxlx.Name = "cmbyxlx";
            this.cmbyxlx.Size = new System.Drawing.Size(100, 20);
            this.cmbyxlx.TabIndex = 12;
            // 
            // lblgs
            // 
            this.lblgs.AutoSize = true;
            this.lblgs.Location = new System.Drawing.Point(242, 309);
            this.lblgs.Name = "lblgs";
            this.lblgs.Size = new System.Drawing.Size(59, 12);
            this.lblgs.TabIndex = 13;
            this.lblgs.Text = "游戏公司:";
            // 
            // txtgs
            // 
            this.txtgs.Location = new System.Drawing.Point(323, 309);
            this.txtgs.Name = "txtgs";
            this.txtgs.Size = new System.Drawing.Size(100, 21);
            this.txtgs.TabIndex = 14;
            // 
            // lblqian
            // 
            this.lblqian.AutoSize = true;
            this.lblqian.Location = new System.Drawing.Point(14, 348);
            this.lblqian.Name = "lblqian";
            this.lblqian.Size = new System.Drawing.Size(59, 12);
            this.lblqian.TabIndex = 15;
            this.lblqian.Text = "充值金额:";
            // 
            // txtqian
            // 
            this.txtqian.Location = new System.Drawing.Point(89, 338);
            this.txtqian.Name = "txtqian";
            this.txtqian.Size = new System.Drawing.Size(100, 21);
            this.txtqian.TabIndex = 16;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(18, 383);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(140, 383);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 18;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(244, 383);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // brnsx
            // 
            this.brnsx.Location = new System.Drawing.Point(370, 383);
            this.brnsx.Name = "brnsx";
            this.brnsx.Size = new System.Drawing.Size(75, 23);
            this.brnsx.TabIndex = 20;
            this.brnsx.Text = "刷新";
            this.brnsx.UseVisualStyleBackColor = true;
            this.brnsx.Click += new System.EventHandler(this.brnsx_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(482, 381);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 21;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.brnsx);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtqian);
            this.Controls.Add(this.lblqian);
            this.Controls.Add(this.txtgs);
            this.Controls.Add(this.lblgs);
            this.Controls.Add(this.cmbyxlx);
            this.Controls.Add(this.lblgname);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.btnyx);
            this.Controls.Add(this.txtyx);
            this.Controls.Add(this.lblyx);
            this.Controls.Add(this.btnlx);
            this.Controls.Add(this.cmblx);
            this.Controls.Add(this.lbllx);
            this.Name = "Form1";
            this.Text = "游戏点卡管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllx;
        private System.Windows.Forms.ComboBox cmblx;
        private System.Windows.Forms.Button btnlx;
        internal System.Windows.Forms.Label lblyx;
        private System.Windows.Forms.TextBox txtyx;
        private System.Windows.Forms.Button btnyx;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblgname;
        private System.Windows.Forms.ComboBox cmbyxlx;
        private System.Windows.Forms.Label lblgs;
        private System.Windows.Forms.TextBox txtgs;
        private System.Windows.Forms.Label lblqian;
        private System.Windows.Forms.TextBox txtqian;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button brnsx;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn pje;
    }
}


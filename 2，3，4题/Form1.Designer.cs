namespace _2_3_4题
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
            this.lblzje = new System.Windows.Forms.Label();
            this.txtqian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnjs = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.conname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxg = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblzje
            // 
            this.lblzje.AutoSize = true;
            this.lblzje.Location = new System.Drawing.Point(12, 26);
            this.lblzje.Name = "lblzje";
            this.lblzje.Size = new System.Drawing.Size(65, 12);
            this.lblzje.TabIndex = 0;
            this.lblzje.Text = "花费总金额";
            this.lblzje.Click += new System.EventHandler(this.lblzje_Click);
            // 
            // txtqian
            // 
            this.txtqian.Location = new System.Drawing.Point(104, 17);
            this.txtqian.Name = "txtqian";
            this.txtqian.Size = new System.Drawing.Size(100, 21);
            this.txtqian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "元";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnjs
            // 
            this.btnjs.Location = new System.Drawing.Point(249, 14);
            this.btnjs.Name = "btnjs";
            this.btnjs.Size = new System.Drawing.Size(75, 23);
            this.btnjs.TabIndex = 3;
            this.btnjs.Text = "计算";
            this.btnjs.UseVisualStyleBackColor = true;
            this.btnjs.Click += new System.EventHandler(this.btnjs_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conname,
            this.conmoney});
            this.dgvshow.Location = new System.Drawing.Point(14, 57);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowTemplate.Height = 23;
            this.dgvshow.Size = new System.Drawing.Size(318, 150);
            this.dgvshow.TabIndex = 4;
            this.dgvshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshow_CellContentClick);
            // 
            // conname
            // 
            this.conname.DataPropertyName = "conname";
            this.conname.HeaderText = "用途";
            this.conname.Name = "conname";
            // 
            // conmoney
            // 
            this.conmoney.DataPropertyName = "conmoney";
            this.conmoney.HeaderText = "花费";
            this.conmoney.Name = "conmoney";
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(132, 227);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 5;
            this.btnxg.Text = "保存修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(238, 227);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 6;
            this.btn.Text = "退出";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.btnjs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqian);
            this.Controls.Add(this.lblzje);
            this.Name = "Form1";
            this.Text = "生活预算";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblzje;
        private System.Windows.Forms.TextBox txtqian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnjs;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn conname;
        private System.Windows.Forms.DataGridViewTextBoxColumn conmoney;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btn;
    }
}


namespace MyBookkeeping
{
    partial class Main
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.labMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.cmbDescribe = new System.Windows.Forms.ComboBox();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnSubmin = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(56, 64);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(45, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "类别:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "饮食",
            "住房",
            "交通",
            "衣物",
            "娱乐",
            "其他"});
            this.cmbCategory.Location = new System.Drawing.Point(144, 64);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 1;
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Location = new System.Drawing.Point(56, 102);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(52, 15);
            this.labMoney.TabIndex = 2;
            this.labMoney.Text = "金额：";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(144, 102);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(121, 25);
            this.txtMoney.TabIndex = 3;
            // 
            // cmbDescribe
            // 
            this.cmbDescribe.FormattingEnabled = true;
            this.cmbDescribe.Items.AddRange(new object[] {
            "早餐",
            "午餐",
            "晚餐",
            "零食",
            "水果",
            "衣服",
            "裤子",
            "鞋子",
            "房租"});
            this.cmbDescribe.Location = new System.Drawing.Point(144, 151);
            this.cmbDescribe.Name = "cmbDescribe";
            this.cmbDescribe.Size = new System.Drawing.Size(121, 23);
            this.cmbDescribe.TabIndex = 5;
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Location = new System.Drawing.Point(56, 151);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(45, 15);
            this.lblDescribe.TabIndex = 4;
            this.lblDescribe.Text = "描述:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.cmbType.Location = new System.Drawing.Point(144, 20);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 23);
            this.cmbType.TabIndex = 7;
            this.cmbType.Text = "支出";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(56, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "类型:";
            // 
            // btnSubmin
            // 
            this.btnSubmin.Location = new System.Drawing.Point(59, 187);
            this.btnSubmin.Name = "btnSubmin";
            this.btnSubmin.Size = new System.Drawing.Size(75, 23);
            this.btnSubmin.TabIndex = 8;
            this.btnSubmin.Text = "录入";
            this.btnSubmin.UseVisualStyleBackColor = true;
            this.btnSubmin.Click += new System.EventHandler(this.btnSubmin_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(163, 194);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 15);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "结果显示";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 229);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmin);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbDescribe);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.labMoney);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.ComboBox cmbDescribe;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnSubmin;
        private System.Windows.Forms.Label lblResult;
    }
}


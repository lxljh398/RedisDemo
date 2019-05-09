namespace RedisEdit
{
    partial class AnTong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.del2 = new System.Windows.Forms.GroupBox();
            this.chklistKey = new System.Windows.Forms.CheckedListBox();
            this.selDel = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkeyPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.del2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.select.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(36, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(599, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "-----------------------------------------我是华丽丽的分界线-------------------------------" +
    "---------";
            // 
            // del2
            // 
            this.del2.Controls.Add(this.chklistKey);
            this.del2.Controls.Add(this.selDel);
            this.del2.Location = new System.Drawing.Point(12, 426);
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(637, 181);
            this.del2.TabIndex = 21;
            this.del2.TabStop = false;
            this.del2.Text = "批量删除";
            // 
            // chklistKey
            // 
            this.chklistKey.FormattingEnabled = true;
            this.chklistKey.Items.AddRange(new object[] {
            "AntoineWebApi-ProtectKey",
            "FSUserAccount_",
            "FS_FunctionTree_FS",
            "FS_PostFunctionRight"});
            this.chklistKey.Location = new System.Drawing.Point(11, 28);
            this.chklistKey.Name = "chklistKey";
            this.chklistKey.Size = new System.Drawing.Size(586, 84);
            this.chklistKey.TabIndex = 0;
            // 
            // selDel
            // 
            this.selDel.Location = new System.Drawing.Point(522, 143);
            this.selDel.Name = "selDel";
            this.selDel.Size = new System.Drawing.Size(75, 23);
            this.selDel.TabIndex = 4;
            this.selDel.Text = "删除选中内容";
            this.selDel.UseVisualStyleBackColor = true;
            this.selDel.Click += new System.EventHandler(this.selDel_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(16, 173);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "删除";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkeyPrefix);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key值设置";
            // 
            // txtkeyPrefix
            // 
            this.txtkeyPrefix.Location = new System.Drawing.Point(69, 54);
            this.txtkeyPrefix.Name = "txtkeyPrefix";
            this.txtkeyPrefix.Size = new System.Drawing.Size(543, 21);
            this.txtkeyPrefix.TabIndex = 2;
            this.txtkeyPrefix.Text = "FSUserAccount_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "key前缀值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "key用户ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "注意：根据现有的数据前缀+后缀查询";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(69, 91);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(103, 21);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "lixin";
            // 
            // select
            // 
            this.select.Controls.Add(this.label3);
            this.select.Controls.Add(this.btnGet);
            this.select.Controls.Add(this.btndel);
            this.select.Controls.Add(this.lblValue);
            this.select.Location = new System.Drawing.Point(12, 157);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(637, 207);
            this.select.TabIndex = 18;
            this.select.TabStop = false;
            this.select.Text = "编辑";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "查询结果：";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(16, 23);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "查询";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(78, 60);
            this.lblValue.MaximumSize = new System.Drawing.Size(550, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 12);
            this.lblValue.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 46);
            this.label5.TabIndex = 16;
            this.label5.Text = "当前配置环境为140Redis服务，可正常使用，如果修改Redis配置请及时更新RedisEdit.exe.config，如果没有密码value为空，不做处理，使" +
    "用过程中卡死或者报错确认配置是否变化，如需处理服务器直接修改RedisEdit.exe.config的Redis配置";
            // 
            // AnTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 695);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.del2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label5);
            this.Name = "AnTong";
            this.Text = "AnTong";
            this.del2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.select.ResumeLayout(false);
            this.select.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox del2;
        private System.Windows.Forms.CheckedListBox chklistKey;
        private System.Windows.Forms.Button selDel;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkeyPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label5;
    }
}
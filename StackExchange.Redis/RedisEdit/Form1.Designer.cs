namespace RedisEdit
{
    partial class RedisEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSetValue = new System.Windows.Forms.TextBox();
            this.txtDelMaxValue = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.set = new System.Windows.Forms.GroupBox();
            this.select = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.del = new System.Windows.Forms.GroupBox();
            this.del2 = new System.Windows.Forms.GroupBox();
            this.chklistKey = new System.Windows.Forms.CheckedListBox();
            this.selDel = new System.Windows.Forms.Button();
            this.txtSelDelMaxValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.set.SuspendLayout();
            this.select.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.del.SuspendLayout();
            this.del2.SuspendLayout();
            this.SuspendLayout();
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
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(69, 54);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(543, 21);
            this.txtkey.TabIndex = 2;
            this.txtkey.Text = "AtomicOperation_YChain.AlphaWallet.Model.PO.User.RemainderCoin";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(69, 91);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(103, 21);
            this.txtUserId.TabIndex = 3;
            this.txtUserId.Text = "1";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(513, 20);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "查询";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "查询结果";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(78, 26);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(11, 12);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "0";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(512, 19);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "设置值";
            // 
            // txtSetValue
            // 
            this.txtSetValue.Location = new System.Drawing.Point(69, 24);
            this.txtSetValue.Name = "txtSetValue";
            this.txtSetValue.Size = new System.Drawing.Size(100, 21);
            this.txtSetValue.TabIndex = 3;
            this.txtSetValue.Text = "100";
            // 
            // txtDelMaxValue
            // 
            this.txtDelMaxValue.Location = new System.Drawing.Point(154, 23);
            this.txtDelMaxValue.Name = "txtDelMaxValue";
            this.txtDelMaxValue.Size = new System.Drawing.Size(100, 21);
            this.txtDelMaxValue.TabIndex = 3;
            this.txtDelMaxValue.Text = "1000";
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(513, 21);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "删除";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "设置删除范围的最大值";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 748);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "不同的环境已经配置正常使用，如果修改Redis配置请及时更新RedisEdit.exe.config，如果没有密码value为空，不做处理，使用过程中卡死或者报错" +
    "确认配置是否变化，该配置可以直接使用项目中的CacheSettings.config文件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(617, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "注意：现在Redis的key是由PO属性和用户ID组成，常用用户修改积分处理直接修改用户ID值就行，其他操作参考处理";
            // 
            // set
            // 
            this.set.Controls.Add(this.txtSetValue);
            this.set.Controls.Add(this.btnSet);
            this.set.Controls.Add(this.label6);
            this.set.Location = new System.Drawing.Point(12, 232);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(637, 62);
            this.set.TabIndex = 10;
            this.set.TabStop = false;
            this.set.Text = "修改";
            // 
            // select
            // 
            this.select.Controls.Add(this.label3);
            this.select.Controls.Add(this.btnGet);
            this.select.Controls.Add(this.lblValue);
            this.select.Location = new System.Drawing.Point(12, 164);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(637, 50);
            this.select.TabIndex = 11;
            this.select.TabStop = false;
            this.select.Text = "查询";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key值设置";
            // 
            // del
            // 
            this.del.Controls.Add(this.label4);
            this.del.Controls.Add(this.txtDelMaxValue);
            this.del.Controls.Add(this.btndel);
            this.del.Location = new System.Drawing.Point(12, 316);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(637, 56);
            this.del.TabIndex = 13;
            this.del.TabStop = false;
            this.del.Text = "单独删除";
            // 
            // del2
            // 
            this.del2.Controls.Add(this.label8);
            this.del2.Controls.Add(this.chklistKey);
            this.del2.Controls.Add(this.txtSelDelMaxValue);
            this.del2.Controls.Add(this.selDel);
            this.del2.Location = new System.Drawing.Point(12, 423);
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(637, 307);
            this.del2.TabIndex = 14;
            this.del2.TabStop = false;
            this.del2.Text = "批量删除 (前缀AtomicOperation_YChain.AlphaWallet.Model.PO.已填充)";
            // 
            // chklistKey
            // 
            this.chklistKey.FormattingEnabled = true;
            this.chklistKey.Items.AddRange(new object[] {
            "User.RemainderCoin",
            "CoinsDayStatistic.DayPutCoins",
            "CoinsDayStatistic.DayTakeCoins",
            "CoinsStatistic.AllPutCoins",
            "CoinsStatistic.AllTakeCoins",
            "SeatCoinDayStatistic.PutCoins",
            "SeatCoinDayStatistic.TakeCoins",
            "TableCoinsStatistic.DayPutCoins",
            "TableCoinsStatistic.DayTakeCoins",
            "UserCoinStatistic.BeatCoins",
            "UserCoinStatistic.RechargeCoins",
            "UserCoinStatistic.RedpacketCoins",
            "UserCoinStatistic.CircleMessageCoins",
            "UserCoinStatistic.PutCoins",
            "UserCoinStatistic.TakeCoins",
            "StoreSeatsManager.SeatAllowedQuantity",
            "StoreSeatsManager.RegisterSeatNumber",
            "StoreSeatsManager.ClosedSeatNumber",
            "StoreSeatsManager.LogoutedSeatNumber",
            "StoreSeatsManager.AbnormalSeatNumber"});
            this.chklistKey.Location = new System.Drawing.Point(11, 28);
            this.chklistKey.Name = "chklistKey";
            this.chklistKey.Size = new System.Drawing.Size(586, 228);
            this.chklistKey.TabIndex = 0;
            // 
            // selDel
            // 
            this.selDel.Location = new System.Drawing.Point(512, 272);
            this.selDel.Name = "selDel";
            this.selDel.Size = new System.Drawing.Size(75, 23);
            this.selDel.TabIndex = 4;
            this.selDel.Text = "删除选中内容";
            this.selDel.UseVisualStyleBackColor = true;
            this.selDel.Click += new System.EventHandler(this.selDel_Click);
            // 
            // txtSelDelMaxValue
            // 
            this.txtSelDelMaxValue.Location = new System.Drawing.Point(154, 274);
            this.txtSelDelMaxValue.Name = "txtSelDelMaxValue";
            this.txtSelDelMaxValue.Size = new System.Drawing.Size(100, 21);
            this.txtSelDelMaxValue.TabIndex = 3;
            this.txtSelDelMaxValue.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "设置删除范围的最大值";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(59, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(539, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "------------------------------------我是华丽丽的分界线-----------------------------------";
            // 
            // RedisEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 808);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.del2);
            this.Controls.Add(this.del);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.set);
            this.Controls.Add(this.label5);
            this.Name = "RedisEdit";
            this.Text = "Redis处理";
            this.set.ResumeLayout(false);
            this.set.PerformLayout();
            this.select.ResumeLayout(false);
            this.select.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.del.ResumeLayout(false);
            this.del.PerformLayout();
            this.del2.ResumeLayout(false);
            this.del2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetValue;
        private System.Windows.Forms.TextBox txtDelMaxValue;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox set;
        private System.Windows.Forms.GroupBox select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox del;
        private System.Windows.Forms.GroupBox del2;
        private System.Windows.Forms.CheckedListBox chklistKey;
        private System.Windows.Forms.Button selDel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSelDelMaxValue;
        private System.Windows.Forms.Label label9;
    }
}


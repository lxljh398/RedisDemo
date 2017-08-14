﻿using redis_Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisEdit
{
    public partial class RedisEdit : Form
    {
        public RedisEdit()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkey.Text + ":" + this.txtUserId.Text;
            var value = RedisHelper.StringGet(redisKey);
            if (value != null)
                this.lblValue.Text = value;
            else
                this.lblValue.Text = "不存在";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkey.Text + ":" + this.txtUserId.Text;
            RedisHelper.StringSet(redisKey, this.txtSetValue.Text);
            DialogResult dr = MessageBox.Show("OK");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkey.Text + ":";
            int maxDelValue = int.Parse(this.txtDelMaxValue.Text);
            for (int i = 1; i < maxDelValue; i++)
            {
                RedisHelper.KeyDelete(redisKey + i.ToString());
            }
            DialogResult dr = MessageBox.Show("OK");
        }
    }
}

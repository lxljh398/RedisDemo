using redis_Demo;
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
    public partial class Redis处理 : Form
    {
        public Redis处理()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkey.Text + ":" + this.txtUserId.Text;
            var a = RedisHelper.StringGet(redisKey);
            this.lblValue.Text = a;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkey.Text + ":" + this.txtUserId.Text;
            RedisHelper.StringSet(redisKey, this.txtSetValue.Text);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkey.Text + ":";
            int maxDelValue = int.Parse(this.txtDelMaxValue.Text);
            for (int i = 1; i < maxDelValue; i++)
            {
                RedisHelper.KeyDelete(redisKey + i.ToString());
            }
        }
    }
}

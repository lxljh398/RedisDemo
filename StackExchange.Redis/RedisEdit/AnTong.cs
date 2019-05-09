using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using redis_Demo;
using StackExchange.Redis;

namespace RedisEdit
{
    public partial class AnTong : Form
    {
        public AnTong()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkeyPrefix.Text + this.txtUser.Text;
            var value = RedisHelper.StringGet(redisKey);
            if (value != null)
                this.lblValue.Text = value;
            else
                this.lblValue.Text = "不存在";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string redisKey = this.txtkeyPrefix.Text + this.txtUser.Text;
            RedisHelper.KeyDelete(redisKey);
            DialogResult dr = MessageBox.Show("OK");
            this.lblValue.Text = "已删除";
        }

        private void selDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklistKey.Items.Count; i++)
            {
                if (chklistKey.GetItemChecked(i))
                {
                    string redisKey = chklistKey.Items[i].ToString();
                    if (redisKey == "AntoineWebApi-ProtectKey" || redisKey == "FS_FunctionTree_FS")
                    {
                        RedisHelper.KeyDelete(redisKey);
                    }
                    else
                    {
                        ExistPatternKey(redisKey + "*");
                    }
                }
            }
            DialogResult dr = MessageBox.Show("OK");
        }

        /// <summary>
        /// 判断是否存在包含keyPattern的key
        /// </summary>
        /// <param name="keyPattern"></param>
        /// <returns></returns>
        public void ExistPatternKey(string keyPattern)
        {
            RedisHelper.Manager.GetDatabase().ScriptEvaluate(LuaScript.Prepare(
                //Redis的keys模糊查询：
                " local ks = redis.call('KEYS', @keypattern) " + //local ks为定义一个局部变量，其中用于存储获取到的keys
                " for i=1,#ks,5000 do " +    //#ks为ks集合的个数, 语句的意思： for(int i = 1; i <= ks.Count; i+=5000)
                "     redis.call('del', unpack(ks, i, math.min(i+4999, #ks))) " + //Lua集合索引值从1为起始，unpack为解包，获取ks集合中的数据，每次5000，然后执行删除
                " end " +
                " return true "
                ),
                new { keypattern = keyPattern });
        }
    }
}

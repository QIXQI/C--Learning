using System;
using System.Drawing;
using System.Windows.Forms;

namespace Say_Hello
{
    public partial class Form1 : Form
    {
        Random rand;        // 全局变量

        public Form1()
        {
            InitializeComponent();
            rand = new Random();        // 初始化
        }

        private byte[] GetRandomBytes(int n)
        {
            // n个长度的随机数字组成数组
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);
            textBox1.ForeColor = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);
        }
    }
}

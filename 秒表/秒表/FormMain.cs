using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 秒表
{
    public partial class From : Form
    {
        private int hour =0;
        private int minute = 0;
        private int second = 0;
        private int mSecond = 0;
        public From()
        {
            InitializeComponent();
        }

        private void From_Load(object sender, EventArgs e)
        {
            this.tmControl.Enabled = false;
        }

        private void tmControl_Tick(object sender, EventArgs e)
        {
            this.tmControl.Enabled = true;
            mSecond++;
            //this.lalInfo.Text = mSecond.ToString();
            if (mSecond == 10) 
            {
                second++;
                mSecond = 0;
            }
            if ( second== 60)
            {
                minute++;
                second = 0;
            }
            if (minute== 60)
            {
                hour++;
                minute = 0;
            }
            this.lalInfo.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",hour,minute,second,mSecond);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.tmControl.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //this.tmControl.Enabled = false;
            this.tmControl.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //this.tmControl.Enabled = false;
            this.tmControl.Stop();
            hour =0;
            minute = 0;
            second = 0;
            mSecond = 0;
           // this.lalInfo.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", hour, minute, second, mSecond);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
           // this.txtShow.Text += string.Format("{0:00}\r\n",lalInfo.Text);
            this.txtShow.Text = this.lalInfo.Text + "\r\n" + this.txtShow.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtShow.Text = null;
        }
    }
}

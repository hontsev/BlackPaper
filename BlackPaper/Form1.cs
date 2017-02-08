using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;


namespace BlackPaper
{
    public partial class BlackForm : Form
    {
        //是否开机自动启动
        private bool isAutoRun = false;
        //是否自动调整亮度，默认打开程序时为开
        private bool isAutoChange = true;

        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0x2;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );

        ///<summary>
        /// 设置窗体具有鼠标穿透效果
        ///</summary>
        public void SetPenetrate()
        {
            this.TopMost = true;
            GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
        }

        public BlackForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPenetrate();
            checkIfAutoRun();
            setAutoLight();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 透明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            透明ToolStripMenuItem.Checked = true;
            黑度1ToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            isAutoChange = false;
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        private void 黑度1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.10;
            透明ToolStripMenuItem.Checked = false;
            黑度1ToolStripMenuItem.Checked = true;
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            isAutoChange = false;
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            透明ToolStripMenuItem.Checked = false;
            黑度1ToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Checked = true;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            isAutoChange = false;
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 0.45;
            透明ToolStripMenuItem.Checked = false;
            黑度1ToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            isAutoChange = false;
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 0.65;
            透明ToolStripMenuItem.Checked = false;
            黑度1ToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            isAutoChange = false;
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 0.85;
            透明ToolStripMenuItem.Checked = false;
            黑度1ToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            isAutoChange = false;
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        #region 开机自动运行相关

        /// <summary>
        /// 检查是否开机自动启动，设置按钮状态等
        /// </summary>
        private void checkIfAutoRun()
        {
            RegistryKey loca_chek = Registry.CurrentUser;
            RegistryKey run_Check = loca_chek.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (run_Check.GetValue("BlackPaper") != null && run_Check.GetValue("BlackPaper").ToString().ToLower() != "false")
            {
                isAutoRun = true;
            }
            else
            {
                isAutoRun = false;
            }
            开机自动启动ToolStripMenuItem.Checked = isAutoRun;
        }

        /// <summary>
        /// 做开机自动启动设置，根据isAutoRun值设为或者取消开机自动启动
        /// </summary>
        private void AutoRun()
        {
            //获取程序执行路径
            string starupPath = Application.ExecutablePath;
            //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.
            RegistryKey loca = Registry.CurrentUser;
            RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            try
            {
                //SetValue:存储值的名称
                if (isAutoRun == true)
                {
                    run.DeleteValue("BlackPaper");
                    //run.SetValue("BlackPaper", false);//取消开机运行
                    isAutoRun = false;
                }
                else
                {
                    run.SetValue("BlackPaper", starupPath);//设置开机运行
                    isAutoRun = true;
                }
                loca.Close();
            }
            catch
            { }
        }
        #endregion

        /// <summary>
        /// 根据当前系统时间设置自动亮度
        /// </summary>
        private void setAutoLight()
        {
            if (isAutoChange)
            {
                int nowHour = DateTime.Now.Hour;
                int nowMinute = DateTime.Now.Minute;
                if (nowHour >= 8 && nowHour <= 18)
                {
                    //白天透明
                    this.Opacity = 0;
                }
                else if (nowHour > 18 && nowHour <= 22)
                {
                    //傍晚四分之一
                    this.Opacity = 0.25;
                }
                else
                {
                    //晚上半暗
                    this.Opacity = 0.5;
                }

                透明ToolStripMenuItem.Checked = false;
                黑度1ToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Checked = false;
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem4.Checked = false;
            }
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        private void 开机自动启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoRun();
            开机自动启动ToolStripMenuItem.Checked = isAutoRun;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //定时准备自动调整亮度
            setAutoLight();
        }

        private void 自动调整亮度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAutoChange)
            {
                isAutoChange = false;
            }
            else
            {
                isAutoChange = true;
                setAutoLight();
            }
            自动调整亮度ToolStripMenuItem.Checked = isAutoChange;
        }

        private void 关闭菜单ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
        }
    }
}

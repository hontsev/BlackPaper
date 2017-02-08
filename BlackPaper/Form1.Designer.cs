namespace BlackPaper
{
    partial class BlackForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.黑度1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.透明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动调整亮度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开机自动启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BlackPaper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.黑度1ToolStripMenuItem,
            this.透明ToolStripMenuItem,
            this.自动调整亮度ToolStripMenuItem,
            this.开机自动启动ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.关闭菜单ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 224);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem4.Text = "最黑+++++";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem3.Text = "极黑++++";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "更黑+++";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "较黑++";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 黑度1ToolStripMenuItem
            // 
            this.黑度1ToolStripMenuItem.Name = "黑度1ToolStripMenuItem";
            this.黑度1ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.黑度1ToolStripMenuItem.Text = "稍黑+";
            this.黑度1ToolStripMenuItem.Click += new System.EventHandler(this.黑度1ToolStripMenuItem_Click);
            // 
            // 透明ToolStripMenuItem
            // 
            this.透明ToolStripMenuItem.Name = "透明ToolStripMenuItem";
            this.透明ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.透明ToolStripMenuItem.Text = "透明 -";
            this.透明ToolStripMenuItem.Click += new System.EventHandler(this.透明ToolStripMenuItem_Click);
            // 
            // 自动调整亮度ToolStripMenuItem
            // 
            this.自动调整亮度ToolStripMenuItem.Name = "自动调整亮度ToolStripMenuItem";
            this.自动调整亮度ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.自动调整亮度ToolStripMenuItem.Text = "自动亮度 @";
            this.自动调整亮度ToolStripMenuItem.Click += new System.EventHandler(this.自动调整亮度ToolStripMenuItem_Click);
            // 
            // 开机自动启动ToolStripMenuItem
            // 
            this.开机自动启动ToolStripMenuItem.Name = "开机自动启动ToolStripMenuItem";
            this.开机自动启动ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.开机自动启动ToolStripMenuItem.Text = "开机自动启动";
            this.开机自动启动ToolStripMenuItem.Click += new System.EventHandler(this.开机自动启动ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关闭菜单ToolStripMenuItem
            // 
            this.关闭菜单ToolStripMenuItem.Name = "关闭菜单ToolStripMenuItem";
            this.关闭菜单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关闭菜单ToolStripMenuItem.Text = "关闭菜单";
            this.关闭菜单ToolStripMenuItem.Click += new System.EventHandler(this.关闭菜单ToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BlackForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(917, 365);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlackForm";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BlackPaper";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 黑度1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 透明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开机自动启动ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 自动调整亮度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭菜单ToolStripMenuItem;
    }
}


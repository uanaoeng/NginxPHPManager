using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.IO;

namespace NginxPHPManager
{
    public partial class mainForm : Form
    {

// =============================================================================
//
// 全局变量声明
//
// =============================================================================

        static string nginxPath;
        static string phpPath;
        static string arguForPHPcgi;

// =============================================================================
//
// 基本方法
//
// =============================================================================

        // 构造方法
        public mainForm()
        {
            InitializeComponent();
        }

        // 从当前程序所在目录下的配置文件 npm.xml 中读取配置文件。
        static void readDataFromJXMLFile()
        {

            XmlDocument doc = new XmlDocument();
            string myConfigs = System.IO.File.ReadAllText(@"npm.xml");
            doc.LoadXml(myConfigs);
            XmlNode root = doc.FirstChild;

            phpPath = root.SelectSingleNode("phpPath").InnerText;
            nginxPath = root.SelectSingleNode("nginxPath").InnerText;
            arguForPHPcgi = root.SelectSingleNode("arguForPHPcgi").InnerText;

        }

        // 判断指定的进程是否已经存在
        static bool checkIfProcessRunning(string processName)
        {
            Process[] process = Process.GetProcessesByName(processName);
            if (process.Length != 0)
                return true;
            else
                return false;
        }

// =============================================================================
//
// 事件响应
//
// =============================================================================

        // 窗体加载时触发
        private void Form1_Load(object sender, EventArgs e)
        {
            readDataFromJXMLFile();

            if (checkIfProcessRunning("nginx"))
            {
                this.label1.Text = "状态：运行中";
            }
            else
            {
                this.label1.Text = "状态：未运行";
                this.btnNginxQuit.Enabled = false;
                this.btnNginxStop.Enabled = false;
                this.btnNginxReload.Enabled = false;
                this.btnNginxReopen.Enabled = false;
            }

            if (checkIfProcessRunning("php-cgi"))
            {
                this.label2.Text = "状态：运行中";
            }
            else
            {
                this.label2.Text = "状态：未运行";
                this.btnPHPStop.Enabled = false;
            }
        }

// -----------------------------------------------------------------------------

        private void btnNginxStart_Click(object sender, EventArgs e)
        {
            if(checkIfProcessRunning("nginx"))
            {
                MessageBox.Show("nginx 已经在运行了，请勿重复启用。");
            }
            else
            {
                Process processName = new Process();
                processName.StartInfo.FileName = nginxPath + @"\nginx.exe";
                processName.StartInfo.WorkingDirectory = nginxPath;
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;
                processName.Start();
                this.label1.Text = "状态：运行中";
                this.btnNginxQuit.Enabled = true;
                this.btnNginxStop.Enabled = true;
                this.btnNginxReload.Enabled = true;
                this.btnNginxReopen.Enabled = true;
            }
        }

// -----------------------------------------------------------------------------

        private void btnNginxStop_Click(object sender, EventArgs e)
        {
            if(checkIfProcessRunning("nginx"))
            {
                Process processName = new Process();
                processName.StartInfo.FileName = nginxPath + @"\nginx.exe";
                processName.StartInfo.WorkingDirectory = nginxPath;
                processName.StartInfo.Arguments = "-s stop";
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;
                processName.Start();
                this.label1.Text = "状态：未运行";
                this.btnNginxQuit.Enabled = false;
                this.btnNginxStop.Enabled = false;
                this.btnNginxReload.Enabled = false;
                this.btnNginxReopen.Enabled = false;
            }
        }

// -----------------------------------------------------------------------------

        private void btnNginxQuit_Click(object sender, EventArgs e)
        {
            if (checkIfProcessRunning("nginx"))
            {
                Process processName = new Process();
                processName.StartInfo.FileName = nginxPath + @"\nginx.exe";
                processName.StartInfo.WorkingDirectory = nginxPath;
                processName.StartInfo.Arguments = "-s quit";
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;
                processName.Start();
                this.label1.Text = "状态：未运行";
                this.btnNginxQuit.Enabled = false;
                this.btnNginxStop.Enabled = false;
                this.btnNginxReload.Enabled = false;
                this.btnNginxReopen.Enabled = false;
            }
        }

// -----------------------------------------------------------------------------

        private void btnNginxReload_Click(object sender, EventArgs e)
        {
            if (checkIfProcessRunning("nginx"))
            {
                Process processName = new Process();
                processName.StartInfo.FileName = nginxPath + @"\nginx.exe";
                processName.StartInfo.WorkingDirectory = nginxPath;
                processName.StartInfo.Arguments = "-s reload";
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;
                processName.Start();
                MessageBox.Show("重新载入配置文件，成功。");
            }
        }

// -----------------------------------------------------------------------------

        private void btnNginxReopen_Click(object sender, EventArgs e)
        {
            if (checkIfProcessRunning("nginx"))
            {
                Process processName = new Process();
                processName.StartInfo.FileName = nginxPath + @"\nginx.exe";
                processName.StartInfo.WorkingDirectory = nginxPath;
                processName.StartInfo.Arguments = "-s reopen";
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;
                processName.Start();
                MessageBox.Show("重新打开日志文件，成功。");
            }
        }

// -----------------------------------------------------------------------------

        private void btnPHPStart_Click(object sender, EventArgs e)
        {
            if (checkIfProcessRunning("php-cgi"))
            {
                MessageBox.Show("php-cgi 已经在运行了，请勿重复启用。");
            }
            else
            {
                Process processName = new Process();
                processName.StartInfo.FileName = phpPath + @"\php-cgi.exe";
                processName.StartInfo.Arguments = arguForPHPcgi;
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;
                processName.Start();
                this.label2.Text = "状态：运行中";
                this.btnPHPStop.Enabled = true;
            }
        }

// -----------------------------------------------------------------------------

        private void btnPHPStop_Click(object sender, EventArgs e)
        {
            if (checkIfProcessRunning("php-cgi"))
            {
                Process processName = new Process();
                processName.StartInfo.FileName = "taskkill.exe";
                processName.StartInfo.Arguments = "/im php-cgi.exe /f";
                processName.StartInfo.UseShellExecute = false;
                processName.StartInfo.CreateNoWindow = true;

                foreach (Process p in Process.GetProcessesByName("php-cgi"))
                {
                    processName.Start();
                    this.label2.Text = "状态：未运行";
                    this.btnPHPStop.Enabled = false;
                }
            }

        }

    }
}

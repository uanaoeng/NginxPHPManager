namespace NginxPHPManager
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNginxStart = new System.Windows.Forms.Button();
            this.btnNginxStop = new System.Windows.Forms.Button();
            this.btnNginxQuit = new System.Windows.Forms.Button();
            this.btnNginxReload = new System.Windows.Forms.Button();
            this.btnNginxReopen = new System.Windows.Forms.Button();
            this.btnPHPStart = new System.Windows.Forms.Button();
            this.btnPHPStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNginxStart
            // 
            this.btnNginxStart.Location = new System.Drawing.Point(6, 61);
            this.btnNginxStart.Name = "btnNginxStart";
            this.btnNginxStart.Size = new System.Drawing.Size(100, 30);
            this.btnNginxStart.TabIndex = 0;
            this.btnNginxStart.Text = "运行";
            this.btnNginxStart.UseVisualStyleBackColor = true;
            this.btnNginxStart.Click += new System.EventHandler(this.btnNginxStart_Click);
            // 
            // btnNginxStop
            // 
            this.btnNginxStop.Location = new System.Drawing.Point(6, 97);
            this.btnNginxStop.Name = "btnNginxStop";
            this.btnNginxStop.Size = new System.Drawing.Size(100, 30);
            this.btnNginxStop.TabIndex = 2;
            this.btnNginxStop.Text = "柔性中止";
            this.btnNginxStop.UseVisualStyleBackColor = true;
            this.btnNginxStop.Click += new System.EventHandler(this.btnNginxStop_Click);
            // 
            // btnNginxQuit
            // 
            this.btnNginxQuit.Location = new System.Drawing.Point(112, 61);
            this.btnNginxQuit.Name = "btnNginxQuit";
            this.btnNginxQuit.Size = new System.Drawing.Size(100, 30);
            this.btnNginxQuit.TabIndex = 3;
            this.btnNginxQuit.Text = "强制中止";
            this.btnNginxQuit.UseVisualStyleBackColor = true;
            this.btnNginxQuit.Click += new System.EventHandler(this.btnNginxQuit_Click);
            // 
            // btnNginxReload
            // 
            this.btnNginxReload.Location = new System.Drawing.Point(112, 97);
            this.btnNginxReload.Name = "btnNginxReload";
            this.btnNginxReload.Size = new System.Drawing.Size(100, 30);
            this.btnNginxReload.TabIndex = 4;
            this.btnNginxReload.Text = "重载配置";
            this.btnNginxReload.UseVisualStyleBackColor = true;
            this.btnNginxReload.Click += new System.EventHandler(this.btnNginxReload_Click);
            // 
            // btnNginxReopen
            // 
            this.btnNginxReopen.Location = new System.Drawing.Point(6, 135);
            this.btnNginxReopen.Name = "btnNginxReopen";
            this.btnNginxReopen.Size = new System.Drawing.Size(100, 30);
            this.btnNginxReopen.TabIndex = 5;
            this.btnNginxReopen.Text = "重载日志";
            this.btnNginxReopen.UseVisualStyleBackColor = true;
            this.btnNginxReopen.Click += new System.EventHandler(this.btnNginxReopen_Click);
            // 
            // btnPHPStart
            // 
            this.btnPHPStart.Location = new System.Drawing.Point(6, 59);
            this.btnPHPStart.Name = "btnPHPStart";
            this.btnPHPStart.Size = new System.Drawing.Size(100, 30);
            this.btnPHPStart.TabIndex = 7;
            this.btnPHPStart.Text = "运行";
            this.btnPHPStart.UseVisualStyleBackColor = true;
            this.btnPHPStart.Click += new System.EventHandler(this.btnPHPStart_Click);
            // 
            // btnPHPStop
            // 
            this.btnPHPStop.Location = new System.Drawing.Point(112, 59);
            this.btnPHPStop.Name = "btnPHPStop";
            this.btnPHPStop.Size = new System.Drawing.Size(100, 30);
            this.btnPHPStop.TabIndex = 9;
            this.btnPHPStop.Text = "中止";
            this.btnPHPStop.UseVisualStyleBackColor = true;
            this.btnPHPStop.Click += new System.EventHandler(this.btnPHPStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNginxStart);
            this.groupBox1.Controls.Add(this.btnNginxStop);
            this.groupBox1.Controls.Add(this.btnNginxQuit);
            this.groupBox1.Controls.Add(this.btnNginxReload);
            this.groupBox1.Controls.Add(this.btnNginxReopen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 171);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nginx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "状态：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPHPStart);
            this.groupBox2.Controls.Add(this.btnPHPStop);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "php-cgi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "状态：";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nginx & PHP 管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNginxStart;
        private System.Windows.Forms.Button btnNginxStop;
        private System.Windows.Forms.Button btnNginxQuit;
        private System.Windows.Forms.Button btnNginxReload;
        private System.Windows.Forms.Button btnNginxReopen;
        private System.Windows.Forms.Button btnPHPStart;
        private System.Windows.Forms.Button btnPHPStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


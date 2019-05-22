namespace ServerTester
{
    partial class FrmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManual));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCPUGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMemGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numMemxG = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDiskPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDiskxG = new System.Windows.Forms.NumericUpDown();
            this.btnDiskGo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNetstatGo = new System.Windows.Forms.Button();
            this.numNetstatSaveDays = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtScreenCapturePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numScreenCaptureSaveDays = new System.Windows.Forms.NumericUpDown();
            this.numScreenCaptureSleep = new System.Windows.Forms.NumericUpDown();
            this.btnScreenCapture = new System.Windows.Forms.Button();
            this.btnPowerCMD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMemxG)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiskxG)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNetstatSaveDays)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenCaptureSaveDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenCaptureSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCPUGo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // btnCPUGo
            // 
            this.btnCPUGo.Location = new System.Drawing.Point(192, 19);
            this.btnCPUGo.Name = "btnCPUGo";
            this.btnCPUGo.Size = new System.Drawing.Size(75, 23);
            this.btnCPUGo.TabIndex = 0;
            this.btnCPUGo.Text = "Go";
            this.btnCPUGo.UseVisualStyleBackColor = true;
            this.btnCPUGo.Click += new System.EventHandler(this.btnCPUGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "约1分钟，CPU都是100%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMemGo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numMemxG);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mem";
            // 
            // btnMemGo
            // 
            this.btnMemGo.Location = new System.Drawing.Point(192, 28);
            this.btnMemGo.Name = "btnMemGo";
            this.btnMemGo.Size = new System.Drawing.Size(75, 23);
            this.btnMemGo.TabIndex = 0;
            this.btnMemGo.Text = "Go";
            this.btnMemGo.UseVisualStyleBackColor = true;
            this.btnMemGo.Click += new System.EventHandler(this.btnMemGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // numMemxG
            // 
            this.numMemxG.Location = new System.Drawing.Point(23, 28);
            this.numMemxG.Name = "numMemxG";
            this.numMemxG.Size = new System.Drawing.Size(72, 20);
            this.numMemxG.TabIndex = 1;
            this.numMemxG.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDiskPath);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numDiskxG);
            this.groupBox3.Controls.Add(this.btnDiskGo);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 120);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disk";
            // 
            // txtDiskPath
            // 
            this.txtDiskPath.Location = new System.Drawing.Point(23, 20);
            this.txtDiskPath.Name = "txtDiskPath";
            this.txtDiskPath.Size = new System.Drawing.Size(244, 20);
            this.txtDiskPath.TabIndex = 3;
            this.txtDiskPath.Text = "d:\\logs\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "G";
            // 
            // numDiskxG
            // 
            this.numDiskxG.Location = new System.Drawing.Point(23, 53);
            this.numDiskxG.Name = "numDiskxG";
            this.numDiskxG.Size = new System.Drawing.Size(72, 20);
            this.numDiskxG.TabIndex = 1;
            this.numDiskxG.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnDiskGo
            // 
            this.btnDiskGo.Location = new System.Drawing.Point(192, 50);
            this.btnDiskGo.Name = "btnDiskGo";
            this.btnDiskGo.Size = new System.Drawing.Size(75, 23);
            this.btnDiskGo.TabIndex = 0;
            this.btnDiskGo.Text = "Go";
            this.btnDiskGo.UseVisualStyleBackColor = true;
            this.btnDiskGo.Click += new System.EventHandler(this.btnDiskGo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(327, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 576);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 557);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnNetstatGo);
            this.groupBox5.Controls.Add(this.numNetstatSaveDays);
            this.groupBox5.Location = new System.Drawing.Point(12, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 120);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "netstat";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(23, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "10s 执行一次netstat.exe -aon \r\n大于设置则写个文件到d:\\logs\\netstat\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "条";
            // 
            // btnNetstatGo
            // 
            this.btnNetstatGo.Location = new System.Drawing.Point(178, 33);
            this.btnNetstatGo.Name = "btnNetstatGo";
            this.btnNetstatGo.Size = new System.Drawing.Size(89, 23);
            this.btnNetstatGo.TabIndex = 2;
            this.btnNetstatGo.Text = "Go 持续监控";
            this.btnNetstatGo.UseVisualStyleBackColor = true;
            this.btnNetstatGo.Click += new System.EventHandler(this.btnNetstatGo_Click);
            // 
            // numNetstatSaveDays
            // 
            this.numNetstatSaveDays.Location = new System.Drawing.Point(104, 33);
            this.numNetstatSaveDays.Name = "numNetstatSaveDays";
            this.numNetstatSaveDays.Size = new System.Drawing.Size(43, 20);
            this.numNetstatSaveDays.TabIndex = 1;
            this.numNetstatSaveDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtScreenCapturePath);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.numScreenCaptureSaveDays);
            this.groupBox6.Controls.Add(this.numScreenCaptureSleep);
            this.groupBox6.Controls.Add(this.btnScreenCapture);
            this.groupBox6.Location = new System.Drawing.Point(12, 416);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 120);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Suspends";
            // 
            // txtScreenCapturePath
            // 
            this.txtScreenCapturePath.Location = new System.Drawing.Point(23, 20);
            this.txtScreenCapturePath.Name = "txtScreenCapturePath";
            this.txtScreenCapturePath.Size = new System.Drawing.Size(244, 20);
            this.txtScreenCapturePath.TabIndex = 3;
            this.txtScreenCapturePath.Text = "d:\\logs\\Suspends";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "s";
            // 
            // numScreenCaptureSaveDays
            // 
            this.numScreenCaptureSaveDays.Location = new System.Drawing.Point(90, 55);
            this.numScreenCaptureSaveDays.Name = "numScreenCaptureSaveDays";
            this.numScreenCaptureSaveDays.Size = new System.Drawing.Size(43, 20);
            this.numScreenCaptureSaveDays.TabIndex = 1;
            this.numScreenCaptureSaveDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numScreenCaptureSleep
            // 
            this.numScreenCaptureSleep.Location = new System.Drawing.Point(23, 53);
            this.numScreenCaptureSleep.Name = "numScreenCaptureSleep";
            this.numScreenCaptureSleep.Size = new System.Drawing.Size(43, 20);
            this.numScreenCaptureSleep.TabIndex = 1;
            this.numScreenCaptureSleep.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Location = new System.Drawing.Point(192, 50);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(75, 23);
            this.btnScreenCapture.TabIndex = 0;
            this.btnScreenCapture.Text = "Go";
            this.btnScreenCapture.UseVisualStyleBackColor = true;
            this.btnScreenCapture.Click += new System.EventHandler(this.BtnScreenCapture_Click);
            // 
            // btnPowerCMD
            // 
            this.btnPowerCMD.Location = new System.Drawing.Point(17, 561);
            this.btnPowerCMD.Name = "btnPowerCMD";
            this.btnPowerCMD.Size = new System.Drawing.Size(232, 23);
            this.btnPowerCMD.TabIndex = 1;
            this.btnPowerCMD.Text = "Get CMD then log then run";
            this.btnPowerCMD.UseVisualStyleBackColor = true;
            this.btnPowerCMD.Click += new System.EventHandler(this.BtnPowerCMD_Click);
            // 
            // FrmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.btnPowerCMD);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManual";
            this.Text = "ServerTester by ctrip.yfliu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMemxG)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiskxG)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNetstatSaveDays)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenCaptureSaveDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenCaptureSleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCPUGo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMemGo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiskGo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDiskxG;
        private System.Windows.Forms.TextBox txtDiskPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMemxG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnNetstatGo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtScreenCapturePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numScreenCaptureSleep;
        private System.Windows.Forms.Button btnScreenCapture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numScreenCaptureSaveDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numNetstatSaveDays;
        private System.Windows.Forms.Button btnPowerCMD;
    }
}


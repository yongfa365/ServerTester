namespace ServerTester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnNetstatGo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMemxG)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiskxG)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.groupBox4.Size = new System.Drawing.Size(461, 402);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CPU";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 383);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btnNetstatGo);
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
            this.numericUpDown1.Location = new System.Drawing.Point(38, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
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
    }
}


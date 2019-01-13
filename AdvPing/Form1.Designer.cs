namespace AdvPing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.numericUpDownCnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTTL = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIPV4 = new System.Windows.Forms.CheckBox();
            this.checkBoxIPV6 = new System.Windows.Forms.CheckBox();
            this.checkBoxNSeg = new System.Windows.Forms.CheckBox();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelContTime = new System.Windows.Forms.Label();
            this.labelPctLost = new System.Windows.Forms.Label();
            this.labelRecved = new System.Windows.Forms.Label();
            this.labelSent = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelLost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTL)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "长度";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(50, 14);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(338, 21);
            this.textBoxIP.TabIndex = 3;
            this.textBoxIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIP_KeyUp);
            // 
            // numericUpDownCnt
            // 
            this.numericUpDownCnt.Location = new System.Drawing.Point(50, 41);
            this.numericUpDownCnt.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownCnt.Name = "numericUpDownCnt";
            this.numericUpDownCnt.Size = new System.Drawing.Size(338, 21);
            this.numericUpDownCnt.TabIndex = 4;
            // 
            // numericUpDownLen
            // 
            this.numericUpDownLen.Location = new System.Drawing.Point(50, 66);
            this.numericUpDownLen.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.numericUpDownLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLen.Name = "numericUpDownLen";
            this.numericUpDownLen.Size = new System.Drawing.Size(338, 21);
            this.numericUpDownLen.TabIndex = 5;
            this.numericUpDownLen.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "TTL";
            // 
            // numericUpDownTTL
            // 
            this.numericUpDownTTL.Location = new System.Drawing.Point(513, 15);
            this.numericUpDownTTL.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.numericUpDownTTL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTTL.Name = "numericUpDownTTL";
            this.numericUpDownTTL.Size = new System.Drawing.Size(305, 21);
            this.numericUpDownTTL.TabIndex = 7;
            this.numericUpDownTTL.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // checkBoxIPV4
            // 
            this.checkBoxIPV4.AutoSize = true;
            this.checkBoxIPV4.Checked = true;
            this.checkBoxIPV4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIPV4.Location = new System.Drawing.Point(394, 16);
            this.checkBoxIPV4.Name = "checkBoxIPV4";
            this.checkBoxIPV4.Size = new System.Drawing.Size(48, 16);
            this.checkBoxIPV4.TabIndex = 8;
            this.checkBoxIPV4.Text = "IPV4";
            this.checkBoxIPV4.UseVisualStyleBackColor = true;
            // 
            // checkBoxIPV6
            // 
            this.checkBoxIPV6.AutoSize = true;
            this.checkBoxIPV6.Checked = true;
            this.checkBoxIPV6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIPV6.Location = new System.Drawing.Point(394, 38);
            this.checkBoxIPV6.Name = "checkBoxIPV6";
            this.checkBoxIPV6.Size = new System.Drawing.Size(48, 16);
            this.checkBoxIPV6.TabIndex = 9;
            this.checkBoxIPV6.Text = "IPV6";
            this.checkBoxIPV6.UseVisualStyleBackColor = true;
            // 
            // checkBoxNSeg
            // 
            this.checkBoxNSeg.AutoSize = true;
            this.checkBoxNSeg.Location = new System.Drawing.Point(394, 60);
            this.checkBoxNSeg.Name = "checkBoxNSeg";
            this.checkBoxNSeg.Size = new System.Drawing.Size(60, 16);
            this.checkBoxNSeg.TabIndex = 10;
            this.checkBoxNSeg.Text = "不分段";
            this.checkBoxNSeg.UseVisualStyleBackColor = true;
            this.checkBoxNSeg.CheckedChanged += new System.EventHandler(this.checkBoxNSeg_CheckedChanged);
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(871, 14);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 11;
            this.buttonBegin.Text = "开始";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Enabled = false;
            this.buttonEnd.Location = new System.Drawing.Point(871, 60);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 12;
            this.buttonEnd.Text = "结束";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.labelContTime, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPctLost, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRecved, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSent, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMax, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAvg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLost, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 24);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // labelContTime
            // 
            this.labelContTime.AutoSize = true;
            this.labelContTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContTime.Location = new System.Drawing.Point(815, 0);
            this.labelContTime.Name = "labelContTime";
            this.labelContTime.Size = new System.Drawing.Size(117, 24);
            this.labelContTime.TabIndex = 7;
            this.labelContTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPctLost
            // 
            this.labelPctLost.AutoSize = true;
            this.labelPctLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPctLost.Location = new System.Drawing.Point(699, 0);
            this.labelPctLost.Name = "labelPctLost";
            this.labelPctLost.Size = new System.Drawing.Size(110, 24);
            this.labelPctLost.TabIndex = 6;
            this.labelPctLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecved
            // 
            this.labelRecved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecved.AutoSize = true;
            this.labelRecved.Location = new System.Drawing.Point(467, 0);
            this.labelRecved.Name = "labelRecved";
            this.labelRecved.Size = new System.Drawing.Size(110, 24);
            this.labelRecved.TabIndex = 4;
            this.labelRecved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSent
            // 
            this.labelSent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(351, 0);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(110, 24);
            this.labelSent.TabIndex = 3;
            this.labelSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(235, 0);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(110, 24);
            this.labelMax.TabIndex = 2;
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMin
            // 
            this.labelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(119, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(110, 24);
            this.labelMin.TabIndex = 1;
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAvg
            // 
            this.labelAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(3, 0);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(110, 24);
            this.labelAvg.TabIndex = 0;
            this.labelAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLost
            // 
            this.labelLost.AutoSize = true;
            this.labelLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLost.Location = new System.Drawing.Point(583, 0);
            this.labelLost.Name = "labelLost";
            this.labelLost.Size = new System.Drawing.Size(110, 24);
            this.labelLost.TabIndex = 5;
            this.labelLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "超时";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Location = new System.Drawing.Point(513, 41);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(105, 21);
            this.numericUpDownTimeout.TabIndex = 15;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "秒";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(17, 135);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(935, 304);
            this.textBoxLog.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 451);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownTimeout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.checkBoxNSeg);
            this.Controls.Add(this.checkBoxIPV6);
            this.Controls.Add(this.checkBoxIPV4);
            this.Controls.Add(this.numericUpDownTTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownLen);
            this.Controls.Add(this.numericUpDownCnt);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(980, 490);
            this.Name = "Form1";
            this.Text = "AdvPing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTL)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.NumericUpDown numericUpDownCnt;
        private System.Windows.Forms.NumericUpDown numericUpDownLen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTTL;
        private System.Windows.Forms.CheckBox checkBoxIPV4;
        private System.Windows.Forms.CheckBox checkBoxIPV6;
        private System.Windows.Forms.CheckBox checkBoxNSeg;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelContTime;
        private System.Windows.Forms.Label labelPctLost;
        private System.Windows.Forms.Label labelRecved;
        private System.Windows.Forms.Label labelSent;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelLost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}


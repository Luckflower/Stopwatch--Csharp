namespace 秒表
{
    partial class From
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lalInfo = new System.Windows.Forms.Label();
            this.tmControl = new System.Windows.Forms.Timer(this.components);
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Tomato;
            this.btnStart.Font = new System.Drawing.Font("宋体", 15F);
            this.btnStart.Location = new System.Drawing.Point(75, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Tomato;
            this.btnPause.Font = new System.Drawing.Font("宋体", 15F);
            this.btnPause.Location = new System.Drawing.Point(185, 113);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(77, 35);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Tomato;
            this.btnStop.Font = new System.Drawing.Font("宋体", 15F);
            this.btnStop.Location = new System.Drawing.Point(290, 113);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lalInfo
            // 
            this.lalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lalInfo.Font = new System.Drawing.Font("宋体", 20F);
            this.lalInfo.ForeColor = System.Drawing.Color.Blue;
            this.lalInfo.Location = new System.Drawing.Point(98, 42);
            this.lalInfo.Name = "lalInfo";
            this.lalInfo.Size = new System.Drawing.Size(254, 27);
            this.lalInfo.TabIndex = 3;
            this.lalInfo.Text = "00：00：00：00";
            // 
            // tmControl
            // 
            this.tmControl.Enabled = true;
            this.tmControl.Tick += new System.EventHandler(this.tmControl_Tick);
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("宋体", 20F);
            this.txtShow.ForeColor = System.Drawing.Color.Red;
            this.txtShow.Location = new System.Drawing.Point(75, 178);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(198, 201);
            this.txtShow.TabIndex = 4;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecord.Font = new System.Drawing.Font("宋体", 15F);
            this.btnRecord.Location = new System.Drawing.Point(290, 218);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 32);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "记录";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("宋体", 15F);
            this.btnClear.Location = new System.Drawing.Point(290, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清零";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 403);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.lalInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Name = "From";
            this.Text = "秒表";
            this.Load += new System.EventHandler(this.From_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lalInfo;
        private System.Windows.Forms.Timer tmControl;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnClear;
    }
}


namespace WordCountGUI
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
            this.beginButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.baseInfoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outPutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.beginButton.Location = new System.Drawing.Point(665, 11);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(110, 50);
            this.beginButton.TabIndex = 0;
            this.beginButton.Text = "开始统计";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 154);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(377, 327);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.Text = "可直接输入，也可导入单词文件";
            // 
            // baseInfoTextBox
            // 
            this.baseInfoTextBox.Location = new System.Drawing.Point(460, 154);
            this.baseInfoTextBox.Multiline = true;
            this.baseInfoTextBox.Name = "baseInfoTextBox";
            this.baseInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.baseInfoTextBox.Size = new System.Drawing.Size(315, 90);
            this.baseInfoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "文本基本信息";
            // 
            // wordCountTextBox
            // 
            this.wordCountTextBox.Location = new System.Drawing.Point(457, 285);
            this.wordCountTextBox.Multiline = true;
            this.wordCountTextBox.Name = "wordCountTextBox";
            this.wordCountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wordCountTextBox.Size = new System.Drawing.Size(312, 185);
            this.wordCountTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "词频统计信息";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectFileButton.Location = new System.Drawing.Point(30, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(150, 50);
            this.selectFileButton.TabIndex = 6;
            this.selectFileButton.Text = "导入单词文件";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(222, 36);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(100, 25);
            this.mTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "词组长度(可选)";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(409, 36);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 25);
            this.nTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "输出单词数量(可选)";
            // 
            // outPutbutton
            // 
            this.outPutbutton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outPutbutton.Location = new System.Drawing.Point(665, 98);
            this.outPutbutton.Name = "outPutbutton";
            this.outPutbutton.Size = new System.Drawing.Size(110, 50);
            this.outPutbutton.TabIndex = 12;
            this.outPutbutton.Text = "导出结果";
            this.outPutbutton.UseVisualStyleBackColor = true;
            this.outPutbutton.Click += new System.EventHandler(this.outPutbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.outPutbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseInfoTextBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.beginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "单词统计器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button outPutbutton;
        public System.Windows.Forms.TextBox infoTextBox;
        public System.Windows.Forms.TextBox baseInfoTextBox;
        public System.Windows.Forms.TextBox wordCountTextBox;
    }
}


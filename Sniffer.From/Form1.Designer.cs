namespace Sniffer.From
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_ = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_Start = new System.Windows.Forms.CheckBox();
            this.txt_End = new System.Windows.Forms.TextBox();
            this.chk_End = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Regex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Regex = new System.Windows.Forms.Button();
            this.cb_Encoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ress = new System.Windows.Forms.Button();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.txt_Source = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbl_RegexOptions = new System.Windows.Forms.CheckedListBox();
            this.cb_.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_
            // 
            this.cb_.Controls.Add(this.tabControl1);
            this.cb_.Controls.Add(this.btn_Regex);
            this.cb_.Controls.Add(this.cb_Encoding);
            this.cb_.Controls.Add(this.label1);
            this.cb_.Controls.Add(this.btn_Ress);
            this.cb_.Controls.Add(this.txt_Url);
            this.cb_.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_.Location = new System.Drawing.Point(0, 0);
            this.cb_.Name = "cb_";
            this.cb_.Size = new System.Drawing.Size(1039, 174);
            this.cb_.TabIndex = 0;
            this.cb_.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(3, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 113);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Start);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chk_Start);
            this.tabPage1.Controls.Add(this.txt_End);
            this.tabPage1.Controls.Add(this.chk_End);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1025, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单项正则";
            this.tabPage1.ToolTipText = "2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Start
            // 
            this.txt_Start.Location = new System.Drawing.Point(52, 20);
            this.txt_Start.Name = "txt_Start";
            this.txt_Start.Size = new System.Drawing.Size(871, 21);
            this.txt_Start.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "结束";
            // 
            // chk_Start
            // 
            this.chk_Start.AutoSize = true;
            this.chk_Start.Location = new System.Drawing.Point(943, 23);
            this.chk_Start.Name = "chk_Start";
            this.chk_Start.Size = new System.Drawing.Size(48, 16);
            this.chk_Start.TabIndex = 6;
            this.chk_Start.Text = "包含";
            this.chk_Start.UseVisualStyleBackColor = true;
            // 
            // txt_End
            // 
            this.txt_End.Location = new System.Drawing.Point(52, 49);
            this.txt_End.Name = "txt_End";
            this.txt_End.Size = new System.Drawing.Size(871, 21);
            this.txt_End.TabIndex = 4;
            // 
            // chk_End
            // 
            this.chk_End.AutoSize = true;
            this.chk_End.Location = new System.Drawing.Point(943, 54);
            this.chk_End.Name = "chk_End";
            this.chk_End.Size = new System.Drawing.Size(48, 16);
            this.chk_End.TabIndex = 6;
            this.chk_End.Text = "包含";
            this.chk_End.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_Regex);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1025, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "多项正则";
            this.tabPage2.ToolTipText = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Regex
            // 
            this.txt_Regex.Location = new System.Drawing.Point(63, 33);
            this.txt_Regex.Name = "txt_Regex";
            this.txt_Regex.Size = new System.Drawing.Size(911, 21);
            this.txt_Regex.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "正则";
            // 
            // btn_Regex
            // 
            this.btn_Regex.Location = new System.Drawing.Point(938, 19);
            this.btn_Regex.Name = "btn_Regex";
            this.btn_Regex.Size = new System.Drawing.Size(75, 23);
            this.btn_Regex.TabIndex = 7;
            this.btn_Regex.Text = "匹配";
            this.btn_Regex.UseVisualStyleBackColor = true;
            this.btn_Regex.Click += new System.EventHandler(this.btn_Regex_Click);
            // 
            // cb_Encoding
            // 
            this.cb_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Encoding.FormattingEnabled = true;
            this.cb_Encoding.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.cb_Encoding.Location = new System.Drawing.Point(754, 20);
            this.cb_Encoding.Name = "cb_Encoding";
            this.cb_Encoding.Size = new System.Drawing.Size(97, 20);
            this.cb_Encoding.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // btn_Ress
            // 
            this.btn_Ress.Location = new System.Drawing.Point(857, 18);
            this.btn_Ress.Name = "btn_Ress";
            this.btn_Ress.Size = new System.Drawing.Size(75, 23);
            this.btn_Ress.TabIndex = 1;
            this.btn_Ress.Text = "抓取";
            this.btn_Ress.UseVisualStyleBackColor = true;
            this.btn_Ress.Click += new System.EventHandler(this.btn_Ress_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(43, 21);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(695, 21);
            this.txt_Url.TabIndex = 0;
            // 
            // txt_Source
            // 
            this.txt_Source.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_Source.Location = new System.Drawing.Point(0, 174);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(524, 432);
            this.txt_Source.TabIndex = 1;
            this.txt_Source.Text = "";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(524, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 432);
            this.panel1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbl_RegexOptions);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1025, 87);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "正则选项";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbl_RegexOptions
            // 
            this.cbl_RegexOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbl_RegexOptions.FormattingEnabled = true;
            this.cbl_RegexOptions.Location = new System.Drawing.Point(0, 0);
            this.cbl_RegexOptions.MultiColumn = true;
            this.cbl_RegexOptions.Name = "cbl_RegexOptions";
            this.cbl_RegexOptions.Size = new System.Drawing.Size(1025, 87);
            this.cbl_RegexOptions.TabIndex = 0;
            this.cbl_RegexOptions.SelectedValueChanged += new System.EventHandler(this.cbl_RegexOptions_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Source);
            this.Controls.Add(this.cb_);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cb_.ResumeLayout(false);
            this.cb_.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ress;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.RichTextBox txt_Source;
        private System.Windows.Forms.TextBox txt_End;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Encoding;
        private System.Windows.Forms.CheckBox chk_Start;
        private System.Windows.Forms.CheckBox chk_End;
        private System.Windows.Forms.Button btn_Regex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Regex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox cbl_RegexOptions;
    }
}


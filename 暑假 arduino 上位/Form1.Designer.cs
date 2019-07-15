namespace 暑假_arduino_上位
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
            this.components = new System.ComponentModel.Container();
            this.port_comboBox = new System.Windows.Forms.ComboBox();
            this.open_button = new System.Windows.Forms.Button();
            this.read_richTextBox = new System.Windows.Forms.RichTextBox();
            this.write_textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // port_comboBox
            // 
            this.port_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port_comboBox.FormattingEnabled = true;
            this.port_comboBox.Location = new System.Drawing.Point(22, 25);
            this.port_comboBox.Name = "port_comboBox";
            this.port_comboBox.Size = new System.Drawing.Size(94, 20);
            this.port_comboBox.TabIndex = 0;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(167, 23);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "打开串口";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // read_richTextBox
            // 
            this.read_richTextBox.Location = new System.Drawing.Point(22, 244);
            this.read_richTextBox.Name = "read_richTextBox";
            this.read_richTextBox.Size = new System.Drawing.Size(196, 126);
            this.read_richTextBox.TabIndex = 2;
            this.read_richTextBox.Text = "";
            // 
            // write_textBox
            // 
            this.write_textBox.Location = new System.Drawing.Point(22, 97);
            this.write_textBox.Name = "write_textBox";
            this.write_textBox.Size = new System.Drawing.Size(100, 21);
            this.write_textBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(252, 347);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "清空";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::暑假_arduino_上位.Properties.Resources.button_Round_64px;
            this.pictureBox1.Location = new System.Drawing.Point(242, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.write_textBox);
            this.Controls.Add(this.read_richTextBox);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.port_comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox port_comboBox;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.RichTextBox read_richTextBox;
        private System.Windows.Forms.TextBox write_textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


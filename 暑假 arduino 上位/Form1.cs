using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 暑假_arduino_上位
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
                port_comboBox.Items.Add("COM" + i.ToString());
            port_comboBox.SelectedIndex = 0;

        }

        private void Open_button_Click(object sender, EventArgs e)
        {

            try
            {
                if (!serialPort1.IsOpen)
                {
                    if (open_button.Text == "打开串口")
                    {
                        serialPort1.Open();
                        open_button.Text = "关闭串口";
                        port_comboBox.Enabled = false;
                    }

                }

                else if (serialPort1.IsOpen)
                {
                    if (open_button.Text == "关闭串口")
                    {
                        serialPort1.Close();
                        open_button.Text = "打开串口";
                        port_comboBox.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("未打开串口");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            read_richTextBox.Clear();
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}

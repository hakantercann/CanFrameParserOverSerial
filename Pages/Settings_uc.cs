using CanFrameParserOverSerial.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CanFrameParserOverSerial.Pages
{
    public partial class Settings_uc : UserControl
    {
        public Settings_uc()
        {
            InitializeComponent();
        }

        private void Settings_uc_Load(object sender, EventArgs e)
        {
            SerialPOrtCard header = new SerialPOrtCard();
            header.label_id.Text = "ID";
            header.label_portName.Text = "Port Name";
            header.label_baudRate.Text = "Baudrate";
            header.label_parity.Text = "Parity Bit";
            header.label_dataBits.Text = "Data Bits";
            header.label_stopBits.Text ="Stop Bits";
            header.label_handshake.Text = "Handshake";
            header.Width = flowLayoutPanel1.Width;
            flowLayoutPanel1.Controls.Add(header);
            var conn = SqLiteHelpers.CreateConnection();
            var list = SqLiteHelpers.GetData(conn);
            foreach (var item in list)
            {
                SerialPOrtCard newCard = new SerialPOrtCard();
                newCard.label_id.Text = item.ID.ToString();
                newCard.label_portName.Text = item.PortName;
                newCard.label_baudRate.Text = item.Baudrate.ToString();
                newCard.label_parity.Text = item.Parity;
                newCard.label_dataBits.Text = item.DataBits.ToString();
                newCard.label_stopBits.Text = item.StopBits.ToString();
                newCard.label_handshake.Text = item.Handshake;
                newCard.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(newCard);
            }
            var myPort = System.IO.Ports.SerialPort.GetPortNames();
            comboBox_portName.Items.AddRange(myPort);
            comboBox_parity.DataSource = Enum.GetValues(typeof(Parity));
            comboBox_parity.SelectedIndex = 0;
            comboBox_stopBits.DataSource = Enum.GetValues(typeof(StopBits));
            comboBox_stopBits.SelectedIndex = 0;
            comboBox_handshake.DataSource = Enum.GetValues(typeof(Handshake));
            comboBox_handshake.SelectedIndex = 0;
            comboBox_dataBits.Items.Add("5");
            comboBox_dataBits.Items.Add("6");
            comboBox_dataBits.Items.Add("7");
            comboBox_dataBits.Items.Add("8");
            comboBox_dataBits.SelectedIndex = 3;
            comboBox_baudRate.Items.Add("300");
            comboBox_baudRate.Items.Add("600");
            comboBox_baudRate.Items.Add("1200");
            comboBox_baudRate.Items.Add("2400");
            comboBox_baudRate.Items.Add("4800");
            comboBox_baudRate.Items.Add("9600");
            comboBox_baudRate.Items.Add("14400");
            comboBox_baudRate.Items.Add("19200");
            comboBox_baudRate.Items.Add("28800");
            comboBox_baudRate.Items.Add("38400");
            comboBox_baudRate.Items.Add("57600");
            comboBox_baudRate.Items.Add("115200");
            comboBox_baudRate.SelectedIndex = 5;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPortSetting serialPortSetting = new SerialPortSetting();
            if(comboBox_portName.Items.Count < 1)
            {
                MessageBox.Show("Port Geçersiz");
                return;
            }
            serialPortSetting.PortName = comboBox_portName.Text;
            serialPortSetting.Baudrate = Convert.ToInt32(comboBox_baudRate.Text);
            serialPortSetting.Parity = comboBox_parity.Text;
            serialPortSetting.DataBits = Convert.ToInt32(comboBox_dataBits.Text);
            serialPortSetting.StopBits = comboBox_stopBits.Text;
            serialPortSetting.Handshake = comboBox_handshake.Text;
            var conn = SqLiteHelpers.CreateConnection();
            SqLiteHelpers.InsertData(conn, serialPortSetting);
        
            var list = SqLiteHelpers.GetData(conn);
            flowLayoutPanel1.Controls.Clear();
            SerialPOrtCard header = new SerialPOrtCard();
            header.label_id.Text = "ID";
            header.label_portName.Text = "Port Name";
            header.label_baudRate.Text = "Baudrate";
            header.label_parity.Text = "Parity Bit";
            header.label_dataBits.Text = "Data Bits";
            header.label_stopBits.Text = "Stop Bits";
            header.label_handshake.Text = "Handshake";

            header.Width = flowLayoutPanel1.Width;
            flowLayoutPanel1.Controls.Add(header);
            foreach (var item in list)
            {
                SerialPOrtCard newCard = new SerialPOrtCard();
                newCard.label_id.Text = item.ID.ToString();
                newCard.label_portName.Text = item.PortName;
                newCard.label_baudRate.Text = item.Baudrate.ToString();
                newCard.label_parity.Text = item.Parity;
                newCard.label_dataBits.Text = item.DataBits.ToString();
                newCard.label_stopBits.Text = item.StopBits.ToString();
                newCard.label_handshake.Text = item.Handshake;
                newCard.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(newCard);
            }
        }
    }
}

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
    public partial class main_uc : UserControl
    {
        private List<CanFrame> canFrames = new List<CanFrame>();
        SerialPort serialPort;
        List<SerialPortSetting> settingsList;
        bool isSet = false;
        bool isRecord = false;
        public main_uc()
        {
            InitializeComponent();

            serialPort = new SerialPort();

        }

        private void main_uc_Load(object sender, EventArgs e)
        {

            var conn = SqLiteHelpers.CreateConnection();
            settingsList = SqLiteHelpers.GetData(conn);
            comboBox_Settings.Items.AddRange(settingsList.Select(x =>
     $"{x.PortName} {x.Baudrate} {x.Parity} {x.DataBits} {x.StopBits} {x.Handshake}")
     .ToArray());
        }

        private void button_selectSetting_Click(object sender, EventArgs e)
        {
            if (comboBox_Settings.Items.Count < 1 && comboBox_Settings.SelectedIndex < 0)
            {
                MessageBox.Show("Geçerli Bir Ayar Seçilmemiştir");

                isSet = false;
                return;
            }
            var index = comboBox_Settings.SelectedIndex;
            var content = settingsList[index];
            serialPort.PortName = content.PortName;
            serialPort.BaudRate = content.Baudrate;
            serialPort.DataBits = content.DataBits;
            try
            {
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), content.Parity, true); // The true makes the parsing case-insensitive
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid parity value: {"parityString"}");
                // Handle the error (e.g., assign a default value or prompt for a correct input)
                serialPort.Parity = Parity.None; // Default fallback
            }
            try
            {
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), content.StopBits, true); // The true makes the parsing case-insensitive
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid StopBits value: {"StopBits"}");
                // Handle the error (e.g., assign a default value or prompt for a correct input)
                serialPort.StopBits = StopBits.None; // Default fallback
            }
            try
            {
                serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), content.Handshake, true); // The true makes the parsing case-insensitive
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid Handshake value: {"Handshake"}");
                // Handle the error (e.g., assign a default value or prompt for a correct input)
                serialPort.Handshake = Handshake.None; // Default fallback
            }
            isSet = true;
        }

        private void button_start2Listen_Click(object sender, EventArgs e)
        {
            if (!isSet)
            {

                MessageBox.Show("Seri Port Ayarını Seçiniz");
                return;
            }
            if (serialPort.IsOpen)
            {
                MessageBox.Show("Seri Port Zaten Açık");
                return;
            }
            serialPort.Open();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SeriPortReceived);
        }
        private void SeriPortReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.
            // ---- The "si_DataReceived" method will be executed on the UI thread, which allows populating the textbox.
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        }
        private delegate void SetTextDeleg(string text);
        private void si_DataReceived(string data)
        {
            var cont = data.Trim();
            byte[] frameBytes = ParseHexStringToBytes(cont);

            if (frameBytes.Length < 2)
            {
                // Invalid frame length
                return;
            }

            byte header = frameBytes[0];
            if (header == 0x7E) // Standard 11-bit CAN frame
            {
                var frame = Parse11BitCANFrame(frameBytes);
                if (frame != null)
                {
                    canFrames.Add(frame);
                    UpdateDataGridView();
                }
            }
            else if (header == 0x7D) // Extended 29-bit CAN frame
            {
                var frame = Parse29BitCANFrame(frameBytes);
                if (frame != null)
                {
                    canFrames.Add(frame);
                    UpdateDataGridView();
                }
            }
            else
            {
                // Unknown frame type
                return;
            }
        }

        private byte[] ParseHexStringToBytes(string hexString)
        {
            try
            {
                string[] hexValues = hexString.Split(' ');
                return hexValues.Select(hex => Convert.ToByte(hex, 16)).ToArray();
            }
            catch
            {
                // Handle invalid hex string
                return Array.Empty<byte>();
            }
        }

        private CanFrame Parse11BitCANFrame(byte[] frameBytes)
        {
            if (frameBytes.Length < 15)
            {
                // Invalid frame length
                return null;
            }

            byte canIdHigh = frameBytes[1];
            byte canIdLow = frameBytes[2];
            byte dlc = frameBytes[3];
            byte[] data = frameBytes.Skip(4).Take(dlc).ToArray();
            byte crcHigh = frameBytes[4 + dlc];
            byte crcLow = frameBytes[5 + dlc];
            byte end = frameBytes[6 + dlc];

            if (end != 0x7F)
            {
                // Invalid frame end
                return null;
            }

            return new CanFrame
            {
                IsExtended = false,
                CANId = (uint)((canIdHigh << 8) | canIdLow),
                DLC = dlc,
                Data = data,
                CRC = (ushort)((crcHigh << 8) | crcLow)
            };
        }

        private CanFrame Parse29BitCANFrame(byte[] frameBytes)
        {
            if (frameBytes.Length < 12)
            {
                // Invalid frame length
                return null;
            }

            byte[] canId = frameBytes.Skip(1).Take(4).ToArray();
            byte dlc = frameBytes[5];
            byte[] data = frameBytes.Skip(6).Take(dlc).ToArray();
            byte crcHigh = frameBytes[6 + dlc];
            byte crcLow = frameBytes[7 + dlc];
            byte end = frameBytes[8 + dlc];

            if (end != 0x7F)
            {
                // Invalid frame end
                return null;
            }

            return new CanFrame
            {
                IsExtended = true,
                CANId = (uint)((canId[0] << 24) | (canId[1] << 16) | (canId[2] << 8) | canId[3]),
                DLC = dlc,
                Data = data,
                CRC = (ushort)((crcHigh << 8) | crcLow)
            };
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Seri Port Zaten Kapalı");
                return;
            }
            serialPort.DataReceived -= SeriPortReceived;
            serialPort.Close();
        }
        private void UpdateDataGridView()
        {
            // Bind the list to the DataGridView
            dataGridView1.DataSource = null; // Clear current binding
            dataGridView1.DataSource = canFrames.Select(frame => new
            {
                FrameType = frame.IsExtended ? "29-bit" : "11-bit",
                CANId = $"0x{frame.CANId:X}",
                DLC = frame.DLC,
                Data = BitConverter.ToString(frame.Data),
                CRC = $"0x{frame.CRC:X4}"
            }).ToList();
        }
        private void button_startRecord_Click(object sender, EventArgs e)
        {
            isRecord = !isRecord;
        }

        private void button_listClear_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                MessageBox.Show("Öncelikle Kapatmanız Gerekmektedir.");
                return;
            }
            canFrames.Clear();
            UpdateDataGridView();
        }
    }
}

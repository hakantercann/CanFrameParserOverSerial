using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFrameParserOverSerial.Classes
{
    public class SerialPortSetting
    {
        public int ID { get; set; }
        public string PortName { get; set; }
        public int Baudrate { get; set; }   
        public string Parity { get; set; }
        public int DataBits { get; set; }
        public string StopBits { get; set; }
        public string Handshake { get; set; }
    }
}

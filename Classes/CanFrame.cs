using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFrameParserOverSerial.Classes
{
    public class CanFrame
    {
        public bool IsExtended { get; set; } 
        public uint CANId { get; set; }
        public byte DLC { get; set; }
        public byte[] Data { get; set; }
        public ushort CRC { get; set; } 
    }
}

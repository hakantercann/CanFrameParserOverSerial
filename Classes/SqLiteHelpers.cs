using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFrameParserOverSerial.Classes
{
    public class SqLiteHelpers
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
        public static void CreateTable(SQLiteConnection conn)
        {// ---- PortName = "COM1", Baud Rate = 19200, Parity = None,
         // ---- Data Bits = 8, Stop Bits = One, Handshake = None
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS SerialPortSetting  (id INTEGER PRIMARY KEY AUTOINCREMENT, portName VARCHAR(20)," +
                "baudRate INT, Parity VARCHAR(20), DataBits INT, StopBits VARCHAR(20), Handshake VARCHAR(20))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

        }
        public static void InsertData(SQLiteConnection conn, SerialPortSetting serialPortSetting)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SerialPortSetting " +
                "(portName, baudRate, Parity, DataBits, StopBits, Handshake) VALUES(@p1, @p2, @p3, @p4, @p5, @p6); ";
            sqlite_cmd.Parameters.Add("@p1", System.Data.DbType.String).Value = serialPortSetting.PortName;
            sqlite_cmd.Parameters.Add("@p2", System.Data.DbType.Int32).Value = serialPortSetting.Baudrate;
            sqlite_cmd.Parameters.Add("@p3", System.Data.DbType.String).Value = serialPortSetting.Parity;
            sqlite_cmd.Parameters.Add("@p4", System.Data.DbType.Int32).Value = serialPortSetting.DataBits;
            sqlite_cmd.Parameters.Add("@p5", System.Data.DbType.String).Value = serialPortSetting.StopBits;
            sqlite_cmd.Parameters.Add("@p6", System.Data.DbType.String).Value = serialPortSetting.Handshake;

            sqlite_cmd.ExecuteNonQuery();

        }
        public static List<SerialPortSetting> GetData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SerialPortSetting";
            var list = new List<SerialPortSetting>();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                SerialPortSetting setting = new SerialPortSetting();
                setting.ID = sqlite_datareader.GetInt32(0);
                setting.PortName = sqlite_datareader.GetString(1);
                setting.Baudrate = sqlite_datareader.GetInt32(2);
                setting.Parity = sqlite_datareader.GetString(3);
                setting.DataBits = sqlite_datareader.GetInt32(4);
                setting.StopBits = sqlite_datareader.GetString(5);
                setting.Handshake = sqlite_datareader.GetString(6);
                list.Add(setting);
            }
            conn.Close();
            return list;
        }
    }
}

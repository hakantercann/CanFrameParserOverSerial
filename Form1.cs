using CanFrameParserOverSerial.Classes;
using CanFrameParserOverSerial.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanFrameParserOverSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var conn = SqLiteHelpers.CreateConnection();
            SqLiteHelpers.CreateTable(conn);
            try
            {
                conn.Close();
            }
            catch
            {

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control control in frame_panel.Controls)
            {
                control.Dispose();
            }
            frame_panel.Controls.Clear();
            frame_panel.Controls.Add(new Settings_uc() { Dock = DockStyle.Fill});
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in frame_panel.Controls)
            {
                control.Dispose();
            }
            frame_panel.Controls.Clear();
            frame_panel.Controls.Add(new main_uc() { Dock = DockStyle.Fill });
        }
    }
}

namespace CanFrameParserOverSerial.Pages
{
    partial class Settings_uc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_dataBits = new System.Windows.Forms.ComboBox();
            this.comboBox_stopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_handshake = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 384);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox_handshake, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_stopBits, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_dataBits, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_parity, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_portName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_baudRate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(849, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_portName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(3, 3);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(135, 36);
            this.comboBox_portName.TabIndex = 1;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_baudRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Location = new System.Drawing.Point(144, 3);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(135, 36);
            this.comboBox_baudRate.TabIndex = 2;
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_parity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Location = new System.Drawing.Point(285, 3);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(135, 36);
            this.comboBox_parity.TabIndex = 3;
            // 
            // comboBox_dataBits
            // 
            this.comboBox_dataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_dataBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_dataBits.FormattingEnabled = true;
            this.comboBox_dataBits.Location = new System.Drawing.Point(426, 3);
            this.comboBox_dataBits.Name = "comboBox_dataBits";
            this.comboBox_dataBits.Size = new System.Drawing.Size(135, 36);
            this.comboBox_dataBits.TabIndex = 4;
            // 
            // comboBox_stopBits
            // 
            this.comboBox_stopBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_stopBits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_stopBits.FormattingEnabled = true;
            this.comboBox_stopBits.Location = new System.Drawing.Point(567, 3);
            this.comboBox_stopBits.Name = "comboBox_stopBits";
            this.comboBox_stopBits.Size = new System.Drawing.Size(135, 36);
            this.comboBox_stopBits.TabIndex = 5;
            // 
            // comboBox_handshake
            // 
            this.comboBox_handshake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_handshake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_handshake.FormattingEnabled = true;
            this.comboBox_handshake.Location = new System.Drawing.Point(708, 3);
            this.comboBox_handshake.Name = "comboBox_handshake";
            this.comboBox_handshake.Size = new System.Drawing.Size(135, 36);
            this.comboBox_handshake.TabIndex = 6;
            // 
            // Settings_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings_uc";
            this.Size = new System.Drawing.Size(992, 424);
            this.Load += new System.EventHandler(this.Settings_uc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ComboBox comboBox_handshake;
        private System.Windows.Forms.ComboBox comboBox_stopBits;
        private System.Windows.Forms.ComboBox comboBox_dataBits;
        private System.Windows.Forms.ComboBox comboBox_parity;
    }
}

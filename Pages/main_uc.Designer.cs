namespace CanFrameParserOverSerial.Pages
{
    partial class main_uc
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_selectSetting = new System.Windows.Forms.Button();
            this.comboBox_Settings = new System.Windows.Forms.ComboBox();
            this.button_start2Listen = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_startRecord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_listClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 671);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33074F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.22234F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11173F));
            this.tableLayoutPanel2.Controls.Add(this.button_listClear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_startRecord, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Stop, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_start2Listen, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_selectSetting, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Settings, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1167, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_selectSetting
            // 
            this.button_selectSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_selectSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_selectSetting.Location = new System.Drawing.Point(650, 3);
            this.button_selectSetting.Name = "button_selectSetting";
            this.button_selectSetting.Size = new System.Drawing.Size(123, 34);
            this.button_selectSetting.TabIndex = 0;
            this.button_selectSetting.Text = "Ayarla";
            this.button_selectSetting.UseVisualStyleBackColor = true;
            this.button_selectSetting.Click += new System.EventHandler(this.button_selectSetting_Click);
            // 
            // comboBox_Settings
            // 
            this.comboBox_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Settings.FormattingEnabled = true;
            this.comboBox_Settings.Location = new System.Drawing.Point(158, 3);
            this.comboBox_Settings.Name = "comboBox_Settings";
            this.comboBox_Settings.Size = new System.Drawing.Size(486, 36);
            this.comboBox_Settings.TabIndex = 2;
            // 
            // button_start2Listen
            // 
            this.button_start2Listen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start2Listen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_start2Listen.Location = new System.Drawing.Point(779, 3);
            this.button_start2Listen.Name = "button_start2Listen";
            this.button_start2Listen.Size = new System.Drawing.Size(123, 34);
            this.button_start2Listen.TabIndex = 3;
            this.button_start2Listen.Text = "Start";
            this.button_start2Listen.UseVisualStyleBackColor = true;
            this.button_start2Listen.Click += new System.EventHandler(this.button_start2Listen_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Stop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Stop.Location = new System.Drawing.Point(908, 3);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(123, 34);
            this.button_Stop.TabIndex = 4;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_startRecord
            // 
            this.button_startRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_startRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_startRecord.Location = new System.Drawing.Point(1037, 3);
            this.button_startRecord.Name = "button_startRecord";
            this.button_startRecord.Size = new System.Drawing.Size(127, 34);
            this.button_startRecord.TabIndex = 5;
            this.button_startRecord.Text = "Kayıt Al";
            this.button_startRecord.UseVisualStyleBackColor = true;
            this.button_startRecord.Click += new System.EventHandler(this.button_startRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 625);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_listClear
            // 
            this.button_listClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_listClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_listClear.Location = new System.Drawing.Point(3, 3);
            this.button_listClear.Name = "button_listClear";
            this.button_listClear.Size = new System.Drawing.Size(149, 34);
            this.button_listClear.TabIndex = 6;
            this.button_listClear.Text = "Liste Temizle";
            this.button_listClear.UseVisualStyleBackColor = true;
            this.button_listClear.Click += new System.EventHandler(this.button_listClear_Click);
            // 
            // main_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "main_uc";
            this.Size = new System.Drawing.Size(1167, 671);
            this.Load += new System.EventHandler(this.main_uc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_startRecord;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_start2Listen;
        private System.Windows.Forms.Button button_selectSetting;
        private System.Windows.Forms.ComboBox comboBox_Settings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_listClear;
    }
}

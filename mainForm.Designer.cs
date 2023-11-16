namespace Scales
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ShowAllLogsCb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetLatestBtn = new System.Windows.Forms.Button();
            this.UartCloseBtn = new System.Windows.Forms.Button();
            this.AvailableUartCbBox = new System.Windows.Forms.ComboBox();
            this.GetLatestTbox = new System.Windows.Forms.TextBox();
            this.UartOpenBtn = new System.Windows.Forms.Button();
            this.LogRTBox = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ShowAllLogsCb);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.GetLatestBtn);
            this.groupBox7.Controls.Add(this.UartCloseBtn);
            this.groupBox7.Controls.Add(this.AvailableUartCbBox);
            this.groupBox7.Controls.Add(this.GetLatestTbox);
            this.groupBox7.Controls.Add(this.UartOpenBtn);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(13, 6);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(446, 132);
            this.groupBox7.TabIndex = 87;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "UART(RS-232) Device Control";
            // 
            // ShowAllLogsCb
            // 
            this.ShowAllLogsCb.AutoSize = true;
            this.ShowAllLogsCb.Checked = true;
            this.ShowAllLogsCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAllLogsCb.Location = new System.Drawing.Point(329, 100);
            this.ShowAllLogsCb.Name = "ShowAllLogsCb";
            this.ShowAllLogsCb.Size = new System.Drawing.Size(105, 20);
            this.ShowAllLogsCb.TabIndex = 90;
            this.ShowAllLogsCb.Text = "Show all logs";
            this.ShowAllLogsCb.UseVisualStyleBackColor = true;
            this.ShowAllLogsCb.CheckedChanged += new System.EventHandler(this.ShowAllLogsCb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Available Device:";
            // 
            // GetLatestBtn
            // 
            this.GetLatestBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetLatestBtn.Location = new System.Drawing.Point(26, 72);
            this.GetLatestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetLatestBtn.Name = "GetLatestBtn";
            this.GetLatestBtn.Size = new System.Drawing.Size(70, 48);
            this.GetLatestBtn.TabIndex = 88;
            this.GetLatestBtn.Text = "Get Latest";
            this.GetLatestBtn.UseVisualStyleBackColor = true;
            this.GetLatestBtn.Click += new System.EventHandler(this.GetLatestBtn_Click);
            // 
            // UartCloseBtn
            // 
            this.UartCloseBtn.Enabled = false;
            this.UartCloseBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UartCloseBtn.Location = new System.Drawing.Point(378, 23);
            this.UartCloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UartCloseBtn.Name = "UartCloseBtn";
            this.UartCloseBtn.Size = new System.Drawing.Size(56, 35);
            this.UartCloseBtn.TabIndex = 87;
            this.UartCloseBtn.Text = "Close";
            this.UartCloseBtn.UseVisualStyleBackColor = true;
            this.UartCloseBtn.Click += new System.EventHandler(this.UartCloseBtn_Click);
            // 
            // AvailableUartCbBox
            // 
            this.AvailableUartCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableUartCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableUartCbBox.FormattingEnabled = true;
            this.AvailableUartCbBox.Location = new System.Drawing.Point(142, 29);
            this.AvailableUartCbBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AvailableUartCbBox.Name = "AvailableUartCbBox";
            this.AvailableUartCbBox.Size = new System.Drawing.Size(141, 24);
            this.AvailableUartCbBox.TabIndex = 1;
            // 
            // GetLatestTbox
            // 
            this.GetLatestTbox.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetLatestTbox.Location = new System.Drawing.Point(112, 84);
            this.GetLatestTbox.Margin = new System.Windows.Forms.Padding(4);
            this.GetLatestTbox.Name = "GetLatestTbox";
            this.GetLatestTbox.Size = new System.Drawing.Size(119, 25);
            this.GetLatestTbox.TabIndex = 85;
            // 
            // UartOpenBtn
            // 
            this.UartOpenBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UartOpenBtn.Location = new System.Drawing.Point(300, 23);
            this.UartOpenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UartOpenBtn.Name = "UartOpenBtn";
            this.UartOpenBtn.Size = new System.Drawing.Size(59, 35);
            this.UartOpenBtn.TabIndex = 84;
            this.UartOpenBtn.Text = "Open";
            this.UartOpenBtn.UseVisualStyleBackColor = true;
            this.UartOpenBtn.Click += new System.EventHandler(this.UartOpenBtn_Click);
            // 
            // LogRTBox
            // 
            this.LogRTBox.Location = new System.Drawing.Point(12, 145);
            this.LogRTBox.Name = "LogRTBox";
            this.LogRTBox.ReadOnly = true;
            this.LogRTBox.Size = new System.Drawing.Size(447, 124);
            this.LogRTBox.TabIndex = 88;
            this.LogRTBox.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1200;
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(473, 275);
            this.Controls.Add(this.LogRTBox);
            this.Controls.Add(this.groupBox7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Scales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button UartCloseBtn;
        private System.Windows.Forms.ComboBox AvailableUartCbBox;
        private System.Windows.Forms.TextBox GetLatestTbox;
        private System.Windows.Forms.Button UartOpenBtn;
        private System.Windows.Forms.RichTextBox LogRTBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button GetLatestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShowAllLogsCb;
    }
}


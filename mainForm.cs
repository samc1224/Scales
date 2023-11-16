using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Scales
{
    public partial class mainForm : Form
    {
        private SynchronizationContext UISync;

        public mainForm()
        {
            InitializeComponent();

            /* Initialize UI Sync Method */
            this.UISync = SynchronizationContext.Current;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            String[] names = SerialPort.GetPortNames();
            AvailableUartCbBox.Items.AddRange(names);
            if (names.Length > 0)
                AvailableUartCbBox.SelectedIndex = 0;
            else
                UartOpenBtn.Enabled = false;

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void TaskAppendNewLineTextIntoLog(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            sb.Append("\r\n");

            UISync.Send((doing) =>
            {
                LogRTBox.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + sb.ToString());
                LogRTBox.ScrollToCaret();
            }, null);
        }

        private void UartOpenBtn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = AvailableUartCbBox.Text;
            serialPort1.Open();
            TaskAppendNewLineTextIntoLog("-> Connect to \"" + serialPort1.PortName + "\" (1200 Baud Rate)");
            UartOpenBtn.Enabled = false;
            UartCloseBtn.Enabled = true;
        }

        private void UartCloseBtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            TaskAppendNewLineTextIntoLog("-> Disconnect \"" + serialPort1.PortName + "\"");
            UartCloseBtn.Enabled = false;
            UartOpenBtn.Enabled = true;
        }

        StringBuilder sbUart = new StringBuilder();
        String strUart;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String str = serialPort1.ReadExisting();
            if(str == "\n")
            {
                strUart = sbUart.ToString();
                if(ShowAllLogsCb.Checked == true)
                    TaskAppendNewLineTextIntoLog("-> " + strUart);
                sbUart.Clear();
            }
            else
            {
                if (str != "\r" && str != "\n")
                    sbUart.Append(str);
            }
        }

        private void GetLatestBtn_Click(object sender, EventArgs e)
        {
            GetLatestTbox.Text = strUart;
            if (GetLatestTbox.Text == "")
                TaskAppendNewLineTextIntoLog("-> No device connected !");
        }

        private void ShowAllLogsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowAllLogsCb.Checked == true)
                LogRTBox.ReadOnly = true;
            else
                LogRTBox.ReadOnly = false;
        }
    }
}

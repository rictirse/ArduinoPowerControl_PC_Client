using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace RS232
{
    public partial class Form1 : Form
    {
        public SerialPort serialPort = new SerialPort();
        bool rs232status = false;
        bool WaitCmd     = false;
        bool FormHide    = false;
        PowerStatus SW   = new PowerStatus();

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
            CheckOpen();
        }

        private void CheckOpen()
        {
            string RunningProcess = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(RunningProcess);
            if (processes.Length == 2)
            {
                if (processes[0].StartTime > processes[1].StartTime)
                {
                    processes[1].Kill();
                }
                else
                {
                    processes[0].Kill();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Rs232PortDoor())
            {
                CtrlStatus(true);
                UpdateUI();
                Status.Text = "RS232 Status : Ready";
            }
        }

        private bool Rs232PortDoor()
        {
            rs232status = true;
            WaitCmd = true;
            serialPort.PortName = "COM5";

            // 檢查 PORT 是否關閉
            if (!serialPort.IsOpen)
                serialPort.Close();

            serialPort.BaudRate = 9600;            // baud rate = 9600
            serialPort.Parity   = Parity.None;     // Parity = none
            serialPort.StopBits = StopBits.One;    // stop bits = one
            serialPort.DataBits = 8;               // data bits = 8

            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

            try
            {
                serialPort.Open();
            }
            catch (InvalidOperationException e)
            {
                rs232status = false;
            }

            if (rs232status)
            {
                serialPort.DiscardInBuffer();                // RX
                serialPort.DiscardOutBuffer();               // TX
                rs232status = checkArduinoStatus("Check_status\r\n");
            }

            return rs232status;
        }

        private void rs232Output(string sCmd)
        {
            char[] cCmd = new char[16];
            cCmd = sCmd.ToCharArray(0, sCmd.Length);

            for (int i = 0; i < cCmd.Length; i++)
            {
                serialPort.Write(cCmd, i, 1);
            }
        }

        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            char[] tmpCmd = new char[16];
            string sCmd = "";
            Thread.Sleep(100);
            serialPort.Read(tmpCmd, 0, tmpCmd.Length);
            for (int i = 0; i <= tmpCmd.Length; i++)
            {
                if (tmpCmd[i] == '\0' || tmpCmd[i] == '\r')
                    break;
                else
                    sCmd = sCmd + tmpCmd[i].ToString();
            }
            CheckStatus(sCmd);
        }

        private bool checkArduinoStatus(string sCmd)
        {
            int iTimeCnt = 0;
            rs232Output(sCmd);
            while (WaitCmd)
            {
                Thread.Sleep(250);
                iTimeCnt++;
                if (iTimeCnt > 5)
                {
                    Status.Text = "RS232 Status : Fail";
                    CtrlStatus(false);
                    WaitCmd = false;
                    return false;
                }
            }
            return true;
        }

        private void CtrlStatus(bool Status)
        {
            btn_Speaker.Enabled      = Status;
            tsm_Speaker.Enabled      = Status;
                                     
            btn_Subwoofer.Enabled    = Status;
            tsm_Subwoofer.Enabled    = Status;

            btn_Preamplifier.Enabled = Status;
            tsm_Preamplifier.Enabled = Status;

            btn_Mixer.Enabled        = Status;
            tsm_Mixer.Enabled        = Status;

            btn_Fan.Enabled          = Status;
            tsm_Fan.Enabled          = Status;

            btn_Extra.Enabled        = Status;
            tsm_Extra.Enabled        = Status;

            btn_Resend.Enabled       = Status;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string tag;
            tag = sender.GetType().Name == "Button" ? 
                ((Control)sender).Tag.ToString() : 
                ((ToolStripMenuItem)sender).Tag.ToString();
            
            CPowerSwitch(tag);
        }

        private void UpdateUI()
        {
            tsm_Speaker.Text      = btn_Speaker.Text      = SW.Speaker      == 1 ? "Speaker ON"      : "Speaker Off";
            tsm_Subwoofer.Text    = btn_Subwoofer.Text    = SW.Subwoofer    == 1 ? "Subwoofer ON"    : "Subwoofer Off";
            tsm_Preamplifier.Text = btn_Preamplifier.Text = SW.Preamplifier == 1 ? "Preamplifier ON" : "Preamplifier Off";
            tsm_Mixer.Text        = btn_Mixer.Text        = SW.Mixer        == 1 ? "Mixer ON"        : "Mixer Off";
            tsm_Fan.Text          = btn_Fan.Text          = SW.Fan          == 1 ? "Fan ON"          : "Fan Off";
            tsm_Extra.Text        = btn_Extra.Text        = SW.Extra        == 1 ? "Extra ON"        : "Extra Off";
        }

        private void CPowerSwitch(string tag)
        {
            WaitCmd = true;
            switch (tag)
            {
                case "Speaker":
                    SW.Speaker = SW.Speaker == 0 ? 1 : 0;
                    tsm_Speaker.Text = btn_Speaker.Text =
                        SW.Speaker == 1 ? "Speaker ON" : "Speaker Off";
                    break;
                case "Subwoofer":
                    SW.Subwoofer = SW.Subwoofer == 0 ? 1 : 0;
                    tsm_Subwoofer.Text = btn_Subwoofer.Text = 
                        SW.Subwoofer == 1 ? "Subwoofer ON" : "Subwoofer Off";
                    break;
                case "Preamplifier":
                    SW.Preamplifier = SW.Preamplifier == 0 ? 1 : 0;
                    tsm_Preamplifier.Text = btn_Preamplifier.Text = 
                        SW.Preamplifier == 1 ? "Preamplifier ON" : "Preamplifier Off";
                    break;
                case "Mixer":
                    SW.Mixer = SW.Mixer == 0 ? 1 : 0;
                    tsm_Mixer.Text = btn_Mixer.Text = 
                        SW.Mixer == 1 ? "Mixer ON" : "Mixer Off";
                    break;
                case "Fan":
                    SW.Fan = SW.Fan == 0 ? 1 : 0;
                    tsm_Fan.Text = btn_Fan.Text =
                        SW.Fan == 1 ? "Fan ON" : "Fan Off";
                    break;
                case "Extra":
                    SW.Extra = SW.Extra == 0 ? 1 : 0;
                    tsm_Extra.Text = btn_Extra.Text =
                        SW.Extra == 1 ? "Extra ON" : "Extra Off";
                    break;
                default:
                    break;
            }
            rs232Output(SW.Output);
        }

        private void CheckStatus(string text)
        {
            WaitCmd = false;
            string[] s = text.Split(',');

            SW.Speaker      = int.Parse(s[0]);
            SW.Subwoofer    = int.Parse(s[1]);
            SW.Preamplifier = int.Parse(s[2]);
            SW.Mixer        = int.Parse(s[3]);
            SW.Fan          = int.Parse(s[4]);
            SW.Extra        = int.Parse(s[5]);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                FormHide = true;
            }
        }

        private void Form1_Hide()
        {
            if (WindowState == FormWindowState.Normal && FormHide == false)
            {
                FormHide = true;
                Hide();
            }
            else
            {
                FormHide = false;
                Show();
                WindowState = FormWindowState.Normal;
                SetForegroundWindow(Handle);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sowWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Form1_Hide();
        }

        class PowerStatus
        {
            public int Speaker;
            public int Subwoofer;
            public int Preamplifier;
            public int Mixer;
            public int Fan;
            public int Extra;

            public PowerStatus()
            {
                Speaker      = 0;
                Subwoofer    = 0;
                Preamplifier = 0;
                Mixer        = 0;
                Fan          = 0;
                Extra        = 0;
            }

            public string Output
            {
                get
                {
                    return string.Format("{0:D},{1:D},{2:D},{3:D},{4:D},{5:D}\r\n",
                        Speaker, Subwoofer, Preamplifier, Mixer, Fan, Extra);
                }
            }
        }
    }
}

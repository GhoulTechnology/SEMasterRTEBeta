using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMasterRTEBeta
{
    public partial class SEMaster : Form
    {
        bool IsConnected;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public string Cmd { get; private set; }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Move_Window(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public SEMaster()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private async void ChangeText()
        {
            BtnDownloadCvars.Text = "Link Copied!";
            await Task.Delay(2000);
            BtnDownloadCvars.Text = "Download Cvars!";
        }
        private void BtnDownloadCvars_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://cdn.discordapp.com/attachments/902236917544935424/1072379626682318858/X360-Source-Cvars.zip");
            ChangeText();
        }

        private void BtnLoadCFGorTestScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg2 = new OpenFileDialog
            {
                Title = "SE Master | Select a cfg/testscript file",
                InitialDirectory = @"c:\",
                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (fdlg2.ShowDialog() == DialogResult.OK)
            {
            }
        }
        private void CheckConnection(object sender, EventArgs e)
        {
            while (IsConnected)
            {
                TxtConnectionStatus.Text = "Status: Connected";
                Thread.Sleep(5000);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                BtnConnect.Text = "Reconnect";
            }
        }
    }
}

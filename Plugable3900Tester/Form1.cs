using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Management;

namespace Plugable3900Tester
{
    public partial class Form1 : Form
    {

        private CountDownTimer timer = new CountDownTimer();

        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("Screens: " + Screen.AllScreens.Length);
            printScreenProperties(Screen.AllScreens[0]);
            printScreenProperties(Screen.AllScreens[1]);
            printScreenProperties(Screen.AllScreens[2]);

        }

        private void printScreenProperties(Screen screen)
        {
            Console.WriteLine("Device Name: " + screen.DeviceName);
            Console.WriteLine("    Bounds: " + screen.Bounds.ToString());
            Console.WriteLine("    Type: " + screen.GetType().ToString());
            Console.WriteLine("    Working Area: " + screen.WorkingArea.ToString());
            Console.WriteLine("    Primary Screen: " + screen.Primary.ToString());
            Console.WriteLine();
        }

        private void loadProperties()
        {
            Properties.Settings.Default.Reload();
            textBoxVLC.Text = Properties.Settings.Default.VLC_PATH;
            textBoxChrome.Text = Properties.Settings.Default.CHROME_PATH;
            textBoxVideo.Text = Properties.Settings.Default.VID_VIDEO;
            textBoxYoutube.Text = Properties.Settings.Default.VID_YOUTUBE;
        }

        private void saveProperties()
        {
            Properties.Settings.Default.VLC_PATH = textBoxVLC.Text;
            Properties.Settings.Default.CHROME_PATH = textBoxChrome.Text;
            Properties.Settings.Default.VID_VIDEO = textBoxVideo.Text;
            Properties.Settings.Default.VID_YOUTUBE = textBoxYoutube.Text;
            Properties.Settings.Default.Save();
        }

        private void initCountdown()
        {
            timer.SetTime(10, 0);
            //update label text
            timer.TimeChanged += () => countdownTimerText.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            timer.CountDownFinished += () => timerDone();

            timer.StepMs = 33;
        }

        private void timerDone()
        {
            stopTest();
        }

        private void stopTest()
        {
            PROCESS_CHROME.Kill();
            PROCESS_VLC.Kill();
            timer.Pause();
            timer.Reset();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            MessageBox.Show("Test has finished.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Process PROCESS_CHROME;
        Process PROCESS_VLC;

        private void button1_Click(object sender, EventArgs e)
        {
            PROCESS_VLC = launchFullscreenVLCVideo(Screen.AllScreens[1], textBoxVideo.Text);
            PROCESS_CHROME = launchChromeWithYoutubeStub(Screen.AllScreens[2], textBoxYoutube.Text);
            initCountdown();
            timer.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void runCmd(String cmd)
        {
            runProcess("C:\\Windows\\System32\\cmd.exe", "/c " + cmd);
        }

        private Process launchChromeWithYoutubeStub(Screen screen, String videoStub)
        {
            return launchChromeWithLink(screen, "https://www.youtube.com/embed/" + videoStub + "?autoplay=1");
        }

        private Process launchChromeWithLink(Screen screen, String url)
        {
            Rectangle screenCoords = screen.Bounds;
            return maximiseProgramOnMonitor(screen, textBoxChrome.Text, "\"" + url + "\" --window-position=" + screenCoords.X + "," + screenCoords.Y + " --window-size=" + screenCoords.Width + "," + screenCoords.Height + " --start-maximized", false, false); //Chrome is a special snowflake
        }

        private Process launchFullscreenVLCVideo(Screen screen, String video)
        {
            return maximiseProgramOnMonitor(screen, textBoxVLC.Text, "\"" + video + "\" --fullscreen", true, true);
        }

        private Process maximiseProgramOnMonitor(Screen screen, String program, String arguments, Boolean moveWindow, Boolean maximizeWindowUser32)
        {
            Process p = runProcess(program, arguments);

            p.WaitForInputIdle();

            //IntPtr id = getProcessId(p); //Also used to make sure p.MainWindowHandle is not 0. DO NOT REMOVE THIS LINE

            Console.WriteLine("Opened prossess \"" + program + "\" on Monitor \"" + screen.DeviceName + "\".");

            Rectangle screenCoords = screen.Bounds;

            if (moveWindow) {
                Form1.MoveWindow(p.MainWindowHandle, screenCoords.X, screenCoords.Y, screenCoords.Width, screenCoords.Height, true);
            }

            if (maximizeWindowUser32) {
                Form1.ShowWindow(p.MainWindowHandle, SW_MAXIMIZE);
            }

            return p;
        }

        private Process runProcess(String program, String arguments)
        {
            Process p = new Process();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            p.StartInfo.FileName = program;
            p.StartInfo.Arguments = arguments;
            p.Start();
            return p;
        }

        //private IntPtr getProcessId(Process p)
        //{
        //    while (!p.HasExited) {
        //        p.Refresh();
        //        if (IntPtr.Zero != p.MainWindowHandle) {
        //            return p.MainWindowHandle;
        //        }
        //    }
        //    return IntPtr.Zero;
        //}

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProperties();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveProperties();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopTest();
        }
    }
}

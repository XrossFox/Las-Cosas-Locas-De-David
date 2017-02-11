using System;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AutoShutdown
{
    public partial class AutoForm : Form
    {
        private long count = 0;
        private long total = 0;
        private short sec = 0;
        private short min = 0;
        private short hr = 0;
        private Process cmd = new Process();
        private System.Timers.Timer aTimer = new System.Timers.Timer();
        private string shut = "shutdown -s";
        private string reboot = "shutdown -r";


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public AutoForm()
        {
            InitializeComponent();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //AllocConsole();
            count += 1000;
            Console.WriteLine(count+":"+total);
            sec += 1;
            if (sec == 60) {
                sec = 0;
                min += 1;
                TimeLabelMin.Invoke((MethodInvoker)(() => TimeLabelMin.Text = min.ToString()));
            }
            if (min == 60) {
                min = 0;
                hr += 1;
                TimeLabelHr.Invoke((MethodInvoker)(() => TimeLabelHr.Text = min.ToString()));
            }
            TimeLabelSec.Invoke((MethodInvoker)(() => TimeLabelSec.Text=sec.ToString()));

            if (count == total)
            {
                //Console.WriteLine("jolo");
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                if (ShutRadio.Checked)
                {
                    cmd.StandardInput.WriteLine(shut);
                }
                else {
                    cmd.StandardInput.WriteLine(reboot);
                }
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                Application.Exit();

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                total = Int64.Parse(TimeBox.Text)*60*1000;
                StartButton.Enabled = false;
                TimeBox.Enabled = false;
                RebootRadio.Enabled = false;
                ShutRadio.Enabled = false;
                aTimer.Interval = 1000;
                aTimer.Enabled = true;
                aTimer.Start();
            }
            catch (Exception w) {
                MessageBox.Show("Not a number");
                TimeLabelSec.Text = "00";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
            count = 0;
            total = 0;
            TimeLabelHr.Text = "00";
            TimeLabelMin.Text = "00";
            TimeLabelSec.Text = "00";
            sec = 0;
            min = 0;
            hr = 0;
            StartButton.Enabled = true;
            TimeBox.Enabled = true;
            RebootRadio.Enabled = true;
            ShutRadio.Enabled = true;
        }

    }

    public class StartShut {
        public static void Main() {
            AutoForm form;
            form = new AutoForm();
            form.ShowDialog();
        }
    }


}

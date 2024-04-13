using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Runtime.InteropServices;

namespace Iterative_Project
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        static System.Timers.Timer timer;
        int count;
        private Thread thread;
        
        private void SplashForm_Load(object sender, EventArgs e)
        {
            thread = new Thread(PerformBackgroundTask);
            thread.Start();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += UpdateLabel;
            timer.Start();
        }

        private void PerformBackgroundTask()
        {
            Thread.Sleep(10000);

            this.Invoke(new Action(() => {
                this.Hide();

                Main main = new Main();
                main.Show();
            }));
        }

        private void UpdateLabel(object sender, ElapsedEventArgs e)
        {
            if (Thread.CurrentThread.IsAlive)
            {
                if (lblLoading.InvokeRequired)
                {
                    if (count == 0)
                    {
                        lblLoading.Invoke(new Action(() => lblLoading.Text = "Loading."));
                        count++;
                    }
                    else if (count == 1)
                    {
                        lblLoading.Invoke(new Action(() => lblLoading.Text = "Loading.."));
                        count++;
                    }
                    else if (count == 2)
                    {
                        lblLoading.Invoke(new Action(() => lblLoading.Text = "Loading..."));
                        count++;
                    }
                    else
                    {
                        lblLoading.Invoke(new Action(() => lblLoading.Text = "Loading"));
                        count = 0;
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        lblLoading.Text = "Loading.";
                        count++;
                    }
                    else if (count == 1)
                    {
                        lblLoading.Text = "Loading..";
                        count++;
                    }
                    else if (count == 2)
                    {
                        lblLoading.Text = "Loading...";
                        count++;
                    }
                    else
                    {
                        lblLoading.Text = "Loading";
                        count = 0;
                    }
                }
            }
        }
    }
}

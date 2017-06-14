using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Dynamic;
using System.Management;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] proc;
        Dictionary<int, string> CommentDict = new Dictionary<int, string>();

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            ProcessList.Items.Clear();
            foreach (Process p in proc)
            {
                ListViewItem itm = new ListViewItem(p.ProcessName);
                itm.SubItems.Add(Convert.ToString(p.Id));
                ProcessList.Items.Add(itm);
            }


        }

        void GetCpuUsage()
        {
            CounterSample cs1 = performanceCounter1.NextSample();
            System.Threading.Thread.Sleep(100);
            CounterSample cs2 = performanceCounter1.NextSample();
            float cpuUsage = CounterSample.Calculate(cs1, cs2);
            cpuUsage = (cpuUsage < 1.00f) ? 1.00f : cpuUsage;
            label2.Text = string.Format("{0:#,###.##} %", cpuUsage);

        }

        void GetRamUsage()
        { 
            var notNeeded = performanceCounter2.NextValue();
            label5.Text = string.Format("{0:#,###.##} MB", performanceCounter2.NextValue());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
            GetCpuUsage();
            GetRamUsage();
        }

        private void CommentBtn_Click(object sender, EventArgs e)
        {
            string comment = CommentBox.Text;
            int processID = Convert.ToInt32(ProcessList.SelectedItems[0].SubItems[1].Text);
            if (CommentDict.ContainsKey(processID)) 
            {
                CommentDict[processID] = comment;
            }
            else
            { CommentDict.Add(processID, comment); }
            
            CommentBox.Clear();
        }


        private void itemClick(object sender, EventArgs e)
        {
            if (ProcessList.SelectedItems.Count != 0)
            {
                int processID = Convert.ToInt32(ProcessList.SelectedItems[0].SubItems[1].Text);
                proc = Process.GetProcesses();
                ProcessDetails.Items.Clear();
                foreach (Process p in proc)
                {
                    if (p.Id == processID)
                    {
                        long memoryUsage = p.PrivateMemorySize64;
                        TimeSpan runTime = DateTime.Now - p.StartTime;
                        ProcessDetails.Items.Add("Process: " + "\t" + "\t" + p.ProcessName);
                        ProcessDetails.Items.Add(Convert.ToString("Memory Usage: " + "\t" + memoryUsage / 1000000 + " MB"));
                        ProcessDetails.Items.Add("Start Time: " + "\t" + p.StartTime);
                        ProcessDetails.Items.Add("Running Time: " + "\t" + runTime);
                        ProcessDetails.Items.Add("Threads: " + "\t" + "\t" + p.Threads.Count);
                        

                        if (CommentDict.ContainsKey(p.Id))
                        {
                            CommentBox.Text = CommentDict[p.Id];
                        }
                        else
                        {
                            CommentBox.Text = "";
                        }

                    }
                }
            } else { return; }
 
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetAllProcess();
            GetCpuUsage();
            GetRamUsage();
            ProcessDetails.Items.Clear();
        }
    }
}

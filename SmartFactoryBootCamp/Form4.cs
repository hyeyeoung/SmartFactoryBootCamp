using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactoryBootCamp
{
    public partial class Form4 : Form
    {
        BackgroundWorker worker;
        public Form4()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;
            progressBar1.Value = 0;

            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;

            this.worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
        }
        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30);
                this.worker.ReportProgress(i);
            }
        }
        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        void Worker_RunWorkerCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("작업 완료");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.worker.IsBusy) // worker 동작 중이 아닐 때..
            {
                this.worker.RunWorkerAsync();
            }
        }
    }
}

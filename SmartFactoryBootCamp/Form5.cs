using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactoryBootCamp
{
    public partial class Form5 : Form
    {
        BackgroundWorker worker;
        string[] allfiles = new string[101];
        public Form5()
        {
            InitializeComponent();
            listBox1.HorizontalScrollbar = true;

            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            
            this.worker.DoWork += new DoWorkEventHandler(DoWork_SerchFile);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(DoWorker_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DoWorker_RunWorkerCompleted);
        }
        void DoWork_SerchFile(object sender, DoWorkEventArgs e)
        {
            string path = textBox1.Text;
            string file = "*.*";
            Array.Clear(this.allfiles, 0, this.allfiles.Length);

            if (textBox2.Text != "")
            {
                file = textBox2.Text;
            }
            try
            {
                this.allfiles = Directory.GetFiles(path, file, SearchOption.AllDirectories);
                for (int i = 0; i < this.allfiles.Length; i++)
                {
                    this.worker.ReportProgress(i);
                }
            }
            catch (Exception ex)
            {
                // 작업 종료 등록, 파일 경로를 못 찾거나 할 때?
                e.Cancel = true;
            }
        }
        void DoWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(this.allfiles[e.ProgressPercentage]);
        }
        void DoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("다시 입력해주세요");
            }
            else
            {
                MessageBox.Show("작업 완료");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }
        }
    }
}

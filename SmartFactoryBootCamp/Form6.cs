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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        async Task<string> ReadFileAsync()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string FilePath = ofd.FileName; // 파일 경로 가져오기
                var fileStream = ofd.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string fileContent = await reader.ReadToEndAsync();
                    return fileContent;
                }
            }
            return "fail!";
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            
            string Content = await ReadFileAsync();
            string[] Contents = Content.Split('\n');
            textBox1.Text = "";
            for(int i = 0; i < Contents.Count(); i++)
            {
                textBox1.Text += $"{Contents[i]}\r\n";
            }
            
        }
    }
}

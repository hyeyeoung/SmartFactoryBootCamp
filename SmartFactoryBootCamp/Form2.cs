using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactoryBootCamp
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        int computerRSP()
        {
            Random r = new Random();
            int x = r.Next(0, 3);
            return x;
        }
        int use_win = 0;
        int computer_win = 0;
        string[] match = { "가위", "바위", "보" };

        private void Match(int idx, int computer)
        {
            if (idx == 0 && computer == 2)
            {
                use_win++;
            }
            else if (idx == 1 && computer == 0)
            {
                use_win++;
            }
            else if (idx == 2 && computer == 1)
            {
                use_win++;
            }
            else if (idx == 2 && computer == 0)
            {
                computer_win++;
            }
            else if (idx == 0 && computer == 1)
            {
                computer_win++;
            }
            else if (idx == 1 && computer == 2)
            {
                computer_win++;
            }
            resultBox.Text += "사용자: " + match[idx] + " 컴퓨터: " + match[computer] + " | 점수 사용자: " + use_win.ToString() + " 컴퓨터: " + computer_win.ToString()+ "\r\n";
            
            if (use_win == 3 || computer_win == 3)
            {
                if(use_win == 3 && computer != 3)
                {
                    resultBox.Text += "사용자 승리\r\n";
                }
                else if(use_win != 3 || computer_win == 3)
                {
                    resultBox.Text += "컴퓨터 승리\r\n";
                }
                else
                {
                    resultBox.Text += "무승부\r\n";
                }
                resultBox.Text += "---------------------------\r\n";
                use_win = 0;
                computer_win = 0;
            }
        }
        private void scissors_Click(object sender, EventArgs e)
        {
            int idx = 0;
            int computer = computerRSP();
            Match(idx, computer);
        }
        private void rock_Click(object sender, EventArgs e)
        {
            int idx = 1;
            int computer = computerRSP();
            Match(idx, computer);
        }
        private void papper_Click(object sender, EventArgs e)
        {
            int idx = 2;
            int computer = computerRSP();
            Match(idx, computer);
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

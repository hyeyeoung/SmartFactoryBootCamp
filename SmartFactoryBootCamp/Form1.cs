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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int theCoinThrowAndMatch(string inputCoin)
        {
            Random random = new Random();
            int computerMake = random.Next();
            string resultComputer = (computerMake % 2 == 1).ToString();

            if(inputCoin == "true" || inputCoin == "false")
            {
                if (inputCoin == resultComputer)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return -1;
            }
        }
        private void botton_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "입력하신 값은 " + textBox_input.Text + "입니다\r\n";
            int theCoinMatchResult = theCoinThrowAndMatch(textBox_input.Text);
            
            switch (theCoinMatchResult){
                case 1:
                    textBox_result.Text += "동전 던지기 결과는 \r\n승리입니다.";
                    break;
                case 2:
                    textBox_result.Text += "동전 던지기 결과는 \r\n패배입니다.";
                    break;
                case -1:
                    textBox_result.Text += "승부가 불가합니다. \r\n입력을 다시 해주세요.";
                    break;
                default:
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_input.Text = "true";
        }
        private void radioButton_false_CheckedChanged(object sender, EventArgs e)
        {
            textBox_input.Text = "false";
        }
    }
}

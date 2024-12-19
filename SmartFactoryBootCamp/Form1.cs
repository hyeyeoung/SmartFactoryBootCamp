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
        enum Days
        {
            Monday, 
            Tuesday,
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday,
            Sunday,
            error
        }
        int theChoiceWeekday(string message){
            switch (message)
            {
                case "월요일":
                    return 0;
                case "화요일":
                    return 1;
                case "수요일":
                    return 2;
                case "목요일":
                    return 3;
                case "금요일":
                    return 4;
                case "토요일":
                    return 5;
                case "일요일":
                    return 6;
                default:
                    return -1;
            }
        }
        private void botton_input_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0)
            {
                int input = theChoiceWeekday(textBox_input.Text);
                switch (input)
                {

                    case (int)Days.Monday:
                        textBox_result.Text = "심근경색 위험! 출근보다 침대가 내 건강을 더 생각한다.";
                        break;
                    case (int)Days.Tuesday:
                        textBox_result.Text = "월요일을 이겨냈으니 이제는... 또 다른 월요일이 시작된 느낌.";
                        break;
                    case (int)Days.Wednesday:
                        textBox_result.Text = "주말의 절반이 더 가까워졌다고? 그게 나한테 무슨 의미지?";
                        break;
                    case (int)Days.Thursday:
                        textBox_result.Text = "금요일 전날이라는 이유만으로 사랑받는 유일한 요일.";
                        break;
                    case (int)Days.Friday:
                        textBox_result.Text = "드디어 금요일! 하지만 월급은 아직 멀었지...";
                        break;
                    case (int)Days.Saturday:
                        textBox_result.Text = "오늘은 알람이 필요 없다. 내 몸이 나를 배신하기 전까지 자겠다.";
                        break;
                    case (int)Days.Sunday:
                        textBox_result.Text = "내일이 월요일이라는 사실을 제외하면 완벽한 하루.";
                        break;
                    default:
                        textBox_result.Text = "요일이 아닙니다.";
                        break;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton_false_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}

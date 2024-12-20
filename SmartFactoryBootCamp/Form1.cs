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
        int[] fakeScoreBoard(string theClassNumber)
        {
            int theClassNumberI = int.Parse(theClassNumber);
            int[] scoreBoard = new int[theClassNumberI];
            Random random = new Random();
            for (int i = 0; i < theClassNumberI; i++)
            {
                scoreBoard[i] = random.Next(0, 101); // 난수 입력
            }
            return scoreBoard;
        }
        private void botton_input_Click(object sender, EventArgs e)
        {
            if(textBox_input.Text.Length > 0)
            {
                int[] scoreBoard = fakeScoreBoard(textBox_input.Text);
                int lengthScoreBoard = scoreBoard.Length;
                string message = "";
                for(int i = 0; i<lengthScoreBoard; i++)
                {
                    message += "학생" + (i + 1).ToString() + "의 점수: " + scoreBoard[i].ToString() + "점\r\n";
                }
                textBox_result.Text = message;
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

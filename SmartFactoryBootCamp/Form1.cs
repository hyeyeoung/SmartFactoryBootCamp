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
using static System.Net.Mime.MediaTypeNames;

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
        int[,] fakeScoreBoard(int theClassNumberI)
        {
            int[,] scoreBoard = new int[3, theClassNumberI];
            Random random = new Random();
            int i = 0;
            while(i < 3)
            {
                int j = 0;
                while (true)
                {
                    if (j >= theClassNumberI)
                    {
                        break;
                    }
                    scoreBoard[i, j] = random.Next(0, 101);
                    j++;
                }
                i++;
            }
            return scoreBoard;
        }
        private void botton_input_Click(object sender, EventArgs e)
        {
            int lengthScoreBoard = 0;
            if (textBox_input.Text.Length > 0 && int.TryParse(textBox_input.Text, out lengthScoreBoard))
            {
                // = int.Parse(textBox_input.Text);
                int[,] scoreBoard = fakeScoreBoard(lengthScoreBoard);
                dataGridView1.Columns.Add("Korean", "국어");
                dataGridView1.Columns.Add("English", "영어");
                dataGridView1.Columns.Add("Math", "수학");
                int i = 0;
                while(i < lengthScoreBoard)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["Korean", i].Value = scoreBoard[0, i];
                    dataGridView1["English", i].Value = scoreBoard[1, i];
                    dataGridView1["Math", i].Value = scoreBoard[2, i];
                    i++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); // 파일 저장 객체
            sfd.Filter = "csv (*.csv)|*.csv"; // 파일 확장자 필터
            sfd.InitialDirectory = "C:\\Users\\thfl9\\OneDrive\\바탕 화면\\스팩\\강의 자료"; // 저장 경로
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // 헤더 작성
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                            sw.Write(","); // 열 구분자
                    }
                    sw.WriteLine(); // 줄바꿈

                    // 데이터 작성
                    foreach (DataGridViewRow row in dataGridView1.Rows) // 데이터 입력
                    {
                        if (!row.IsNewRow) // 새 행이 아니면 저장
                        {
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < dataGridView1.Columns.Count - 1)
                                    sw.Write(","); // 열 구분자
                            }
                            sw.WriteLine(); // 줄바꿈
                        }
                    }
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton_false_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using System.Threading;
using Character;

namespace SmartFactoryBootCamp
{
    public partial class Form5 : Form
    {
        static Random random = new Random(); // 랜덤 객체 선언
        static double[] arr = new double[6];
        static int num = 0;
        static double totalTime = 0;
        public Form5()
        {
            InitializeComponent();
        }
        void Update_Score(object i) // 차량을 움직임
        {
            double start = 0;
            while(start <= 10)
            {
                Thread.Sleep(300);
                double x = random.NextDouble();
                x = Math.Round(x, 3);
                if (textBox1.InvokeRequired)
                {
                    // Invoke를 발생시켜서 간접적으로 컨트롤을 업데이트
                    textBox1.Invoke(new MethodInvoker(() =>
                    {
                        textBox1.Text += $"{(int)i}번째 선수 {x}만큼 움직임\r\n";
                    }));
                }
                else
                {
                    textBox1.Text += $"{(int)i}번째 선수 {x}만큼 움직임\r\n";
                }
                start += x;
                totalTime += x;
                
            }
            if (textBox1.InvokeRequired)
            {
                // Invoke를 발생시켜서 간접적으로 컨트롤을 업데이트
                textBox1.Invoke(new MethodInvoker(() =>
                {
                    textBox1.Text += $"{(int)i}번째 선수 {totalTime}만에 들어옴!\r\n";
                }));
            }
            else
            {
                textBox1.Text += $"{(int)i}번째 선수 {totalTime}만에 들어옴!\r\n";
            }
            arr[(int)i] = totalTime;

            num++;
            if (num == 5)
            {
                //MessageBox.Show("Done!");
                string r = "";
                for (int k = 1; k <= 5; k++)
                    r += $"{(int)k} 번째 : {arr[(int)k]}\r\n";
                MessageBox.Show(r);
            }
        }
        void Check()
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 변수를 쓰레드에 전달
            Thread player1 = new Thread(() => Update_Score(1));
            Thread player2 = new Thread(() => Update_Score(2));
            Thread player3 = new Thread(() => Update_Score(3));
            Thread player4 = new Thread(() => Update_Score(4));
            Thread player5 = new Thread(() => Update_Score(5));

            player1.Start();
            player2.Start();
            player3.Start();
            player4.Start();
            player5.Start();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

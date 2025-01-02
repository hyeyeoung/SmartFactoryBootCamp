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
using Character;


namespace SmartFactoryBootCamp
{
    public partial class Form3 : Form
    {
        void readFileAndSaveArr(out int[] arr, string route)
        {
            arr = new int[5];
            string []readResult;
            string content = "";

            try
            {
                content = File.ReadAllText(route);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("경로를 다시 입력해주세요");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("파일을 못 찾았습니다.");
            }
            finally{
                readResult = content.Split('\n'); // 파일 성공적으로 열면 파싱
            }

            for (int i = 0; i <= 5; i++)
            {

                try
                {
                    arr[i] = int.Parse(readResult[i]);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("i 범위가 너무 넓음 " + i.ToString() + " i는 무시!");
                }
                catch (Exception ex)
                {
                    arr[i] = -1;
                }
               
            }
        }
        public Form3()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileroute = textBox2.Text;
            int [] arr;
            readFileAndSaveArr(out arr, fileroute);

            textBox2.Text = "";
            foreach(int i in arr)
            {
                if(i == -1)
                {
                    textBox1.Text += "정수 변환 실패\r\n";
                }
                else
                {
                    textBox1.Text += (i.ToString() + "\r\n");
                }
            }
        }
    }
}

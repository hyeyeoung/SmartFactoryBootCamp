using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Character;


namespace SmartFactoryBootCamp
{
    public partial class Form3 : Form
    {
        public void fillNum(ref int [] arr)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = i + 1;
            }
        }

        public void fillNum(out int[] arr, int n)
        {
            arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
        }
        public Form3()
        {
            InitializeComponent();
            //Character.Character new1 = new Character.NPC("NPC","마을 주민", "주민", 30, 15);
            //Character.Character new2 = new Character.Monster("Monster", "괴물", "slime", 500, 20);
            //Character.Character new3 = new Character.Player("Player", "용사", "fighter", 100, 80);

            //new1.Talk();
            //new2.Talk();
            //new3.Talk();

            //fight f1 = new fight(((Character.NPC)new1).NPCrespone(), ((Character.Monster)new2).Monsterrespone());
            //fight f2 = new fight(((Character.Monster)new2).Monsterrespone(), ((Character.Player)new3).playrespone());

            //MessageBox.Show("첫 번째 라운드: " + f1.sendResult().ToString());
            //MessageBox.Show("두 번째 라운드: " + f2.sendResult().ToString());

            //new1.levelUP();
            //new2.levelUP(20);
            //new3.levelUP(20, 30);

            // ref 사용
            int[] arr1 = new int[10];
            fillNum(ref arr1);
            textBox1.Text = "";
            foreach (int i in arr1)
            {
                textBox1.Text += i;
            }
            textBox1.Text += "\r\n";
            
            // out 사용
            int[] arr2;
            fillNum(out arr2, 10);
            foreach (int i in arr2)
            {
                textBox1.Text += i;
            }
            textBox1.Text += "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 1번 ref
            
        }
    }
}

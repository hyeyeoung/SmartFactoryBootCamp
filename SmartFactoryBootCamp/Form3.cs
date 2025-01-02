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
        public Form3()
        {
            InitializeComponent();

            Character.Character new1 = new Character.NPC("NPC","마을 주민", "주민", 30, 15);
            Character.Character new2 = new Character.Monster("Monster", "괴물", "slime", 500, 20);
            Character.Character new3 = new Character.Player("Player", "용사", "fighter", 100, 80);

            new1.Talk();
            new2.Talk();
            new3.Talk();

            fight f1 = new fight(((Character.NPC)new1).NPCrespone(), ((Character.Monster)new2).Monsterrespone());
            fight f2 = new fight(((Character.Monster)new2).Monsterrespone(), ((Character.Player)new3).playrespone());

            MessageBox.Show("첫 번째 라운드: " + f1.sendResult().ToString());
            MessageBox.Show("두 번째 라운드: " + f2.sendResult().ToString());

            new1.levelUP();
            new2.levelUP(20);
            new3.levelUP(20, 30);
        }
    }
}

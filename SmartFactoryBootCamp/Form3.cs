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

            NPC npc1 = new NPC("마을 주민", "주민", 30, 15);
            Monster monster = new Monster("괴물", "Slime", 500, 20);
            Player pl1 = new Player("용사", "fighter", 100, 80);

            fight f1 = new fight(pl1.playrespone(), monster.Monsterrespone());
            fight f2 = new fight(monster.Monsterrespone(), npc1.NPCrespone());
            //fight f3 = new fight(monster.Monsterrespone(), .NPCrespone());

            MessageBox.Show(f1.sendResult().ToString());
            MessageBox.Show(f2.sendResult().ToString());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Character
{
    public struct CharacterData
    {
        public string type;
        public string name; // 이름
        public string job; // 직업
        public int HP; // 체력
        public int Attack; // 공격력
    }
    public class Character // 부모 클래스
    {
        CharacterData data = new CharacterData();
        public Character(string type, string name, string job, int HP, int Attack)
        {
            if(this.makCharacter(type, job))
            {
                this.data.type = type;
                this.data.name = name;
                this.data.job = job;
                this.data.HP = HP;
                this.data.Attack = Attack;
            }
        }
        public virtual void Talk()
        {
        }
        bool makCharacter(string type, string job)
        {
            switch (type)
            {
                case "Monster":
                    if (job == "orc" || job == "slime")
                        return true;
                    else 
                        return false;
                case "Player":
                    if (job == "fighter" || job == "wizard")
                        return true;
                    else
                        return false;
                case "NPC":
                    return true;
                default:
                    return false;
            }
        }

        // 레벨에 따라서 무기 지급

        public void levelUP()
        {
            MessageBox.Show(this.data.name + " 뭐든 입력해줘");
        }
        public void levelUP(int level)
        {
            MessageBox.Show(this.data.name + " 레벨 업!");
        }
        public void levelUP(int level, int hp)
        { 
            MessageBox.Show(this.data.name + " 레벨 업, 체력 업");
        }
    }

    public class NPC : Character
    {
        CharacterData npcdata = new CharacterData();

        public NPC(string type, string name, string job, int HP, int Attack) : base(type, name, job, HP, Attack)
        {

            this.npcdata.type = "NPC";
            this.npcdata.name = name;
            this.npcdata.job = job;
            this.npcdata.HP = HP;
            this.npcdata.Attack = Attack;

        }

        public CharacterData NPCrespone()
        {
            return this.npcdata;
        }
        public override void Talk()
        {
            MessageBox.Show("나는 주민이야");
        }


    }

    public class Player : Character
    {
        CharacterData Playerdata = new CharacterData();
        public Player(string type, string name, string job, int HP, int Attack) : base("Player", name, job, HP, Attack)
        {

            this.Playerdata.type = "Player";
            this.Playerdata.name = name;
            this.Playerdata.job = job;
            this.Playerdata.HP = HP;
            this.Playerdata.Attack = Attack;

        }

        public CharacterData playrespone()
        {
            return this.Playerdata;
        }
        public override void Talk()
        {
            MessageBox.Show("나는 용사야");
        }

    }

    public class Monster : Character
    {
        CharacterData Monsterdata = new CharacterData();

        public Monster(string type, string name, string job, int HP, int Attack) : base("Monster", name, job, HP, Attack)
        {

            this.Monsterdata.type = "Monster";
            this.Monsterdata.name = name;
            this.Monsterdata.job = job;
            this.Monsterdata.HP = HP;
            this.Monsterdata.Attack = Attack;
        }    
        

        public CharacterData Monsterrespone()
        {
            return this.Monsterdata;
        }
        public override void Talk()
        {
            MessageBox.Show("나는 괴물이다");
        }

    }
}

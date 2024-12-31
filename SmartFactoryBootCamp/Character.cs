using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Character
{
    public struct CharacterData
    {
        public String type;
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
    }
}

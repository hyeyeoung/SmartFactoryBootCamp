using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Character;

namespace SmartFactoryBootCamp
{
    public class fight
    {
        Character.CharacterData p1 = new Character.CharacterData();
        Character.CharacterData p2 = new Character.CharacterData();
        string winner;
        public fight(CharacterData tmpp1, CharacterData tmpp2)
        {
            this.p1 = tmpp1;
            this.p2 = tmpp2;
        }
        public bool makeFight()
        {
            if (this.p1.type == "Monster" && this.p2.type == "Monster")
                return false;
            if (this.p1.type != "Monster" && this.p2.type != "Monster")
                return false;
            return true;
        }

        public string sendResult()
        {
            // 공격력이 상대방 체력보다 낮음
            if (this.p1.Attack == this.p2.Attack)
            {
                if(this.p1.HP ==  this.p2.HP)
                {
                    this.winner =  "무승부!";
                }
                else
                {
                    this.winner = this.p1.HP > this.p2.HP ? this.p1.name : this.p2.name;
                }
            }
            else
            {
                this.winner = this.p1.Attack > this.p2.Attack ? this.p1.name : this.p2.name;
            }
            return this.winner;
        }
    }
}

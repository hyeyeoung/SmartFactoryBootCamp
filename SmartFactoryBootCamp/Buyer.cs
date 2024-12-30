using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactoryBootCamp
{
    struct userData
    {
        public bool CashOrCard;
        public int haveDrink;
        public int havingMoney;
    }
    internal class Buyer
    {
        userData us;
        ArrayList requestMgData;
        public Buyer(bool CashOrCard) 
        {
            this.us.CashOrCard = CashOrCard;
            this.us.haveDrink = 0;
            this.us.havingMoney = 1000; // 기본 천원
        }
       
        public void buyDrink(int vendingID) // 자판기의 정보를 파악
        {
            vendingMachine tmp = (vendingMachine)Manager.vendinglist[vendingID];
            //MessageBox.Show(tmp.vd.vendingID.ToString());

            if (tmp.price < this.us.havingMoney)
            {
                int succecssBuy = tmp.SaleDrink(this.us.CashOrCard, this.us.havingMoney);
                if (succecssBuy > 0)
                {
                    this.us.haveDrink++;
                    this.us.havingMoney -= tmp.price;
                }
                else
                {
                    MessageBox.Show("다시 시도해주세요");
                }
            }
        }
        public void checkDrinkName(int vendingID)
        {
            vendingMachine tmp = (vendingMachine)Manager.vendinglist[vendingID];
            MessageBox.Show(tmp.DrinkName);
        }
    }
}

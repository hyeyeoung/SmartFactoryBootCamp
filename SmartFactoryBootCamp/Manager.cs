using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactoryBootCamp
{
    struct manageInfo
    {
        public int ID;
        public int PW;
    }
    internal class Manager
    {
        manageInfo mginfo;
        public static ArrayList vendinglist = new ArrayList();
        int theCurrentStock;
        int theTotal;
        int Hundred;
        public Manager(int theCurrentStock, int Hundred) 
        {
            // 관리자 생성
            Random r = new Random();
            this.mginfo.ID = r.Next();
            this.mginfo.PW = r.Next();

            this.theCurrentStock = theCurrentStock;
            this.Hundred = Hundred;

            this.theTotal = 0;
        }
        public void addMangerMoney(int hundred)
        {
            if(hundred % 10 == 0 && hundred >= 1000)
            {
                this.Hundred += hundred;
            }
            else
            {
                MessageBox.Show("1000원 이상, 10원 단위로 돈을 추가할 수 있습니다.");
            }
        }
        public void checkID(int vendingnum)
        {
            vendingMachine tmp = (vendingMachine)vendinglist[vendingnum];
            MessageBox.Show(tmp.vd.vendingID.ToString());
        }
        public void makeVending(string name, int price)
        {
            vendingMachine newVd = new vendingMachine(name, price, this.mginfo.ID, this.mginfo.PW);
            vendinglist.Add(newVd); // 새 자판기 정보 저장
        }

        // 재입고
        public void reStockDrink(int vendingnum, int reStockNum)
        {
            if(0 <= vendingnum && vendingnum < vendinglist.Count)
            {
                if(reStockNum < this.theCurrentStock)
                {
                    vendingMachine tmp = (vendingMachine)vendinglist[vendingnum];
                    tmp.reStockDrink(this.mginfo.ID, this.mginfo.PW, this.theCurrentStock);
                    this.theCurrentStock -= reStockNum;
                }
                else
                {
                    MessageBox.Show("가진 음료수가 적습니다.");
                }
            }
            else
            {
                MessageBox.Show("제대로 된 머신 번호를 입력해주세요");
            }
        }
        public void checkHistory(int vendingnum)
        {
            vendingMachine tmp = (vendingMachine)vendinglist[vendingnum];
            tmp.checkHistory(this.mginfo.ID, this.mginfo.PW);
        }
        public void reStockCash(int vendingnum, int reStockCash)
        {
            if (0 <= vendingnum && vendingnum < vendinglist.Count)
            {
                if (reStockCash < this.Hundred)
                {
                    vendingMachine tmp = (vendingMachine)vendinglist[vendingnum];
                    tmp.reStockDrink(this.mginfo.ID, this.mginfo.PW, this.Hundred);
                    this.Hundred -= reStockCash;
                }
                else
                {
                    MessageBox.Show("가진 돈이 적습니다.");
                }
            }
            else
            {
                MessageBox.Show("제대로 된 머신 번호를 입력해주세요");
            }
        }

        public void saveMoney(int vendingnum) 
        { 
            vendingMachine tmp = (vendingMachine)vendinglist[vendingnum];
            int Cash = tmp.returnMoney(this.mginfo.ID, this.mginfo.PW);
            if (Cash > 0) { 
                this.Hundred += Cash;
            }
            else
            {
                MessageBox.Show("다시 시도해주세요");
            }
        }
    }
}

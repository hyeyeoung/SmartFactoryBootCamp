using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFactoryBootCamp
{
    public struct vendingData
    {
        public int vendingID; // 자판기 아이디
        public int vendingPW; // 관리자 접근 비밀번호
    }
    struct SaleData
    {
        public int cost;
        public bool cashOrCard;
    }
    public partial class vendingMachine
    {
        public vendingData vd; // 자판기 기본 정보
        public string DrinkName { get; } // 프로퍼티 사용
        public int price { get; } // 가격 정보 확인
        int theCurrentStock; // 현재 재고
        int theCurrentCash; // 현재 잔고

        int Hundred;
        ArrayList historySale;
        public vendingMachine(string Name, int price, int ID, int PW) // 음료 이름
        {
            this.theCurrentStock = 0;
            this.Hundred = 0;

            this.vd.vendingID = ID; // 자판기 생성시 랜덤 아이디 지정
            this.vd.vendingPW = PW; // 자판기 비밀번호 랜덤 생성
            
            this.DrinkName = Name; //  음료 명
            this.price = price;

            this.historySale = new ArrayList(); // 판매 이력 저장 공간 확보
            this.theCurrentStock = 0;
            this.theCurrentCash = 0;
        }

        // 현금, 카드 구분 후 구매 이력에 저장
        void distinguish(bool cashOrCard, int cost)
        {
            //cashOrCard;
            SaleData newData;
            newData.cost = cost;
            newData.cashOrCard = cashOrCard;

            this.historySale.Add(newData);
        }
        // 음료 판매하기
        public int SaleDrink(bool cashOrCard, int cost)
        {
            // 재고 존재 확인
            if(this.theCurrentStock > 0)
            {
                // 100원 짜리가 잔돈 이상인지 확인 (입력은 백원 단위만 가능)
                if (!cashOrCard && (this.price - cost) / 100 > Hundred)
                {
                    // 결재
                    this.distinguish(cashOrCard, cost);
                    this.theCurrentStock--;
                    this.Hundred -= (this.price - cost) / 100;
                    this.theCurrentCash += cost; 
                    return 1;
                }
                else if (cashOrCard)
                {
                    this.distinguish(cashOrCard, cost);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return -1; // 재고 부족 코드
        }
        public int returnMoney(int ID, int PW)
        {
            if (this.vd.vendingID == ID && this.vd.vendingPW == PW)
            {
                return this.theCurrentCash;
            }
            else return -1;
        }
        public int theCurrentStockNum(int ID, int PW)
        {
            return this.theCurrentStock;
        }
        public void reStockCash(int ID, int PW, int inputCash)
        {
            if (this.vd.vendingID == ID && this.vd.vendingPW == PW)
            {
                this.theCurrentCash += inputCash;
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호를 다시 확인해주세요");
            }
        }
        public void reStockDrink(int ID, int PW, int stock) // 재입고
        {
            if (this.vd.vendingID == ID && this.vd.vendingPW == PW)
            {
                this.theCurrentStock += stock;
            }
            return;
        }
        public void checkHistory(int ID, int PW) // 상위 다섯개의 히스토리 확인 가능
        {
            if (this.vd.vendingID == ID && this.vd.vendingPW == PW)
            {
                int lenghtHistory = this.historySale.Count;
                string history = "";
                for (int i = lenghtHistory - 6; i < lenghtHistory; i++)
                {
                    //this.historySale[i].cost
                    SaleData pSaleData = (SaleData)this.historySale[i];
                    if (pSaleData.cashOrCard)
                    {
                        history += pSaleData.cost.ToString() + "원을 카드로 결제\r\n";
                    }
                    else
                    {
                        history += pSaleData.cost.ToString() + "원을 현금으로 결제\r\n";
                    }
                }
                MessageBox.Show(history);
            }
        }
    }
}
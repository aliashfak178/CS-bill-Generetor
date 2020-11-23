using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bill_Generater_System
{
    class GetSetValues
    {
       // private int maxSize = 5;
        public int Top = 0;
        private string []ItemName=new string[6];
        private int []Quantity=new int[6];
        private int []ItemPrice=new int[6];
        private int []TotalPrice=new int[6];
        public void GetAllItem(string Iname, int Quan, int IPrice, int Tprice)
        {
            if(Top!=5)
            {
                Top++;
                ItemName[Top] = Iname;
                Quantity[Top] = Quan;
                ItemPrice[Top] = IPrice;
                TotalPrice[Top] = Tprice;
                
            }
        }
        public void After_Uing()
        {
            Top--;
        }
        public string SetItemName()
        {
            return ItemName[Top];
       }
        public int SetQuantity()
        {
            return Quantity[Top];
        }
        public int SetIprice()
        {
            return ItemPrice[Top];
        }
        public int SetTotal()
        {
            return TotalPrice[Top];
        }
  }
}

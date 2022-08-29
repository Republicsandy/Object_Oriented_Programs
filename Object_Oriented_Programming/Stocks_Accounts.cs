using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Stocks_Accounts:IStock_Accounts
    {

        int numberOfShare = 1000;
        List<string> firstArray = new List<string>();
        List<string> secondArray = new List<string>();
        public void StockAccount()
        {
            Console.WriteLine("Compony Stocks");
            firstArray.Add("Compony Name : Infosys");
            firstArray.Add("Total Stocks : " + numberOfShare);
            for (int i = 0; i < firstArray.Count; i++)
            {
                Console.WriteLine(firstArray[i]);
            }
            secondArray.Add("Compony Name : Tata");
            secondArray.Add("Total Stocks : " + numberOfShare);
            for (int j = 0; j < secondArray.Count; j++)
            {
                Console.WriteLine(secondArray[j]);
            }
        }
        public void Transaction()
        {
            int getValueByUSer;
            do
            {
                Console.WriteLine("\n**Select Your Choice**");
                Console.WriteLine("\n1:Enter to Buy shares");
                Console.WriteLine("2:Enter to Sell shares");
                Console.WriteLine("3:Enter to Show Portfolio");
                Console.WriteLine("4:Enter to showCompony Stock Data");
                Console.WriteLine("0:Exit");
                Console.WriteLine("\nEnter Your Choice");
                getValueByUSer = int.Parse(Console.ReadLine());
                switch (getValueByUSer)
                {
                    case 1:
                        Buy();
                        break;
                    case 2:
                        Sell();
                        break;
                    case 3:
                        Save();
                        break;
                    case 4:
                        StockAccount();
                        break;

                }
            } while (getValueByUSer != 0);
        }
        public void Buy()
        {
            Console.WriteLine("\n");
            Console.WriteLine("--------> You are purchasing shares <-----------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter Customer Name");
            string cname = Console.ReadLine();
            secondArray.Add("Customer Name : " + cname);
            //Console.WriteLine("Share Name");
            //string sname = Console.ReadLine();
            //arr2.Add("Compony Name : " + sname);
            Console.WriteLine("Quantity");
            int quantityOfShare = int.Parse(Console.ReadLine());
            if (numberOfShare - quantityOfShare >= 0)
            {
                numberOfShare = numberOfShare - quantityOfShare;
                secondArray.Add("Quantity : " + quantityOfShare);
                firstArray.Add("Total Stocks : " + numberOfShare);
            }
            else
            {

                Console.WriteLine("All shares of compony already sold");
                Console.WriteLine("No seller Available");
            }

        }

        public void Sell()
        {
            Console.WriteLine("-----------> You are Selling your shares <-------------");
            Console.WriteLine("Quantity to sell");
            int quantityOfShare = int.Parse(Console.ReadLine());
            numberOfShare = numberOfShare + quantityOfShare;
            secondArray.Add("Quantity : " + quantityOfShare);
            firstArray.Add("Total Stocks : " + numberOfShare);
            Console.WriteLine("\n");

        }

        public void Save()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------> Customer Portfolio <----------------");
            Console.WriteLine("\n");
            for (int i = 0; i < secondArray.Count; i++)
            {
                Console.WriteLine(secondArray[i]);
            }
        }
    }
}

using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Object orianted Programming");
            Console.WriteLine("Enter 1 for inventery Management Program");
            Console.WriteLine("Enter 2 for stock account management");
          
            int getValueByUser = Convert.ToInt32(Console.ReadLine());
            switch (getValueByUser)
            {
                case 1:
                    Stocks_Accounts stockaccount = new Stocks_Accounts();
                    stockaccount.StockAccount();
                    stockaccount.Transaction();
                    break;
                    case 2:
                    DeackOfCards deakofcards = new DeackOfCards();
                    deakofcards.ShuffleCards();
                    break;  
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}

using System;

namespace Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Object orianted Programming");
            Console.WriteLine("Enter 1 for inventery Management Program");
            Console.WriteLine("Enter 2 to check daily wage of an employee");
          
            int getValueByUser = Convert.ToInt32(Console.ReadLine());
            switch (getValueByUser)
            {
                case 1:
                    Stocks_Accounts stockaccount = new Stocks_Accounts();
                    stockaccount.StockAccount();
                    stockaccount.Transaction();
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}

using MySuperBankLibray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Celumusa", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
            account.MakeWithdrawal(220, DateTime.Now, "Jacket");
            account.MakeWithdrawal(89, DateTime.Now, "Shirt");
            account.MakeWithdrawal(600, DateTime.Now, "Sneakers");
            account.MakeWithdrawal(50, DateTime.Now, "Laptop Charger");

            Console.WriteLine(account.GetAccountHistory());
            Console.ReadLine();
        }
    }
}

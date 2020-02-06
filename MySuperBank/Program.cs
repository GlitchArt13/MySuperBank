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
            BankAccount account = new BankAccount("Celumusa", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine($"Your bank bakance is {account.Balance}");
            Console.ReadLine();
        }
    }
}

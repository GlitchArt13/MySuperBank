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
            BankAccount account = new BankAccount("Celumusa", 100);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");


            Console.ReadLine();
        }
    }
}

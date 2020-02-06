using MySuperBankLibrary;
using System;
using Xunit;

namespace XUnitTestBanking
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Assert.True(true);

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Celumusa", 1000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(1100, DateTime.Now, "Attempt to overdraw")
            );
        }
    }
}

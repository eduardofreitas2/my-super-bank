using System;
using Xunit;
using BankyStuffLibrary;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Eduardo", 10000);

            // Test for a negative balance:
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(8000, DateTime.Now, "Attempt to overdraw")
            );
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            // Test that the initial balances must be positive.
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", 55)
            );
        }
    }
}

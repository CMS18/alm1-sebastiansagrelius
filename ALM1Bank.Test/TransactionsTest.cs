using ALM1Bank.Data;
using System;
using Xunit;

namespace ALM1Bank.Test
{
    public class TransactionsTest
    {

        [Fact]
        public void TestWithdrawUpdatedBalance()
        {
            //Arrange
            var repo = new BankRepository();

            var accountFrom = repo.GetAccount(1);

            var amount = 300;

            //Act

            accountFrom.Balance -= amount;

            //Assert
            Assert.Equal(700M, accountFrom.Balance);
        }

        [Fact]
        public void TestDepositUpdatedBalance()
        {
            //Arrange
            var repo = new BankRepository();

            var accountTo = repo.GetAccount(3);

            var amount = 250;

            //Act
            accountTo.Balance += amount;

            //Assert
            Assert.Equal(20250M, accountTo.Balance);
            
        }

        [Fact]
        public void TestWithdrawNotMoreThanBalance()
        {
            //Arrange
            var repo = new BankRepository();

            //Act
            var result = repo.Withdraw(30000000, 2);

            //Assert

            Assert.False(result);

            
        }
    }
}

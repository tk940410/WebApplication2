using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace TestProject1
{
    public class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
        }

        public BankAccount()
        {
            
        }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void SetAccount(double balance)
        {
            this.balance = balance;
        }
        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }
    }

    public class Tests
    {

        [TestFixture]
        public class BankAccountTest
        {
            private BankAccount _BankAccount;

            [SetUp]
            public void SetUp()
            {
                _BankAccount = new BankAccount();
            }

            [Test]
 
            public void Adding_AddFunds_Sum()
            {
                // Arrange
                _BankAccount.SetAccount(1000);
                // Act
                _BankAccount.Add(500);
                // Assert
                Assert.AreEqual(1500, _BankAccount.Balance);
            }
        }

        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}
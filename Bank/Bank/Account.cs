using System.Globalization;

namespace Bank
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }

        public Account(int AccountNumber, string Holder)
        {
            this.AccountNumber = AccountNumber;
            this.Holder = Holder;
        }

        public Account(int AccountNumber, string Holder,double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Holder = Holder;
            Deposit(Balance);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public override string ToString()
        {
            return "Conta "
                +AccountNumber
                +", Titular: "
                +Holder
                +", Saldo: $ "
                +Balance.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

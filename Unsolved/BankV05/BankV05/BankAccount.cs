namespace BankV05
{
    /// <summary>
    /// This class represents a very simple bank account.
    /// Only the amount of money on the account is represented.
    /// </summary>
    public class BankAccount
    {
        private double _balance;
        private string _name;

        public BankAccount(string name)
        {
            _name = name;
            _balance = 0.0;
        }

        public string Name
        {
            get { return _name; }
        }
        public double Balance
        {
            get { return _balance;}
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
    }
}
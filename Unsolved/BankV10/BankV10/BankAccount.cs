namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if(amount >= 0)
            {
                _balance = _balance + amount;
            } else
            {
                System.Console.WriteLine("Cant use negative numbers");
            }
        }

        public void Withdraw(double amount)
        {
            try
            {
                if (amount >= 0)
                {
                    if (_balance >= amount)
                    {
                        _balance = _balance - amount;
                    }
                    else
                    {
                        System.Console.WriteLine("Not enough money");
                    }
                }
                else
                {
                    System.Console.WriteLine("Cant use negative numbers");
                }
            }
            catch
            {
                System.Console.WriteLine("ERROR");
            }
        } 
        #endregion
    }
}
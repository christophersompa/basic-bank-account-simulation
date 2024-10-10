namespace basic_bank_accont_simulation.Class
{
    internal class BankAccount
    {
        private decimal balance;

        private string Name { get; set; }

        public BankAccount(decimal initalBalance)
        {
            balance = initalBalance; 
        }

        public decimal Deposit(decimal amount)
        {
            return balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            return balance -= amount;  
        }

        public decimal GetBalance(decimal startingBalance) 
        { 
            return balance; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        private const decimal WithdrawalFee = 5.00m;

        public string Number { get; private set; }
        
        public decimal Balance { get; private set; }

        public string HolderName { get; set; }
        
        public Account()
        {

        }

        public Account(string number, string holderName)
        {
            Number = number;
            HolderName = holderName;
        }
        
        public Account(string number, string holderName, decimal initialDeposit) : this(number, holderName)
        {
            Deposit(initialDeposit);
        }


        public void Deposit (decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw (decimal amount)
        {
            Balance -= amount + WithdrawalFee;
        }

        public override string ToString()
        {
            return $"Account: {Number}, Holder: {HolderName}, Balance: ${Balance:F2}";
        }
    }
}

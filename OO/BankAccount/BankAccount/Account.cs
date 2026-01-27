using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        private string _number;

        private const decimal WithdrawalFee = 5.00m;
        
        public decimal Balance { get; private set; }

        public string HolderName { get; set; }

        public Account(string number, string holderName)
        {
            _number = number;
            HolderName = holderName;
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
            return $"Account: {_number}, Holder: {HolderName}, Balance: ${Balance:F2}";
        }
    }
}

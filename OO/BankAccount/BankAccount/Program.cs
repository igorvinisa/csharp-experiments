using System.Globalization;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.Write("Enter the account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter the account holder's name: ");
            string holderName = Console.ReadLine();

            Console.Write("Is there an initial deposit (y/n)? ");
            char initialDepositResponse = char.Parse(Console.ReadLine());

            account = new Account(accountNumber, holderName);

            if (initialDepositResponse == 'y')
            {
                Console.Write("Enter the initial deposit amount: ");
                decimal initialDeposit = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Deposit(initialDeposit);
                Console.WriteLine("Account created:");
                Console.WriteLine(account);

                Console.Write("Enter a amount for withdraw: ");
                decimal withdrawInput = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdrawInput);
                Console.WriteLine(account);
            }
            else
            {
                Console.WriteLine("Account created:");
                Console.WriteLine(account);
            }
        }
    }
}

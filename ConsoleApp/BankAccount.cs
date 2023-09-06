using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class BankAccount
    {
        public BankAccount(string accountHolder, string accountNumber, decimal balance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public string AccountHolder { get; set; }
        [MaxLength(16)]
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, string accountNumber, decimal balance, decimal interestRate)
      : base(accountHolder, accountNumber, balance)
        {
            InterestRate = interestRate;
        }
        public decimal InterestRate { get; set; }
        public decimal CalculateInterest()
        {
            decimal interestAmount = Balance * InterestRate / 100;
            return interestAmount;
        }
    }
}

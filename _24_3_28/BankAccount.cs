using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_28
{
    internal class BankAccount
    {
        public BankAccount(int balance)
        {
            this.balance = balance;
        }

        private string email;
        public double balance { get; set; }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }

    internal class BankAccountRunner
    {
        BankAccount bankAccount; 
        public BankAccountRunner(int balance)
        {
            bankAccount = new BankAccount(balance);
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {bankAccount.balance} Rs.");
        }

        public void DepositBalance() 
        {
            Console.WriteLine("Enter amount to deposit: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (amount<=0)
            {
                Console.WriteLine("Please enter valid amount to deposit");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            
            double balance = bankAccount.balance;
            balance += amount;
            bankAccount.balance = balance;
            Console.WriteLine($"{amount} Rs. credited successfuly!!!");
            CheckBalance();

        }

        public void WithDrawBalance()
        {
            Console.WriteLine("Enter amount to withdraw: ");
            int amount = int.Parse(Console.ReadLine());
            while(amount<=0)
            {
                Console.WriteLine("Please enter valid amount to withdraw");
                amount = int.Parse(Console.ReadLine());
            }
            double balance = bankAccount.balance;
            if (amount > balance)
            {
                Console.WriteLine("Transaction failed due to Insufficient balance!!!");
                return;
            }

            balance -= amount;
            bankAccount.balance = balance;
            Console.WriteLine($"{amount} Rs. withdrawn successfuly!!!");
            CheckBalance();
        }

    }
       
}





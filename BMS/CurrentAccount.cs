using System;
using System.Collections.Generic;
using System.Text;

namespace BMS
{
    class CurrentAccount : Account
    {
        public CurrentAccount() { }
        public CurrentAccount(string acc, string name, double balance) : base(acc, name, balance)
        {

        }
        public override void Deposit(double amount)
        {            
            if (amount > 0)
            {

                Console.WriteLine("\nYour Current previous Balance :" + this.balance);
                this.balance = this.balance + amount;
                Console.WriteLine("Your Current Account balance has been deposited : " + amount);
                Console.WriteLine("Now Your Total Current Account Balance is : " + this.balance);

            }
            else
            {
                Console.WriteLine("Please Select a Valid Amount!!!");

            }
        }
        public override void Withdraw(double amount)
        {
            if (amount > 0 && this.balance > amount)
            {
                Console.WriteLine("\nYour previous Balance :" + this.balance);
                Console.WriteLine("Your Withdraw Balance is : " + amount);
                this.balance -= amount;
                Console.WriteLine("your current balance:  " + this.balance);
            }
            else
            {
                Console.WriteLine("Current Account is invalid!!");

            }
        }
        public override void show()
        {

            base.show();
            Console.WriteLine("\nCurrent Account Successfully Completed.");
        }
    }
}

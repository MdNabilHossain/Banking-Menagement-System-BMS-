using System;
using System.Collections.Generic;
using System.Text;

namespace BMS
{
    class SavingsAccount:Account
    {
       
        public SavingsAccount() { }
        public SavingsAccount(string acc,string name,double balance):base(acc, name, balance)
        {
            
        }
        public override void Deposit(double amount)
        {
            

            if (amount >= 2000 && amount <= 10000)
            {
                Console.WriteLine("\nYour previous Balance :" + this.balance);
                this.balance = this.balance + amount;
                Console.WriteLine("Your account balance has been Fixed deposited : " + amount);
                Console.WriteLine("Now Your Total Saving Account Balance is : " + this.balance);

            }
            else
            {
                Console.WriteLine("Please Select a Valid Amount of Your Fixed Deposited by 2000 to 10000..........");

            }
        }
        public override void Withdraw(double amount)
        {
           

            if (amount > 0 && this.balance > amount)
            {
                
                Console.WriteLine("\nYour previous Balance :" + this.balance);
                this.balance -= amount;
                Console.WriteLine("Your Withdraw Balance is : " + amount);
                
                Console.WriteLine("your Saving Account balance:  " + this.balance);
            }
            else
            {
                Console.WriteLine("Saving Amount is invalid!!");

            }
        }
        public override void show()
        {

            base.show();
            Console.WriteLine("\nSaving Account Successfully Completed.\nThank You.\n");
        }
    }
}

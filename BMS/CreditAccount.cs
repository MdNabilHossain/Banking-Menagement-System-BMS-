using System;
using System.Collections.Generic;
using System.Text;

namespace BMS
{
    class CreditAccount : Account
    {
        

       
        public CreditAccount() { }
       public CreditAccount(string acc,string name, double balance ):base(acc,name, balance)
        {
           
           
        }
        public override void Deposit(double amount) 
        {
            
            if (amount > 0)
            {
                Console.WriteLine("\nYour previous  Balance :" + this.balance);
                this.balance = this.balance + amount;
                Console.WriteLine("Your Credit account balance has been deposited : " + amount);
                Console.WriteLine("Now Your Total Credit Account Balance is : " + this.balance);
               
            }
            else
            {
                Console.WriteLine("Please Select a Valid Amount of Deposit......");
             
            }
        }
        public override void Withdraw(double amount) 
        {

           
            
            if (amount > 0 && this.balance >= amount)
            {

                Console.WriteLine("\nYour previous Credit Balance :" + this.balance);
                Console.WriteLine("Your Withdraw Balance is : " + amount);
                this.balance-= amount;
                Console.WriteLine("your Credit Account balance:  "+this.balance);
            }
            else
            {
                Console.WriteLine("Amount is invalid !");

            }
        }
        public override void show()
        {
            
            base.show();
            Console.WriteLine("\nCredit Account Successfully Completed.");
        }

    }
}

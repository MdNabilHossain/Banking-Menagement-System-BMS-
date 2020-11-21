using System;
using System.Collections.Generic;
using System.Text;

namespace BMS
{
     abstract class Account
    {
        protected string accNumber;
        protected string name;//name
        protected double balance;//balance
        

        public string AccNumber
        {
            get { return accNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Account Number!!!");
                }
                this.accNumber = value; 
            }
        }
        public string Name
        {
            
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Name");
                    return;
                }
                this.name = value; }
            }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        

        public Account() { }
        public Account(string acc,string name,double balance)
        {
            
      
            this.accNumber = acc;

            this.name = name;
            this.balance = balance;
           
        }


        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        

        public virtual void show()
        {
            Console.WriteLine("\nAccount Number : " + this.accNumber);
            Console.WriteLine("Account Name   : " + this.name);
            Console.WriteLine("Account Balance: " + this.balance);
            
        }


    }
}

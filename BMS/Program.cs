using System;

namespace BMS
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditAccount cc = new CreditAccount();

            CreditAccount c = new CreditAccount("18-1", "MD Nabil Hossain", 10000);           
            CurrentAccount cu = new CurrentAccount("18-2", "Fawaz Hossain", 10000);
            SavingsAccount s = new SavingsAccount("18-3", "Famil Hossain", 10000);

            Boolean repit = true;
            while (repit)
            {
                Console.WriteLine("\n1. Show all Account details ");
                Console.WriteLine("2. Deposit ");
                Console.WriteLine("3. Withdraw ");
                Console.WriteLine("4. Exit  ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        c.show();
                        cu.show();
                        s.show();
                        break;

                    case 2:
                        Console.WriteLine("Enter Account Number: ");
                        string AccountNumber = Console.ReadLine();
                        if (c.AccNumber == AccountNumber)
                        {
                            Console.WriteLine("Enter Depost Blance:");
                            Double balanceC = Convert.ToDouble(Console.ReadLine());
                            c.Deposit(balanceC);
                        }
                        else if(cu.AccNumber == AccountNumber)
                        {
                            Console.WriteLine("Enter Depost Blance:");
                            Double balanceC = Convert.ToDouble(Console.ReadLine());
                            cu.Deposit(balanceC);
                        }
                        else if (s.AccNumber == AccountNumber)
                        {
                            Console.WriteLine("Enter Fixed Depost Blance:");
                            Double balanceC = Convert.ToDouble(Console.ReadLine());
                            s.Deposit(balanceC);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Account .");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter Account Number: ");
                        string AccountNumberW = Console.ReadLine();
                        if (c.AccNumber == AccountNumberW)
                        {
                            Console.WriteLine("Enter Withdraw Blance:");
                            Double balanceC = Convert.ToDouble(Console.ReadLine());
                            c.Withdraw(balanceC);
                        }
                        else if (cu.AccNumber == AccountNumberW)
                        {
                            Console.WriteLine("Enter Withdraw Blance:");
                            Double balanceC = Convert.ToDouble(Console.ReadLine());
                            cu.Withdraw(balanceC);
                        }
                        else if (s.AccNumber == AccountNumberW)
                        {
                            Console.WriteLine("Enter Withdraw Blance:");
                            Double balanceC = Convert.ToDouble(Console.ReadLine());
                            s.Withdraw(balanceC);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Account .");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Exit ");
                        repit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetassign_5
{
    class Program
    {

        class Bank
        {
            int money = 5000;
            String acc_name = "Vyshnavi";
            String acc_num;
            String bank_name = "HDFC";
            public int updatedBalance;
            public void depositMoney()
            {

                Console.WriteLine("Enter the amount you want to deposit:-  ");
                int depositmoney = int.Parse(Console.ReadLine());
                updatedBalance = money + depositmoney;
                if (depositmoney == 0)
                {
                    Console.WriteLine("minimum deposit should be 100 ");
                }
                else
                {
                    Console.WriteLine("updated balance of " + acc_name + " after deposit is " + updatedBalance);
                }

            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Welcome " + acc_name + " your accountbalance: " + updatedBalance);
                    Console.WriteLine("Enter the amount you want to withdraw:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBalance = updatedBalance - withdraw;
                    if (withdraw > updatedBalance)
                    {
                        Console.WriteLine("insuffiecient balance");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + acc_name + " after withdrawal is " + updatedBalance);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter balance in number not in words input missmatch exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("welcome to the " + bank_name + "bank ");
                Console.WriteLine("Enter account number: ");
                acc_num = Console.ReadLine();
                Console.WriteLine("Welcome " + acc_name + " your account balance is : " + money);

            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Balance();
            bank.depositMoney();
            bank.withdrawMoney();
            Console.ReadLine();
        }

    }
}

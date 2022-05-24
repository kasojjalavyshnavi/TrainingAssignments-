
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5
{
    class MyOwnException : ApplicationException
    {
        public MyOwnException(string s) : base(s)
        {
        }
    }
    internal class Program
    {
        public int balance = 10000;
        public void deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposited Succesfully Total amount = " + balance);
        }
        public void withdraw(int deduct)
        {
            if (deduct < balance)
            {
                balance -= deduct;
                Console.WriteLine("Transaction Succefull Withdrawl Amount = " + deduct);
            }
            else
            {
                throw (new MyOwnException("Insufficient Balance Found!!!"));
            }
        }
        public void display()
        {
            Console.WriteLine("Remaining balance = " + (balance));
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Choose Below Options");
            Console.WriteLine("                    ");
            Console.WriteLine("Enter 1 to Deposit the Money");
            Console.WriteLine("Enter 2 to Withdraw the Money");
            Console.WriteLine("Enter 3 to Balance Enquiry");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter Amount to Deposit");
                    program.deposit(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Enter Amount to Withdraw");
                        program.withdraw(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch (ApplicationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    program.display();
                    break;
                default:
                    Console.WriteLine("Invalid Input !!!, Please Enter Valid input between 1 and 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}




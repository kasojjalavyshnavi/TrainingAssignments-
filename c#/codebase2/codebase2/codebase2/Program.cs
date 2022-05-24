using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace codebase2
{
    public delegate void calculator(int a, int b);


    class Program
    {
        public static void addition(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Addition result is {0}",res);
        }
        public static void substraction(int a, int b)
        {
            int res = a - b;
            Console.WriteLine("\nSubstraction result is {0}",res);
        }
        public static void multiplication(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("\nMultiplicatio result is {0}",res);
        }
        public static void division(int a, int b)
        {
            int res = a / b;
            Console.WriteLine($" division result is {0}",res);
        }
        static void Main(string[] args)
        {
            calculator obj = new calculator(Program.addition);
            obj.Invoke(10, 20);
            obj = substraction;
            obj(20, 10);
            obj = multiplication;
            obj(30, 40);
            obj = division;
            obj(50, 10);
            Console.ReadLine();
        }
    }
}

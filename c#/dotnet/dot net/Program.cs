
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("Enter numbers");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine(number1 + "and" + number2 + " are equal");
            }
            else
            {
                Console.WriteLine(number1 + "and" + number2 + "are not equal");
            }
            Console.ReadLine();
        }
    }
 if (num1 >= 0)
            {
                Console.WriteLine(num1 + "is positiver");
            }
            else
            {
                Console.WriteLine(num1 + "are negativre");
            }
            Console.ReadLine();
        }
    }


}

}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the number:");
            num1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}


*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result;
            char operation;
            Console.WriteLine("enter the 2 numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose the operation");

            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = n1 + n2; Console.WriteLine("addition of two numbers is{0}", result);
                    break;
                case '-':
                    result = n1 - n2; Console.WriteLine("subtraction of two numbers is{0}", result);
                    break;
                case '*':
                    result = n1 * n2; Console.WriteLine("multiplication of two numbers is {0}", result);
                    break;
                case '%':
                    result = n1 / n2; Console.WriteLine("division of two numbers is{0}", result);

                    break;
                default:
                    Console.WriteLine("invalid output");
                    break;



            }
            Console.ReadLine();
        }
    }
}



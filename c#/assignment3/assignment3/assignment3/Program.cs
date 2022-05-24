using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int[] ar = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("the element at " + i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.ReadLine();
    }
    }
}

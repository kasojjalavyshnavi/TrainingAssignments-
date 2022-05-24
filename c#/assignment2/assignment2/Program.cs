using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1, avarage maximum and minimum.
            int[] myNum = { 1, 2, 3, 4, 5 };
            Console.WriteLine(" The avarage element :" + " " + myNum.Average());
            Console.WriteLine(" The largest element :" + " " + myNum.Max());
            Console.WriteLine(" The smallest element :" + " " + myNum.Min());


            // 2, 10 marks avarage, maximum and minimum, sum of all marks, accending , decending order.
            int[] ak = { 10, 11, 15, 16, 19, 17, 18, 15, 16, 14 };



            Console.WriteLine(" The smallest element :" + " " + ak.Min());
            Console.WriteLine(" The largest element :" + " " + ak.Max());
            Console.WriteLine(" The avarage element :" + " " + ak.Average());
            Console.WriteLine("the sum of elements: " + ak.Sum());



            Array.Sort(ak);
            Console.WriteLine("array ascending order...");
            foreach (int i in ak)
            {
                Console.WriteLine(i + " ");
            }




            Array.Reverse(ak);
            Console.WriteLine("array decending order...");
            foreach (int i in ak)
            {
                Console.Write(i + " ");
            }



            Console.WriteLine(" Enter a string ");
            string Orginal = Console.ReadLine();
            string Reverse = string.Empty;



            for (int i = Orginal.Length - 1; i >= 0; i--)
            {
                Reverse += Orginal[i];
            }
            {
                Console.WriteLine(" REVERESE STRING IS : " + Reverse);

            }

            Console.WriteLine(" Enter a word 1:- ");
            string s1 = Console.ReadLine();
            Console.WriteLine(" Enter a word 2:- ");
            string s2 = Console.ReadLine();



            if (s1 == s2)
            {
                Console.WriteLine(" both words are same ");
            }
            else if (s2 != s1)
            {
                Console.WriteLine(" both words are not same ");
            }



            string str2, rev;
            Console.WriteLine(" enter a word;- ");
            str2 = Console.ReadLine();
            char[] ch = str2.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = str2.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(" " + str2 + " The word is palindrome ");
            }
            else if (b == false)
            {
                Console.WriteLine(" The str is not palindrome ");
            }
            Console.ReadLine();







        }

    }
            








        







}
    


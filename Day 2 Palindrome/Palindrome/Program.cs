using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n, reverse = 0, rem;
                Console.Write("Enter a number: ");
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    rem = n % 10;
                    reverse = reverse * 10 + rem;
                    n /= 10;
                }
                Console.WriteLine("Reversed Number: " + reverse);

            }
            
        }

        private static bool isPalindrome(int inp)
        {
            bool res = false;
            string input = inp.ToString();
            string reverseString="";
            for(int i = 1; i<=input.Length; i++)
            {
                reverseString += input[input.Length -i];
            }
            if(input== reverseString)
            {
                res=true;
            }
            return res;
        }
    }
}

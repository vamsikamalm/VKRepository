using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to reverse: ");
            string str = Console.ReadLine();
            StringBuilder s = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s.Append(str[i]);
            }
            Console.WriteLine("String after reverse: " + s);
            Console.ReadLine();
            
        }
    }
}

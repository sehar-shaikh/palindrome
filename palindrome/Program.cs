using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Enter a string:");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reserve = new string(arr);

           if(str.ToLower().Equals(str_reserve.ToLower()))
            {
                Console.WriteLine("its a palindrome string");
            }
           else
            {
                Console.WriteLine("its not palindrome stirng");
            }

            Console.ReadLine();
            

        }
    }
}

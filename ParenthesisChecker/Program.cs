using System;

namespace ParenthesisChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parenthesis");
            string response = Console.ReadLine();
            int open = CountChars(response, '(');
            int close = CountChars(response, ')');
            if(open == close)
            {
                //Console.WriteLine("The parenthesis don't close");
                Console.WriteLine("The parenthesis close");
            }
            else
            {
                //Console.WriteLine("The parenthesis close");
                Console.WriteLine("The parenthesis don't close");
            }
        }
        public static int CountChars(string text, char search)
        {
            int amount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                //if(text[i] != search)
                //    amount++;
                if (text[i] == search)
                {
                    amount++;
                }
                else if (text[i] == ')' && amount <= 0)
                {
                    return -1;
                }
                else
                {
                    amount--;
                }
            }
            return amount;
        }
    }
}

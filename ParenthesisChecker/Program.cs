using System;
using System.Collections.Generic;

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
            bool cierreCorrecto = CheckParentesis(response);
            if (open == close && cierreCorrecto)
            {
                Console.WriteLine("The parenthesis close");
            }
            else
            {
                Console.WriteLine("The parenthesis don't close");                
            }
        }
        public static int CountChars(string text, char search)
        {
            int amount = 0;
            if (text[0] == '(' && text.Length % 2 == 0)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != search)
                        amount++;
                }
            }
            else
            {
                if (search == '(')
                {
                    amount = 1;
                }
                else
                {
                    amount = 2;
                }
            }
            return amount;
        }

        public static bool CheckParentesis(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    count++;
                }
                else if (text[i] == ')')
                {
                    count--;
                }

                if (count < 0)
                {
                    return false;
                }
            }

            return count == 0;
        }
    }
}

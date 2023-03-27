﻿using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            string response;
            
            
                Console.WriteLine("Enter a number: ");
                response = Console.ReadLine();
                num = int.Parse(response);
                if (IsPrime(num))
                {
                    Console.WriteLine(num + ": is prime");
                }
                else
                {
                    Console.WriteLine(num + ": is not prime");
                }
            
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            else
            {
                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            //TODO
            return true; // estaba en false
        }
    }
}

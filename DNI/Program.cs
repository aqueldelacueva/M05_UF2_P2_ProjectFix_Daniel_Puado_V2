using System;
using System.Collections.Generic;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(int number)
        {
            char letra;
            Dictionary<int, char> letraDni = new Dictionary<int, char>()
            {
                {0, 'T' },
                {1, 'R' },
                {2, 'W' },
                {3, 'A' },
                {4, 'G' },
                {5, 'M' },
                {6, 'Y' },
                {7, 'F' },
                {8, 'P' },
                {9, 'D' },
                {10, 'X' },
                {11, 'B' },
                {12, 'N' },
                {13, 'J' },
                {14, 'Z' },
                {15, 'S' },
                {16, 'Q' },
                {17, 'V' },
                {18, 'H' },
                {19, 'L' },
                {20, 'C' },
                {21, 'K' },
                {22, 'E' },
            };
            int resultado = (int)Math.Round((double)number % 23);
            
            letraDni.TryGetValue(resultado, out letra);
            return letra;
        }
    }
}

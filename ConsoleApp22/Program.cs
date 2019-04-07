using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        public static void PassGenerator()
        {
            int roll;
            int PasswordIntPiece;
            Random rand = new Random();
            var list = new List<char>();
            for (int i = 0; i < 8; i++)
            {
                roll = rand.Next(1, 4);
                if (roll <= 2)
                {
                    PasswordIntPiece = rand.Next(0, 9) + '0';
                    char ConvertToChar = (char)PasswordIntPiece;
                    list.Add(ConvertToChar);
                }
                else if (roll > 2)
                {
                    int AlphabetPasswordPiece = rand.Next(0, 26);
                    string Alphabet = "abcdefghijklmnopqrstuvwxyz";
                    list.Add(Alphabet[AlphabetPasswordPiece]);
                }
                Console.Write(list[i]);
            }
        }
        static void Main(string[] args)
        {
            PassGenerator();
            Console.ReadKey();
        }
    }
}

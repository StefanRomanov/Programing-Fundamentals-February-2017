using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":

                    int userNum1 = int.Parse(Console.ReadLine());
                    int userNum2 = int.Parse(Console.ReadLine());

                    int resultInt = GetMax(userNum1, userNum2);

                    Console.WriteLine(resultInt);

                    break;

                case "char":

                    char userChar1 = char.Parse(Console.ReadLine());
                    char userChar2 = char.Parse(Console.ReadLine());

                    char resultChar  = GetMax(userChar1, userChar2);

                    Console.WriteLine(resultChar);

                    break;

                case "string":

                    string userString1 = Console.ReadLine();
                    string userString2 = Console.ReadLine();

                    string resultString = GetMax(userString1,userString2);

                    Console.WriteLine(resultString);

                    break;
                default:
                    break;
            }
        }
        public static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        public static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        public static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}

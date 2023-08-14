using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minNum = 1;
            const int maxNum = 100;

            for (int i = minNum; i <= maxNum; i++)
            {
                string outputItem = "";

                outputItem += OutputTester(i, 3, "fizz");
                outputItem += OutputTester(i, 5, "buzz");

                if (outputItem.Length == 0)
                {
                    outputItem = i.ToString();
                }
                Console.WriteLine(outputItem);
            }

            Console.ReadLine();
        }

        static string OutputTester(int currNum, int compNum, string output)
        {
            if (currNum % compNum == 0)
            {
                return output;
            }
            else return "";
        }
    }
}

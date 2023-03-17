using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreobrazuvaneOt10VN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chisla na edin red: ");
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num1 = input[0];
            int num2 = input[1];
            Console.WriteLine(NumberinNthSystem(num1, num2));
        }

        private static string NumberinNthSystem(int numsys, int number)
        {
            string NewNumber = "";
            while (number > 0)
            {
                int count = number % numsys;
                NewNumber = count.ToString() + NewNumber;
                number = number / numsys;
            }
            NewNumber = string.Join("", NewNumber);
            return NewNumber;
        }
    }
}
    


